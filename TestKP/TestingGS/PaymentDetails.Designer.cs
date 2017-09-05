﻿namespace KPSonar
{
    partial class PaymentDetails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnFirstName = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductName = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCalAmount = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chkWithDate = new System.Windows.Forms.CheckBox();
            this.lblCGST = new System.Windows.Forms.Label();
            this.lblSGST = new System.Windows.Forms.Label();
            this.lblCGSValue = new System.Windows.Forms.Label();
            this.lblSGSTValue = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 385);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(677, 379);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.lblSGSTValue);
            this.panel5.Controls.Add(this.lblCGSValue);
            this.panel5.Controls.Add(this.lblSGST);
            this.panel5.Controls.Add(this.lblCGST);
            this.panel5.Controls.Add(this.chkWithDate);
            this.panel5.Controls.Add(this.dtpDate);
            this.panel5.Controls.Add(this.txtSGST);
            this.panel5.Controls.Add(this.txtCGST);
            this.panel5.Controls.Add(this.txtCalAmount);
            this.panel5.Controls.Add(this.txtAmount);
            this.panel5.Controls.Add(this.lblAmount);
            this.panel5.Controls.Add(this.txtQuantity);
            this.panel5.Controls.Add(this.lblQuantity);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnProductName);
            this.panel5.Controls.Add(this.txtProductName);
            this.panel5.Controls.Add(this.lblProductName);
            this.panel5.Controls.Add(this.btnViewOrders);
            this.panel5.Controls.Add(this.btnFirstName);
            this.panel5.Controls.Add(this.txtFirstName);
            this.panel5.Controls.Add(this.lblFirstName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(677, 379);
            this.panel5.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(11, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 38;
            this.lblFirstName.Text = "Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(127, 20);
            this.txtFirstName.TabIndex = 39;
            // 
            // btnFirstName
            // 
            this.btnFirstName.Location = new System.Drawing.Point(226, 20);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(75, 23);
            this.btnFirstName.TabIndex = 40;
            this.btnFirstName.Text = "Select";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.btnFirstName_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(307, 20);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrders.TabIndex = 41;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 69);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 42;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(93, 67);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(127, 20);
            this.txtProductName.TabIndex = 43;
            // 
            // btnProductName
            // 
            this.btnProductName.Location = new System.Drawing.Point(226, 67);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(75, 23);
            this.btnProductName.TabIndex = 44;
            this.btnProductName.Text = "Select";
            this.btnProductName.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "AddItem";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 109);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 13);
            this.lblQuantity.TabIndex = 46;
            this.lblQuantity.Text = "Quantity(gms)";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(93, 107);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 20);
            this.txtQuantity.TabIndex = 47;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(13, 139);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 48;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(98, 217);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 49;
            // 
            // txtCalAmount
            // 
            this.txtCalAmount.Location = new System.Drawing.Point(98, 139);
            this.txtCalAmount.Name = "txtCalAmount";
            this.txtCalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtCalAmount.TabIndex = 52;
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(98, 165);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(100, 20);
            this.txtCGST.TabIndex = 50;
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(98, 191);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(100, 20);
            this.txtSGST.TabIndex = 51;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(167, 334);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 53;
            // 
            // chkWithDate
            // 
            this.chkWithDate.AutoSize = true;
            this.chkWithDate.Checked = true;
            this.chkWithDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWithDate.Location = new System.Drawing.Point(16, 342);
            this.chkWithDate.Name = "chkWithDate";
            this.chkWithDate.Size = new System.Drawing.Size(74, 17);
            this.chkWithDate.TabIndex = 54;
            this.chkWithDate.Text = "With Date";
            this.chkWithDate.UseVisualStyleBackColor = true;
            // 
            // lblCGST
            // 
            this.lblCGST.AutoSize = true;
            this.lblCGST.Location = new System.Drawing.Point(15, 170);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(68, 13);
            this.lblCGST.TabIndex = 55;
            this.lblCGST.Text = "CGST (1.5%)";
            // 
            // lblSGST
            // 
            this.lblSGST.AutoSize = true;
            this.lblSGST.Location = new System.Drawing.Point(15, 193);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(68, 13);
            this.lblSGST.TabIndex = 56;
            this.lblSGST.Text = "SGST (1.5%)";
            // 
            // lblCGSValue
            // 
            this.lblCGSValue.AutoSize = true;
            this.lblCGSValue.Location = new System.Drawing.Point(92, 170);
            this.lblCGSValue.Name = "lblCGSValue";
            this.lblCGSValue.Size = new System.Drawing.Size(0, 13);
            this.lblCGSValue.TabIndex = 57;
            // 
            // lblSGSTValue
            // 
            this.lblSGSTValue.AutoSize = true;
            this.lblSGSTValue.Location = new System.Drawing.Point(92, 193);
            this.lblSGSTValue.Name = "lblSGSTValue";
            this.lblSGSTValue.Size = new System.Drawing.Size(0, 13);
            this.lblSGSTValue.TabIndex = 58;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "D&elete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 452);
            this.panel3.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 385);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(677, 67);
            this.panel6.TabIndex = 24;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(677, 67);
            this.dataGridView2.TabIndex = 61;
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 452);
            this.Controls.Add(this.panel3);
            this.Name = "PaymentDetails";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSGSTValue;
        private System.Windows.Forms.Label lblCGSValue;
        private System.Windows.Forms.Label lblSGST;
        private System.Windows.Forms.Label lblCGST;
        private System.Windows.Forms.CheckBox chkWithDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.TextBox txtCalAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}