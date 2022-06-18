using Microsoft.Extensions.Hosting;
using RP.Deployer.Commons.Model.Dto;
using RP.Framework.Helpers;
using RP.Framework.Logger;
using RP.Framework.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;
using Const = RP.Deployer.Commons.Core.Constants;

namespace RP.Deployer
{
    public class Worker : BackgroundService
    {
        public ILoggerManager _log = new LoggerManager();
        private readonly MailManager mailManager = MailManager.GetInstance();

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                int timeExecution = ConfigurationManager.AppSettings[Const.EXECUTION_SECONDS].GetValInt32() * 1000;
                while (!stoppingToken.IsCancellationRequested)
                {
                    _log.Info("RP.Deployer corriendo");
                    try
                    {
                        string pathFileJson = ConfigurationManager.AppSettings[Const.STEP_CONFIG_FLE].GetValStr();
                        if (File.Exists(pathFileJson))
                        {
                            string dataJsonStr = File.ReadAllText(pathFileJson);
                            StepConfigDto stepConfig = HelperJson.Deserialize<StepConfigDto>(dataJsonStr);
                            string currentTime = DateTime.Now.ToString(Const.FORMAT_TIME);
                            if (currentTime == stepConfig.TimeExecution)
                            {
                                MoveJson(ConfigurationManager.AppSettings[Const.STEP_CONFIG_FLE].GetValStr());
                                StartDeploy(stepConfig);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        SendMail(null, false, ex.Message);
                        _log.Error(ex);
                    }
                    await Task.Delay(timeExecution, stoppingToken);
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        public void StartDeploy(StepConfigDto stepConfig)
        {
            try
            {
                _log.Info($"Start Deploy: {stepConfig.Title}");
                foreach (var step in stepConfig.Steps)
                {
                    _log.Info($"Start Step: {step.StepId}-{step.StepName}");
                    ExecuteStep(step);
                }
                _log.Info($"Finish Deploy: {stepConfig.Title}");
                SendMail(stepConfig, true);
            }
            catch (Exception ex)
            {
                SendMail(stepConfig, false, ex.Message);
                _log.Error(ex);
            }
        }

        public void ExecuteStep(StepDto step)
        {
            switch (step.StepType)
            {
                case Const.STEP_TYPE_CMD:
                    ExecuteCmd(step);
                    break;
                case Const.STEP_TYPE_COPY:
                    ExecuteCopy(step);
                    break;
                case Const.STEP_TYPE_ZIP:
                    ExecuteZip(step);
                    break;
                case Const.STEP_TYPE_UNZIP:
                    ExecuteUnzip(step);
                    break;

                default:
                    throw new Exception($"Step no configurado: {step.StepType}");
            }
        }

        public void ExecuteCmd(StepDto step)
        {
            string command = step.StepCode;
            _log.Info($"Command to execute: {command}");
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = false;
            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            string result = proc.StandardOutput.ReadToEnd();
            _log.Info($"Console result: {result}");
        }

        public void ExecuteCopy(StepDto step)
        {
            bool isFile;
            StepTypeCopyDto copyDto = HelperJson.Deserialize<StepTypeCopyDto>(step.StepCode);
            _log.Info($"Source: {copyDto.Source}");
            _log.Info($"Destination; {copyDto.Destination}");

            FileAttributes attr = File.GetAttributes(copyDto.Source);
            if (attr.HasFlag(FileAttributes.Directory))
                isFile = false;
            else
                isFile = true;

            if (isFile)
            {
                string pathBackup = $"{copyDto.Destination}";
                if (!Directory.Exists(pathBackup))
                    Directory.CreateDirectory(pathBackup);
                pathBackup = $"{copyDto.Destination}\\{Path.GetFileName(copyDto.Source)}";
                File.Copy(copyDto.Source, pathBackup);
            }
            else
            {
                string sourcePath = copyDto.Source;
                string targetPath = $"{copyDto.Destination}";
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                }
            }
        }

        public void ExecuteZip(StepDto step)
        {
            StepTypeZipDto zip = HelperJson.Deserialize<StepTypeZipDto>(step.StepCode);
            var outFileName = Path.GetFileNameWithoutExtension(zip.NameFileZipResult) + ".zip";
            var zipFileName = Path.Combine(zip.Destination, outFileName);

            _log.Info($"NameFileZipResult: {zip.NameFileZipResult}");
            _log.Info($"Source: {zip.Source}");
            _log.Info($"Destination: {zip.Destination}");

            bool isFile;
            FileAttributes attr = File.GetAttributes(zip.Source);
            if (attr.HasFlag(FileAttributes.Directory))
                isFile = false;
            else
                isFile = true;

            if (isFile)
            {
                using (ZipArchive archive = ZipFile.Open(zipFileName, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(zip.Source, Path.GetFileName(zip.Source));
                }
            }
            else
            {
                ZipFile.CreateFromDirectory(zip.Source, zipFileName);
            }
        }

        public void ExecuteUnzip(StepDto step)
        {
            StepTypeUnZipDto unzip = HelperJson.Deserialize<StepTypeUnZipDto>(step.StepCode);
            _log.Info($"PathFileZip: {unzip.PathFileZip}");
            _log.Info($"Destination: {unzip.Destination}");
            using (var archive = ZipFile.Open(unzip.PathFileZip, ZipArchiveMode.Read))
            {
                archive.ExtractToDirectory(unzip.Destination);
            }
        }

        public void SendMail(StepConfigDto stepConfig, bool success, string messageError = "")
        {
            MailDTO mail = new MailDTO()
            {
                SUBJECT = success ? "Despliegue Exitoso" : "Despliegue Fallido",
                MESSAGE = success ? $"Se realizo el despliegue {stepConfig.Title} exitosamente." : $"Error al ejecutar el despliegue: {messageError}",
                PRIORITY = success ? 2 : 3
            };
            mail.TO = new List<MailToDto>();
            if (!success && stepConfig == null)
            {
                mail.TO.Add(new MailToDto() { MAIL = ConfigurationManager.AppSettings[Const.CONTACT_EMERGENCY].GetValStr() });
            }
            else
            {
                foreach (var et in stepConfig.MailNotification)
                {
                    mail.TO.Add(new MailToDto() { MAIL = et.Mail });
                }
            }
            if (!mailManager.SendMessage(mail))
                _log.Error("No se pudo enviar el correo al los Contactos.");
            else
                _log.Info("Se Envio el Correo Exitosamente");
        }

        public void MoveJson(string pathFile)
        {
            string nameFile = Path.GetFileNameWithoutExtension(pathFile);
            string pathHistory = ConfigurationManager.AppSettings[Const.FOLDER_HISTORY_JSON].GetValStr();
            if (!Directory.Exists(pathHistory))
                Directory.CreateDirectory(pathHistory);
            _log.Info($"Se Movio archivo stepConfig.json al Historial: {pathHistory}\\{nameFile}_{DateTime.Now.ToString(Const.FORMAT_DATE_TIME)}.json");
            File.Move(pathFile, $"{pathHistory}\\{nameFile}_{DateTime.Now.ToString(Const.FORMAT_DATE_TIME)}.json");
        }
    }
}