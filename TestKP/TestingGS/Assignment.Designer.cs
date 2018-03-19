namespace KPSonar
{
    partial class Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment));
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.chkWithDate = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(66, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Code";
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(596, 8);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 31;
            this.btnUse.Text = "U&se";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(768, 329);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(361, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 50);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "D&elete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(245, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 50);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(13, 446);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(83, 50);
            this.btnSelect.TabIndex = 32;
            this.btnSelect.Text = "&Display";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(129, 446);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 50);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // chkWithDate
            // 
            this.chkWithDate.AutoSize = true;
            this.chkWithDate.Checked = true;
            this.chkWithDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWithDate.Location = new System.Drawing.Point(15, 64);
            this.chkWithDate.Name = "chkWithDate";
            this.chkWithDate.Size = new System.Drawing.Size(74, 17);
            this.chkWithDate.TabIndex = 39;
            this.chkWithDate.Text = "With Date";
            this.chkWithDate.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(97, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 40;
            // 
            // btnCode
            // 
            this.btnCode.Image = global::KPSonar.Properties.Resources.img_ok_small;
            this.btnCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCode.Location = new System.Drawing.Point(264, 5);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(67, 34);
            this.btnCode.TabIndex = 41;
            this.btnCode.Text = "Select";
            this.btnCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 508);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.chkWithDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Name = "Assignment";
            this.Text = "Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckBox chkWithDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCode;
    }
}