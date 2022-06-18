
namespace RP.Deployer.Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StepsData = new System.Windows.Forms.DataGridView();
            this.BtnGenerateJson = new System.Windows.Forms.Button();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.TxtStepName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboStepType = new System.Windows.Forms.ComboBox();
            this.BtnAddStep = new System.Windows.Forms.Button();
            this.TxtCommand = new System.Windows.Forms.TextBox();
            this.LbCommand = new System.Windows.Forms.Label();
            this.TxtCopySource = new System.Windows.Forms.TextBox();
            this.LbCopySource = new System.Windows.Forms.Label();
            this.TxtCopyDestination = new System.Windows.Forms.TextBox();
            this.LbCopyDestination = new System.Windows.Forms.Label();
            this.TxtZipOrigin = new System.Windows.Forms.TextBox();
            this.LbZipOrigin = new System.Windows.Forms.Label();
            this.TxtZipNameFileResult = new System.Windows.Forms.TextBox();
            this.LbZipNameFileResult = new System.Windows.Forms.Label();
            this.TxtZipDestination = new System.Windows.Forms.TextBox();
            this.LbZipDestination = new System.Windows.Forms.Label();
            this.TxtUnzipDestination = new System.Windows.Forms.TextBox();
            this.LbUnzipDestination = new System.Windows.Forms.Label();
            this.TxtUnzipFile = new System.Windows.Forms.TextBox();
            this.LbUnzipFile = new System.Windows.Forms.Label();
            this.TxtJsonResult = new System.Windows.Forms.TextBox();
            this.TxtMailList = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StepsData)).BeginInit();
            this.SuspendLayout();
            // 
            // StepsData
            // 
            this.StepsData.AllowUserToAddRows = false;
            this.StepsData.AllowUserToDeleteRows = false;
            this.StepsData.AllowUserToOrderColumns = true;
            this.StepsData.AllowUserToResizeRows = false;
            this.StepsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StepsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StepsData.Location = new System.Drawing.Point(368, 62);
            this.StepsData.Name = "StepsData";
            this.StepsData.ReadOnly = true;
            this.StepsData.RowHeadersVisible = false;
            this.StepsData.RowTemplate.Height = 25;
            this.StepsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StepsData.Size = new System.Drawing.Size(550, 333);
            this.StepsData.TabIndex = 0;
            // 
            // BtnGenerateJson
            // 
            this.BtnGenerateJson.Location = new System.Drawing.Point(12, 600);
            this.BtnGenerateJson.Name = "BtnGenerateJson";
            this.BtnGenerateJson.Size = new System.Drawing.Size(350, 49);
            this.BtnGenerateJson.TabIndex = 1;
            this.BtnGenerateJson.Text = "Generar";
            this.BtnGenerateJson.UseVisualStyleBackColor = true;
            this.BtnGenerateJson.Click += new System.EventHandler(this.BtnGenerateJson_Click);
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(94, 21);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(521, 23);
            this.TxtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(728, 21);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(190, 23);
            this.TxtTime.TabIndex = 5;
            // 
            // TxtStepName
            // 
            this.TxtStepName.Location = new System.Drawing.Point(94, 62);
            this.TxtStepName.Name = "TxtStepName";
            this.TxtStepName.Size = new System.Drawing.Size(254, 23);
            this.TxtStepName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo:";
            // 
            // CboStepType
            // 
            this.CboStepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStepType.FormattingEnabled = true;
            this.CboStepType.Items.AddRange(new object[] {
            "CMD",
            "COPY",
            "ZIP",
            "UNZIP"});
            this.CboStepType.Location = new System.Drawing.Point(94, 91);
            this.CboStepType.Name = "CboStepType";
            this.CboStepType.Size = new System.Drawing.Size(253, 23);
            this.CboStepType.TabIndex = 12;
            this.CboStepType.SelectedIndexChanged += new System.EventHandler(this.CboStepType_SelectedIndexChanged);
            // 
            // BtnAddStep
            // 
            this.BtnAddStep.Location = new System.Drawing.Point(12, 346);
            this.BtnAddStep.Name = "BtnAddStep";
            this.BtnAddStep.Size = new System.Drawing.Size(349, 49);
            this.BtnAddStep.TabIndex = 13;
            this.BtnAddStep.Text = "Agregar Paso";
            this.BtnAddStep.UseVisualStyleBackColor = true;
            this.BtnAddStep.Click += new System.EventHandler(this.BtnAddStep_Click);
            // 
            // TxtCommand
            // 
            this.TxtCommand.Location = new System.Drawing.Point(93, 154);
            this.TxtCommand.Name = "TxtCommand";
            this.TxtCommand.Size = new System.Drawing.Size(254, 23);
            this.TxtCommand.TabIndex = 15;
            this.TxtCommand.Visible = false;
            // 
            // LbCommand
            // 
            this.LbCommand.AutoSize = true;
            this.LbCommand.Location = new System.Drawing.Point(11, 157);
            this.LbCommand.Name = "LbCommand";
            this.LbCommand.Size = new System.Drawing.Size(67, 15);
            this.LbCommand.TabIndex = 14;
            this.LbCommand.Text = "Command:";
            this.LbCommand.Visible = false;
            // 
            // TxtCopySource
            // 
            this.TxtCopySource.Location = new System.Drawing.Point(94, 154);
            this.TxtCopySource.Name = "TxtCopySource";
            this.TxtCopySource.Size = new System.Drawing.Size(254, 23);
            this.TxtCopySource.TabIndex = 17;
            this.TxtCopySource.Visible = false;
            // 
            // LbCopySource
            // 
            this.LbCopySource.AutoSize = true;
            this.LbCopySource.Location = new System.Drawing.Point(12, 157);
            this.LbCopySource.Name = "LbCopySource";
            this.LbCopySource.Size = new System.Drawing.Size(46, 15);
            this.LbCopySource.TabIndex = 16;
            this.LbCopySource.Text = "Origen:";
            this.LbCopySource.Visible = false;
            // 
            // TxtCopyDestination
            // 
            this.TxtCopyDestination.Location = new System.Drawing.Point(94, 183);
            this.TxtCopyDestination.Name = "TxtCopyDestination";
            this.TxtCopyDestination.Size = new System.Drawing.Size(254, 23);
            this.TxtCopyDestination.TabIndex = 19;
            this.TxtCopyDestination.Visible = false;
            // 
            // LbCopyDestination
            // 
            this.LbCopyDestination.AutoSize = true;
            this.LbCopyDestination.Location = new System.Drawing.Point(12, 186);
            this.LbCopyDestination.Name = "LbCopyDestination";
            this.LbCopyDestination.Size = new System.Drawing.Size(50, 15);
            this.LbCopyDestination.TabIndex = 18;
            this.LbCopyDestination.Text = "Destino:";
            this.LbCopyDestination.Visible = false;
            // 
            // TxtZipOrigin
            // 
            this.TxtZipOrigin.Location = new System.Drawing.Point(94, 183);
            this.TxtZipOrigin.Name = "TxtZipOrigin";
            this.TxtZipOrigin.Size = new System.Drawing.Size(254, 23);
            this.TxtZipOrigin.TabIndex = 23;
            this.TxtZipOrigin.Visible = false;
            // 
            // LbZipOrigin
            // 
            this.LbZipOrigin.AutoSize = true;
            this.LbZipOrigin.Location = new System.Drawing.Point(12, 186);
            this.LbZipOrigin.Name = "LbZipOrigin";
            this.LbZipOrigin.Size = new System.Drawing.Size(46, 15);
            this.LbZipOrigin.TabIndex = 22;
            this.LbZipOrigin.Text = "Origen:";
            this.LbZipOrigin.Visible = false;
            // 
            // TxtZipNameFileResult
            // 
            this.TxtZipNameFileResult.Location = new System.Drawing.Point(94, 154);
            this.TxtZipNameFileResult.Name = "TxtZipNameFileResult";
            this.TxtZipNameFileResult.Size = new System.Drawing.Size(254, 23);
            this.TxtZipNameFileResult.TabIndex = 21;
            this.TxtZipNameFileResult.Visible = false;
            // 
            // LbZipNameFileResult
            // 
            this.LbZipNameFileResult.AutoSize = true;
            this.LbZipNameFileResult.Location = new System.Drawing.Point(12, 157);
            this.LbZipNameFileResult.Name = "LbZipNameFileResult";
            this.LbZipNameFileResult.Size = new System.Drawing.Size(74, 15);
            this.LbZipNameFileResult.TabIndex = 20;
            this.LbZipNameFileResult.Text = "Nombre Zip:";
            this.LbZipNameFileResult.Visible = false;
            // 
            // TxtZipDestination
            // 
            this.TxtZipDestination.Location = new System.Drawing.Point(94, 212);
            this.TxtZipDestination.Name = "TxtZipDestination";
            this.TxtZipDestination.Size = new System.Drawing.Size(254, 23);
            this.TxtZipDestination.TabIndex = 25;
            this.TxtZipDestination.Visible = false;
            // 
            // LbZipDestination
            // 
            this.LbZipDestination.AutoSize = true;
            this.LbZipDestination.Location = new System.Drawing.Point(12, 215);
            this.LbZipDestination.Name = "LbZipDestination";
            this.LbZipDestination.Size = new System.Drawing.Size(50, 15);
            this.LbZipDestination.TabIndex = 24;
            this.LbZipDestination.Text = "Destino:";
            this.LbZipDestination.Visible = false;
            // 
            // TxtUnzipDestination
            // 
            this.TxtUnzipDestination.Location = new System.Drawing.Point(94, 183);
            this.TxtUnzipDestination.Name = "TxtUnzipDestination";
            this.TxtUnzipDestination.Size = new System.Drawing.Size(254, 23);
            this.TxtUnzipDestination.TabIndex = 29;
            this.TxtUnzipDestination.Visible = false;
            // 
            // LbUnzipDestination
            // 
            this.LbUnzipDestination.AutoSize = true;
            this.LbUnzipDestination.Location = new System.Drawing.Point(12, 186);
            this.LbUnzipDestination.Name = "LbUnzipDestination";
            this.LbUnzipDestination.Size = new System.Drawing.Size(50, 15);
            this.LbUnzipDestination.TabIndex = 28;
            this.LbUnzipDestination.Text = "Destino:";
            this.LbUnzipDestination.Visible = false;
            // 
            // TxtUnzipFile
            // 
            this.TxtUnzipFile.Location = new System.Drawing.Point(94, 154);
            this.TxtUnzipFile.Name = "TxtUnzipFile";
            this.TxtUnzipFile.Size = new System.Drawing.Size(254, 23);
            this.TxtUnzipFile.TabIndex = 27;
            this.TxtUnzipFile.Visible = false;
            // 
            // LbUnzipFile
            // 
            this.LbUnzipFile.AutoSize = true;
            this.LbUnzipFile.Location = new System.Drawing.Point(12, 157);
            this.LbUnzipFile.Name = "LbUnzipFile";
            this.LbUnzipFile.Size = new System.Drawing.Size(71, 15);
            this.LbUnzipFile.TabIndex = 26;
            this.LbUnzipFile.Text = "Archivo Zip:";
            this.LbUnzipFile.Visible = false;
            // 
            // TxtJsonResult
            // 
            this.TxtJsonResult.Location = new System.Drawing.Point(368, 401);
            this.TxtJsonResult.Multiline = true;
            this.TxtJsonResult.Name = "TxtJsonResult";
            this.TxtJsonResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtJsonResult.Size = new System.Drawing.Size(550, 248);
            this.TxtJsonResult.TabIndex = 30;
            // 
            // TxtMailList
            // 
            this.TxtMailList.Location = new System.Drawing.Point(13, 425);
            this.TxtMailList.Multiline = true;
            this.TxtMailList.Name = "TxtMailList";
            this.TxtMailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMailList.Size = new System.Drawing.Size(348, 169);
            this.TxtMailList.TabIndex = 31;
            this.TxtMailList.Text = "roberto.prado23@hotmail.com; robertoprado554@gmail.com";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Listado de Correos a Notificar, separe con ;";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMailList);
            this.Controls.Add(this.TxtJsonResult);
            this.Controls.Add(this.TxtUnzipDestination);
            this.Controls.Add(this.LbUnzipDestination);
            this.Controls.Add(this.TxtUnzipFile);
            this.Controls.Add(this.LbUnzipFile);
            this.Controls.Add(this.TxtZipDestination);
            this.Controls.Add(this.LbZipDestination);
            this.Controls.Add(this.TxtZipOrigin);
            this.Controls.Add(this.LbZipOrigin);
            this.Controls.Add(this.TxtZipNameFileResult);
            this.Controls.Add(this.LbZipNameFileResult);
            this.Controls.Add(this.TxtCopyDestination);
            this.Controls.Add(this.LbCopyDestination);
            this.Controls.Add(this.TxtCopySource);
            this.Controls.Add(this.LbCopySource);
            this.Controls.Add(this.TxtCommand);
            this.Controls.Add(this.LbCommand);
            this.Controls.Add(this.BtnAddStep);
            this.Controls.Add(this.CboStepType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStepName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.BtnGenerateJson);
            this.Controls.Add(this.StepsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP.Deployer";
            ((System.ComponentModel.ISupportInitialize)(this.StepsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StepsData;
        private System.Windows.Forms.Button BtnGenerateJson;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.TextBox TxtStepName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboStepType;
        private System.Windows.Forms.Button BtnAddStep;
        private System.Windows.Forms.TextBox TxtCommand;
        private System.Windows.Forms.Label LbCommand;
        private System.Windows.Forms.TextBox TxtCopySource;
        private System.Windows.Forms.Label LbCopySource;
        private System.Windows.Forms.TextBox TxtCopyDestination;
        private System.Windows.Forms.Label LbCopyDestination;
        private System.Windows.Forms.TextBox TxtZipOrigin;
        private System.Windows.Forms.Label LbZipOrigin;
        private System.Windows.Forms.TextBox TxtZipNameFileResult;
        private System.Windows.Forms.Label LbZipNameFileResult;
        private System.Windows.Forms.TextBox TxtZipDestination;
        private System.Windows.Forms.Label LbZipDestination;
        private System.Windows.Forms.TextBox TxtUnzipDestination;
        private System.Windows.Forms.Label LbUnzipDestination;
        private System.Windows.Forms.TextBox TxtUnzipFile;
        private System.Windows.Forms.Label LbUnzipFile;
        private System.Windows.Forms.TextBox TxtJsonResult;
        private System.Windows.Forms.TextBox TxtMailList;
        private System.Windows.Forms.Label label5;
    }
}

