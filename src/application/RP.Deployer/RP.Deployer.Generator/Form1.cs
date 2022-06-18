using Newtonsoft.Json;
using RP.Deployer.Commons.Model.Dto;
using RP.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Const = RP.Deployer.Commons.Core.Constants;

namespace RP.Deployer.Generator
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        string stepCodeType;
        int stepid = 0;

        public Form1()
        {
            InitializeComponent();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("Tipo");
            dataTable.Columns.Add("StepCode");
            RenderTable();
        }

        private void CboStepType_SelectedIndexChanged(object sender, EventArgs e)
        {
            stepCodeType = CboStepType.Text;

            LbCommand.Visible = false;
            TxtCommand.Visible = false;

            LbCopySource.Visible = false;
            TxtCopySource.Visible = false;
            LbCopyDestination.Visible = false;
            TxtCopyDestination.Visible = false;

            LbZipNameFileResult.Visible = false;
            TxtZipNameFileResult.Visible = false;
            LbZipOrigin.Visible = false;
            TxtZipOrigin.Visible = false;
            LbZipDestination.Visible = false;
            TxtZipDestination.Visible = false;

            LbUnzipFile.Visible = false;
            TxtUnzipFile.Visible = false;
            LbUnzipDestination.Visible = false;
            TxtUnzipDestination.Visible = false;

            switch (stepCodeType)
            {
                case Const.STEP_TYPE_CMD:
                    LbCommand.Visible = true;
                    TxtCommand.Visible = true;
                    break;
                case Const.STEP_TYPE_COPY:
                    LbCopySource.Visible = true;
                    TxtCopySource.Visible = true;
                    LbCopyDestination.Visible = true;
                    TxtCopyDestination.Visible = true;
                    break;
                case Const.STEP_TYPE_ZIP:
                    LbZipNameFileResult.Visible = true;
                    TxtZipNameFileResult.Visible = true;
                    LbZipOrigin.Visible = true;
                    TxtZipOrigin.Visible = true;
                    LbZipDestination.Visible = true;
                    TxtZipDestination.Visible = true;
                    break;
                case Const.STEP_TYPE_UNZIP:
                    LbUnzipFile.Visible = true;
                    TxtUnzipFile.Visible = true;
                    LbUnzipDestination.Visible = true;
                    TxtUnzipDestination.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void RenderTable()
        {
            StepsData.DataSource = dataTable;
        }

        private void BtnAddStep_Click(object sender, EventArgs e)
        {
            stepid += 1;
            DataRow row = dataTable.NewRow();
            row["Id"] = stepid;
            row["Nombre"] = TxtStepName.Text;
            row["Tipo"] = stepCodeType;

            string stepCode;
            switch (stepCodeType)
            {
                case Const.STEP_TYPE_CMD:
                    StepTypeCmdDto cmd = new StepTypeCmdDto();
                    cmd.Cmd = TxtCommand.Text;
                    stepCode = TxtCommand.Text;
                    break;
                case Const.STEP_TYPE_COPY:
                    StepTypeCopyDto copy = new StepTypeCopyDto();
                    copy.Source = TxtCopySource.Text;
                    copy.Destination = TxtCopyDestination.Text;
                    stepCode = HelperJson.Serialize(copy);
                    break;
                case Const.STEP_TYPE_ZIP:
                    StepTypeZipDto zip = new StepTypeZipDto();
                    zip.NameFileZipResult = TxtZipNameFileResult.Text;
                    zip.Source = TxtZipOrigin.Text;
                    zip.Destination = TxtZipDestination.Text;
                    stepCode = HelperJson.Serialize(zip);
                    break;
                case Const.STEP_TYPE_UNZIP:
                    StepTypeUnZipDto unzip = new StepTypeUnZipDto();
                    unzip.PathFileZip = TxtUnzipFile.Text;
                    unzip.Destination = TxtUnzipDestination.Text;
                    stepCode = HelperJson.Serialize(unzip);
                    break;

                default:
                    throw new Exception($"Ocurrio un Error al Procesar el Step: {stepCodeType}");
            }
            row["StepCode"] = stepCode;
            dataTable.Rows.Add(row);
            CleanControls();
            RenderTable();
        }

        private void CleanControls(bool allControl = false)
        {
            if (allControl)
            {
                TxtTitle.Text = string.Empty;
                TxtTime.Text = string.Empty;
            }
            TxtStepName.Text = string.Empty;
            CboStepType.Text = string.Empty;
            TxtCommand.Text = string.Empty;
            TxtCopySource.Text = string.Empty;
            TxtCopyDestination.Text = string.Empty;
            TxtZipNameFileResult.Text = string.Empty;
            TxtZipDestination.Text = string.Empty;
            TxtZipOrigin.Text = string.Empty;
            TxtUnzipFile.Text = string.Empty;
            TxtUnzipDestination.Text = string.Empty;
        }

        private void BtnGenerateJson_Click(object sender, EventArgs e)
        {
            StepConfigDto stepConfigDto = new StepConfigDto();
            stepConfigDto.Title = TxtTitle.Text;
            stepConfigDto.TimeExecution = TxtTime.Text;
            stepConfigDto.Steps = new List<StepDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                stepConfigDto.Steps.Add(new StepDto()
                {
                    StepId = row["Id"].GetValInt32(),
                    StepName = row["Nombre"].GetValStr(),
                    StepType = row["Tipo"].GetValStr(),
                    StepCode = row["StepCode"].GetValStr(),
                });
            }

            List<string> listMail = TxtMailList.Text.Split(";").ToList();
            stepConfigDto.MailNotification = new List<MailDto>();
            foreach (string mail in listMail)
            {
                stepConfigDto.MailNotification.Add(new MailDto(){ Mail = mail });
            }
            string jsonResult = JsonConvert.SerializeObject(stepConfigDto, Formatting.Indented);
            TxtJsonResult.Text = jsonResult;
        }
    }
}