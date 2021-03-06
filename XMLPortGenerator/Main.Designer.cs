﻿namespace XMLPortGenerator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSourceTableNo = new System.Windows.Forms.Label();
            this.nudSourceTableNo = new System.Windows.Forms.NumericUpDown();
            this.nudXMLPortNo = new System.Windows.Forms.NumericUpDown();
            this.lblXMLPortNumber = new System.Windows.Forms.Label();
            this.lblSourceTableName = new System.Windows.Forms.Label();
            this.txtSourceTableName = new System.Windows.Forms.TextBox();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.txtXMLPort = new System.Windows.Forms.TextBox();
            this.lblXMLPort = new System.Windows.Forms.Label();
            this.lblFields = new System.Windows.Forms.Label();
            this.btnStartProcessing = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TableObjectOption = new System.Windows.Forms.RadioButton();
            this.CSVFileOption = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSourceTableNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXMLPortNo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourceTableNo
            // 
            this.lblSourceTableNo.AutoSize = true;
            this.lblSourceTableNo.Location = new System.Drawing.Point(12, 9);
            this.lblSourceTableNo.Name = "lblSourceTableNo";
            this.lblSourceTableNo.Size = new System.Drawing.Size(111, 13);
            this.lblSourceTableNo.TabIndex = 0;
            this.lblSourceTableNo.Text = "Source Table Number";
            // 
            // nudSourceTableNo
            // 
            this.nudSourceTableNo.Location = new System.Drawing.Point(129, 7);
            this.nudSourceTableNo.Maximum = new decimal(new int[] {
            2000000130,
            0,
            0,
            0});
            this.nudSourceTableNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSourceTableNo.Name = "nudSourceTableNo";
            this.nudSourceTableNo.Size = new System.Drawing.Size(143, 20);
            this.nudSourceTableNo.TabIndex = 1;
            this.nudSourceTableNo.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // nudXMLPortNo
            // 
            this.nudXMLPortNo.Location = new System.Drawing.Point(129, 61);
            this.nudXMLPortNo.Maximum = new decimal(new int[] {
            2000000130,
            0,
            0,
            0});
            this.nudXMLPortNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudXMLPortNo.Name = "nudXMLPortNo";
            this.nudXMLPortNo.Size = new System.Drawing.Size(143, 20);
            this.nudXMLPortNo.TabIndex = 5;
            this.nudXMLPortNo.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // lblXMLPortNumber
            // 
            this.lblXMLPortNumber.AutoSize = true;
            this.lblXMLPortNumber.Location = new System.Drawing.Point(12, 63);
            this.lblXMLPortNumber.Name = "lblXMLPortNumber";
            this.lblXMLPortNumber.Size = new System.Drawing.Size(88, 13);
            this.lblXMLPortNumber.TabIndex = 4;
            this.lblXMLPortNumber.Text = "XMLPort Number";
            // 
            // lblSourceTableName
            // 
            this.lblSourceTableName.AutoSize = true;
            this.lblSourceTableName.Location = new System.Drawing.Point(12, 38);
            this.lblSourceTableName.Name = "lblSourceTableName";
            this.lblSourceTableName.Size = new System.Drawing.Size(102, 13);
            this.lblSourceTableName.TabIndex = 2;
            this.lblSourceTableName.Text = "Source Table Name";
            // 
            // txtSourceTableName
            // 
            this.txtSourceTableName.Location = new System.Drawing.Point(129, 35);
            this.txtSourceTableName.Name = "txtSourceTableName";
            this.txtSourceTableName.Size = new System.Drawing.Size(143, 20);
            this.txtSourceTableName.TabIndex = 3;
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(129, 87);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(143, 20);
            this.txtDelimiter.TabIndex = 7;
            this.txtDelimiter.Text = "\"";
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(12, 90);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(47, 13);
            this.lblDelimiter.TabIndex = 6;
            this.lblDelimiter.Text = "Delimiter";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(129, 113);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(143, 20);
            this.txtSeparator.TabIndex = 9;
            this.txtSeparator.Text = "[;]";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(12, 116);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(53, 13);
            this.lblSeparator.TabIndex = 8;
            this.lblSeparator.Text = "Separator";
            // 
            // txtFields
            // 
            this.txtFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFields.Location = new System.Drawing.Point(13, 243);
            this.txtFields.MaxLength = 0;
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.Size = new System.Drawing.Size(390, 353);
            this.txtFields.TabIndex = 11;
            this.txtFields.Text = "Field Name 1;Field Name 2;Field Name 3";
            this.txtFields.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFields_KeyDown);
            // 
            // txtXMLPort
            // 
            this.txtXMLPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLPort.Location = new System.Drawing.Point(412, 243);
            this.txtXMLPort.MaxLength = 0;
            this.txtXMLPort.Multiline = true;
            this.txtXMLPort.Name = "txtXMLPort";
            this.txtXMLPort.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLPort.Size = new System.Drawing.Size(390, 353);
            this.txtXMLPort.TabIndex = 13;
            this.txtXMLPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXMLPort_KeyDown);
            // 
            // lblXMLPort
            // 
            this.lblXMLPort.AutoSize = true;
            this.lblXMLPort.Location = new System.Drawing.Point(409, 215);
            this.lblXMLPort.Name = "lblXMLPort";
            this.lblXMLPort.Size = new System.Drawing.Size(48, 13);
            this.lblXMLPort.TabIndex = 12;
            this.lblXMLPort.Text = "XMLPort";
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(12, 215);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(34, 13);
            this.lblFields.TabIndex = 10;
            this.lblFields.Text = "Fields";
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.Location = new System.Drawing.Point(530, 12);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(102, 43);
            this.btnStartProcessing.TabIndex = 14;
            this.btnStartProcessing.Text = "Generate XMLPort";
            this.btnStartProcessing.UseVisualStyleBackColor = true;
            this.btnStartProcessing.Click += new System.EventHandler(this.btnStartProcessing_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(638, 12);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(102, 43);
            this.btnSaveToFile.TabIndex = 15;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Load From File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TableObjectOption
            // 
            this.TableObjectOption.AutoSize = true;
            this.TableObjectOption.Checked = true;
            this.TableObjectOption.Location = new System.Drawing.Point(23, 19);
            this.TableObjectOption.Name = "TableObjectOption";
            this.TableObjectOption.Size = new System.Drawing.Size(129, 17);
            this.TableObjectOption.TabIndex = 17;
            this.TableObjectOption.TabStop = true;
            this.TableObjectOption.Text = "Table Object Text File";
            this.TableObjectOption.UseVisualStyleBackColor = true;
            // 
            // CSVFileOption
            // 
            this.CSVFileOption.AutoSize = true;
            this.CSVFileOption.Location = new System.Drawing.Point(23, 42);
            this.CSVFileOption.Name = "CSVFileOption";
            this.CSVFileOption.Size = new System.Drawing.Size(65, 17);
            this.CSVFileOption.TabIndex = 18;
            this.CSVFileOption.TabStop = true;
            this.CSVFileOption.Text = "CSV File";
            this.CSVFileOption.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableObjectOption);
            this.groupBox1.Controls.Add(this.CSVFileOption);
            this.groupBox1.Location = new System.Drawing.Point(15, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fields File Format";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.lblXMLPort);
            this.Controls.Add(this.txtXMLPort);
            this.Controls.Add(this.txtFields);
            this.Controls.Add(this.txtSeparator);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.txtDelimiter);
            this.Controls.Add(this.lblDelimiter);
            this.Controls.Add(this.txtSourceTableName);
            this.Controls.Add(this.lblSourceTableName);
            this.Controls.Add(this.nudXMLPortNo);
            this.Controls.Add(this.lblXMLPortNumber);
            this.Controls.Add(this.nudSourceTableNo);
            this.Controls.Add(this.lblSourceTableNo);
            this.MinimumSize = new System.Drawing.Size(830, 574);
            this.Name = "Main";
            this.Text = "XMLPort Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudSourceTableNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXMLPortNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceTableNo;
        private System.Windows.Forms.NumericUpDown nudSourceTableNo;
        private System.Windows.Forms.NumericUpDown nudXMLPortNo;
        private System.Windows.Forms.Label lblXMLPortNumber;
        private System.Windows.Forms.Label lblSourceTableName;
        private System.Windows.Forms.TextBox txtSourceTableName;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.TextBox txtXMLPort;
        private System.Windows.Forms.Label lblXMLPort;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.Button btnStartProcessing;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton TableObjectOption;
        private System.Windows.Forms.RadioButton CSVFileOption;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

