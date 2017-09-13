namespace KPSonar
{
    partial class SettingForm
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
            this.txtGoldRate24Karat = new System.Windows.Forms.TextBox();
            this.lblGoldRate24Kart = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsertOrModify = new System.Windows.Forms.Button();
            this.txtSilverRate = new System.Windows.Forms.TextBox();
            this.lblSilverRate = new System.Windows.Forms.Label();
            this.txtGoldRate22Karat = new System.Windows.Forms.TextBox();
            this.lblGoldRate22Kart = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.chkCurrentDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGoldRate24Karat
            // 
            this.txtGoldRate24Karat.Location = new System.Drawing.Point(131, 24);
            this.txtGoldRate24Karat.Name = "txtGoldRate24Karat";
            this.txtGoldRate24Karat.Size = new System.Drawing.Size(100, 20);
            this.txtGoldRate24Karat.TabIndex = 1;
            // 
            // lblGoldRate24Kart
            // 
            this.lblGoldRate24Kart.AutoSize = true;
            this.lblGoldRate24Kart.Location = new System.Drawing.Point(14, 24);
            this.lblGoldRate24Kart.Name = "lblGoldRate24Kart";
            this.lblGoldRate24Kart.Size = new System.Drawing.Size(86, 13);
            this.lblGoldRate24Kart.TabIndex = 0;
            this.lblGoldRate24Kart.Text = "Gold Bar(per gm)";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(46, 205);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(574, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(26, 347);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Display";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsertOrModify
            // 
            this.btnInsertOrModify.Location = new System.Drawing.Point(117, 347);
            this.btnInsertOrModify.Name = "btnInsertOrModify";
            this.btnInsertOrModify.Size = new System.Drawing.Size(104, 23);
            this.btnInsertOrModify.TabIndex = 8;
            this.btnInsertOrModify.Text = "Insert/Modify";
            this.btnInsertOrModify.UseVisualStyleBackColor = true;
            this.btnInsertOrModify.Click += new System.EventHandler(this.btnInsertOrModify_Click);
            // 
            // txtSilverRate
            // 
            this.txtSilverRate.Location = new System.Drawing.Point(131, 111);
            this.txtSilverRate.Name = "txtSilverRate";
            this.txtSilverRate.Size = new System.Drawing.Size(100, 20);
            this.txtSilverRate.TabIndex = 5;
            // 
            // lblSilverRate
            // 
            this.lblSilverRate.AutoSize = true;
            this.lblSilverRate.Location = new System.Drawing.Point(14, 118);
            this.lblSilverRate.Name = "lblSilverRate";
            this.lblSilverRate.Size = new System.Drawing.Size(97, 13);
            this.lblSilverRate.TabIndex = 4;
            this.lblSilverRate.Text = "Silver Rate(per gm)";
            // 
            // txtGoldRate22Karat
            // 
            this.txtGoldRate22Karat.Location = new System.Drawing.Point(131, 72);
            this.txtGoldRate22Karat.Name = "txtGoldRate22Karat";
            this.txtGoldRate22Karat.Size = new System.Drawing.Size(100, 20);
            this.txtGoldRate22Karat.TabIndex = 3;
            // 
            // lblGoldRate22Kart
            // 
            this.lblGoldRate22Kart.AutoSize = true;
            this.lblGoldRate22Kart.Location = new System.Drawing.Point(14, 72);
            this.lblGoldRate22Kart.Name = "lblGoldRate22Kart";
            this.lblGoldRate22Kart.Size = new System.Drawing.Size(116, 13);
            this.lblGoldRate22Kart.TabIndex = 2;
            this.lblGoldRate22Kart.Text = "Gold Ornament(per gm)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(464, 301);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(303, 340);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(359, 337);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(110, 20);
            this.txtValue.TabIndex = 12;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(481, 342);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // chkCurrentDate
            // 
            this.chkCurrentDate.AutoSize = true;
            this.chkCurrentDate.Checked = true;
            this.chkCurrentDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCurrentDate.Location = new System.Drawing.Point(17, 159);
            this.chkCurrentDate.Name = "chkCurrentDate";
            this.chkCurrentDate.Size = new System.Drawing.Size(86, 17);
            this.chkCurrentDate.TabIndex = 14;
            this.chkCurrentDate.Text = "Current Date";
            this.chkCurrentDate.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.chkCurrentDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGoldRate22Karat);
            this.Controls.Add(this.lblGoldRate22Kart);
            this.Controls.Add(this.txtSilverRate);
            this.Controls.Add(this.lblSilverRate);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsertOrModify);
            this.Controls.Add(this.txtGoldRate24Karat);
            this.Controls.Add(this.lblGoldRate24Kart);
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoldRate24Karat;
        private System.Windows.Forms.Label lblGoldRate24Kart;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsertOrModify;
        private System.Windows.Forms.TextBox txtSilverRate;
        private System.Windows.Forms.Label lblSilverRate;
        private System.Windows.Forms.TextBox txtGoldRate22Karat;
        private System.Windows.Forms.Label lblGoldRate22Kart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.CheckBox chkCurrentDate;
    }
}