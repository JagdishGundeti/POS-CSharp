namespace KPSonar
{
    partial class TestMysql
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
            this.bInsert = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCount = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.bRestore = new System.Windows.Forms.Button();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.ciD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSQLDump = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSQLExe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(22, 310);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 0;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Visible = false;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(103, 310);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 1;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Visible = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(22, 394);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 2;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Visible = false;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(66, 350);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(103, 394);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(75, 23);
            this.bCount.TabIndex = 4;
            this.bCount.Text = "Count";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Visible = false;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // bBackup
            // 
            this.bBackup.Location = new System.Drawing.Point(82, 161);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(75, 23);
            this.bBackup.TabIndex = 5;
            this.bBackup.Text = "Backup";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // bRestore
            // 
            this.bRestore.Location = new System.Drawing.Point(163, 161);
            this.bRestore.Name = "bRestore";
            this.bRestore.Size = new System.Drawing.Size(75, 23);
            this.bRestore.TabIndex = 6;
            this.bRestore.Text = "Restore";
            this.bRestore.UseVisualStyleBackColor = true;
            this.bRestore.Click += new System.EventHandler(this.bRestore_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciD,
            this.cName,
            this.cAge});
            this.dgDisplay.Location = new System.Drawing.Point(213, 310);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.Size = new System.Drawing.Size(329, 112);
            this.dgDisplay.TabIndex = 7;
            this.dgDisplay.Visible = false;
            // 
            // ciD
            // 
            this.ciD.HeaderText = "id";
            this.ciD.Name = "ciD";
            this.ciD.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cAge
            // 
            this.cAge.HeaderText = "Age";
            this.cAge.Name = "cAge";
            this.cAge.ReadOnly = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(73, 201);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(207, 20);
            this.txtPath.TabIndex = 8;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(32, 204);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "Path";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(325, 198);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 10;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(19, 245);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(48, 13);
            this.lblFile.TabIndex = 11;
            this.lblFile.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(73, 238);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(207, 20);
            this.txtFilePath.TabIndex = 12;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(325, 234);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath.TabIndex = 13;
            this.btnFilePath.Text = "File Path";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "File Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSQLDump
            // 
            this.txtSQLDump.Location = new System.Drawing.Point(66, 16);
            this.txtSQLDump.Name = "txtSQLDump";
            this.txtSQLDump.Size = new System.Drawing.Size(207, 20);
            this.txtSQLDump.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "SQL Dump";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "File Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSQLExe
            // 
            this.txtSQLExe.Location = new System.Drawing.Point(65, 54);
            this.txtSQLExe.Name = "txtSQLExe";
            this.txtSQLExe.Size = new System.Drawing.Size(207, 20);
            this.txtSQLExe.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "SQL Exe";
            // 
            // TestMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSQLExe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSQLDump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.bRestore);
            this.Controls.Add(this.bBackup);
            this.Controls.Add(this.bCount);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TestMysql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Mysql";
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bRestore;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAge;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSQLDump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSQLExe;
        private System.Windows.Forms.Label label2;
    }
}

