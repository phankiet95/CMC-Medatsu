namespace CMC_Medatsu
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPIC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNumberDigit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new MetroFramework.Controls.MetroButton();
            this.workPanel = new System.Windows.Forms.Panel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFunctionName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtStartIndex = new MetroFramework.Controls.MetroTextBox();
            this.btnGoIndexing = new MetroFramework.Controls.MetroButton();
            this.cboWorkSheet = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblFile = new MetroFramework.Controls.MetroLabel();
            this.formIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.workPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(881, 450);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPIC);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtNumberDigit);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPIC
            // 
            this.txtPIC.Location = new System.Drawing.Point(105, 69);
            this.txtPIC.Name = "txtPIC";
            this.txtPIC.Size = new System.Drawing.Size(110, 23);
            this.txtPIC.TabIndex = 13;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 73);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "PIC:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(105, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(110, 23);
            this.txtDate.TabIndex = 11;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Execute Date:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Field:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(105, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Update Formular";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNumberDigit
            // 
            this.txtNumberDigit.Location = new System.Drawing.Point(105, 117);
            this.txtNumberDigit.Name = "txtNumberDigit";
            this.txtNumberDigit.Size = new System.Drawing.Size(110, 23);
            this.txtNumberDigit.TabIndex = 7;
            this.txtNumberDigit.Text = "3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Number Digit:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenFile);
            this.groupBox2.Controls.Add(this.workPanel);
            this.groupBox2.Controls.Add(this.lblFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(19, 19);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(88, 23);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // workPanel
            // 
            this.workPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workPanel.Controls.Add(this.metroLabel7);
            this.workPanel.Controls.Add(this.txtFunctionName);
            this.workPanel.Controls.Add(this.metroLabel6);
            this.workPanel.Controls.Add(this.txtStartIndex);
            this.workPanel.Controls.Add(this.btnGoIndexing);
            this.workPanel.Controls.Add(this.cboWorkSheet);
            this.workPanel.Controls.Add(this.metroLabel3);
            this.workPanel.Enabled = false;
            this.workPanel.Location = new System.Drawing.Point(3, 77);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(637, 370);
            this.workPanel.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 122);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Function Name:";
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Location = new System.Drawing.Point(120, 118);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(110, 23);
            this.txtFunctionName.TabIndex = 14;
            this.txtFunctionName.Text = "SMP-";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 80);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Start Index:";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(120, 76);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(110, 23);
            this.txtStartIndex.TabIndex = 12;
            this.txtStartIndex.Text = "0";
            // 
            // btnGoIndexing
            // 
            this.btnGoIndexing.Location = new System.Drawing.Point(16, 172);
            this.btnGoIndexing.Name = "btnGoIndexing";
            this.btnGoIndexing.Size = new System.Drawing.Size(88, 23);
            this.btnGoIndexing.TabIndex = 8;
            this.btnGoIndexing.Text = "Go Indexing";
            this.btnGoIndexing.Click += new System.EventHandler(this.btnGoIndexing_Click);
            // 
            // cboWorkSheet
            // 
            this.cboWorkSheet.FormattingEnabled = true;
            this.cboWorkSheet.Location = new System.Drawing.Point(120, 32);
            this.cboWorkSheet.Name = "cboWorkSheet";
            this.cboWorkSheet.Size = new System.Drawing.Size(458, 21);
            this.cboWorkSheet.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "List WorkSheet:";
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(115, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(512, 39);
            this.lblFile.TabIndex = 5;
            this.lblFile.Text = "File:";
            // 
            // formIcon
            // 
            this.formIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formIcon.Image = global::CMC_Medatsu.Properties.Resources.iconcmc;
            this.formIcon.Location = new System.Drawing.Point(10, 10);
            this.formIcon.Name = "formIcon";
            this.formIcon.Size = new System.Drawing.Size(70, 44);
            this.formIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formIcon.TabIndex = 0;
            this.formIcon.TabStop = false;
            this.formIcon.Click += new System.EventHandler(this.formIcon_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 520);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.formIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "         CMC- Medatsu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox formIcon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private MetroFramework.Controls.MetroTextBox txtNumberDigit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.ComboBox cboWorkSheet;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblFile;
        private MetroFramework.Controls.MetroButton btnOpenFile;
        private MetroFramework.Controls.MetroTextBox txtPIC;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnGoIndexing;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtStartIndex;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtFunctionName;
    }
}

