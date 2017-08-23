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
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(35, 11);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 0;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(116, 11);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 1;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(73, 40);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 2;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(197, 11);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(154, 40);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(75, 23);
            this.bCount.TabIndex = 4;
            this.bCount.Text = "Count";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // bBackup
            // 
            this.bBackup.Location = new System.Drawing.Point(73, 69);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(75, 23);
            this.bBackup.TabIndex = 5;
            this.bBackup.Text = "Backup";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // bRestore
            // 
            this.bRestore.Location = new System.Drawing.Point(154, 69);
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
            this.dgDisplay.Location = new System.Drawing.Point(12, 216);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.Size = new System.Drawing.Size(388, 112);
            this.dgDisplay.TabIndex = 7;
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
            this.txtPath.Location = new System.Drawing.Point(73, 121);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(207, 20);
            this.txtPath.TabIndex = 8;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(32, 124);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "Path";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(325, 118);
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
            this.lblFile.Location = new System.Drawing.Point(19, 165);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(48, 13);
            this.lblFile.TabIndex = 11;
            this.lblFile.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(73, 158);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(207, 20);
            this.txtFilePath.TabIndex = 12;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(325, 154);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath.TabIndex = 13;
            this.btnFilePath.Text = "File Path";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // TestMysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 423);
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
    }
}

