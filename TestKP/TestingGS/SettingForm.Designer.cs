﻿namespace KPSonar
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSilverRate = new System.Windows.Forms.TextBox();
            this.lblSilverRate = new System.Windows.Forms.Label();
            this.txtGoldRate22Karat = new System.Windows.Forms.TextBox();
            this.lblGoldRate22Kart = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGoldRate24Karat
            // 
            this.txtGoldRate24Karat.Location = new System.Drawing.Point(131, 24);
            this.txtGoldRate24Karat.Name = "txtGoldRate24Karat";
            this.txtGoldRate24Karat.Size = new System.Drawing.Size(100, 20);
            this.txtGoldRate24Karat.TabIndex = 12;
            // 
            // lblGoldRate24Kart
            // 
            this.lblGoldRate24Kart.AutoSize = true;
            this.lblGoldRate24Kart.Location = new System.Drawing.Point(14, 24);
            this.lblGoldRate24Kart.Name = "lblGoldRate24Kart";
            this.lblGoldRate24Kart.Size = new System.Drawing.Size(107, 13);
            this.lblGoldRate24Kart.TabIndex = 11;
            this.lblGoldRate24Kart.Text = "Gold 24Karat(per gm)";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(131, 153);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 17;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(26, 347);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Display";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(117, 347);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSilverRate
            // 
            this.txtSilverRate.Location = new System.Drawing.Point(131, 111);
            this.txtSilverRate.Name = "txtSilverRate";
            this.txtSilverRate.Size = new System.Drawing.Size(100, 20);
            this.txtSilverRate.TabIndex = 20;
            // 
            // lblSilverRate
            // 
            this.lblSilverRate.AutoSize = true;
            this.lblSilverRate.Location = new System.Drawing.Point(14, 118);
            this.lblSilverRate.Name = "lblSilverRate";
            this.lblSilverRate.Size = new System.Drawing.Size(95, 13);
            this.lblSilverRate.TabIndex = 19;
            this.lblSilverRate.Text = "Silver Rate(per kg)";
            // 
            // txtGoldRate22Karat
            // 
            this.txtGoldRate22Karat.Location = new System.Drawing.Point(131, 72);
            this.txtGoldRate22Karat.Name = "txtGoldRate22Karat";
            this.txtGoldRate22Karat.Size = new System.Drawing.Size(100, 20);
            this.txtGoldRate22Karat.TabIndex = 22;
            // 
            // lblGoldRate22Kart
            // 
            this.lblGoldRate22Kart.AutoSize = true;
            this.lblGoldRate22Kart.Location = new System.Drawing.Point(14, 72);
            this.lblGoldRate22Kart.Name = "lblGoldRate22Kart";
            this.lblGoldRate22Kart.Size = new System.Drawing.Size(107, 13);
            this.lblGoldRate22Kart.TabIndex = 21;
            this.lblGoldRate22Kart.Text = "Gold 24Karat(per gm)";
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
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGoldRate22Karat);
            this.Controls.Add(this.lblGoldRate22Kart);
            this.Controls.Add(this.txtSilverRate);
            this.Controls.Add(this.lblSilverRate);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
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
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSilverRate;
        private System.Windows.Forms.Label lblSilverRate;
        private System.Windows.Forms.TextBox txtGoldRate22Karat;
        private System.Windows.Forms.Label lblGoldRate22Kart;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}