namespace KPSonar
{
    partial class OrderDetails
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 531);
            this.panel3.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 146);
            this.panel1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(632, 146);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblSGSTValue);
            this.panel2.Controls.Add(this.lblCGSValue);
            this.panel2.Controls.Add(this.lblSGST);
            this.panel2.Controls.Add(this.lblCGST);
            this.panel2.Controls.Add(this.chkWithDate);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.txtSGST);
            this.panel2.Controls.Add(this.txtCGST);
            this.panel2.Controls.Add(this.txtCalAmount);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnProductName);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.btnViewOrders);
            this.panel2.Controls.Add(this.btnFirstName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 385);
            this.panel2.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(385, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 37;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(127, 20);
            this.txtFirstName.TabIndex = 22;
            // 
            // btnFirstName
            // 
            this.btnFirstName.Location = new System.Drawing.Point(222, 23);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(75, 23);
            this.btnFirstName.TabIndex = 23;
            this.btnFirstName.Text = "Select";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.btnFirstName_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(303, 23);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(75, 23);
            this.btnViewOrders.TabIndex = 23;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(8, 72);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 24;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(89, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(127, 20);
            this.txtProductName.TabIndex = 25;
            // 
            // btnProductName
            // 
            this.btnProductName.Location = new System.Drawing.Point(222, 70);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(75, 23);
            this.btnProductName.TabIndex = 26;
            this.btnProductName.Text = "Select";
            this.btnProductName.UseVisualStyleBackColor = true;
            this.btnProductName.Click += new System.EventHandler(this.btnProductName_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "AddItem";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(8, 112);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 13);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity(gms)";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(89, 110);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 20);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(94, 220);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 31;
            // 
            // txtCalAmount
            // 
            this.txtCalAmount.Location = new System.Drawing.Point(94, 142);
            this.txtCalAmount.Name = "txtCalAmount";
            this.txtCalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtCalAmount.TabIndex = 32;
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(94, 168);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(100, 20);
            this.txtCGST.TabIndex = 32;
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(94, 194);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(100, 20);
            this.txtSGST.TabIndex = 32;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(163, 337);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 33;
            // 
            // chkWithDate
            // 
            this.chkWithDate.AutoSize = true;
            this.chkWithDate.Checked = true;
            this.chkWithDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWithDate.Location = new System.Drawing.Point(12, 345);
            this.chkWithDate.Name = "chkWithDate";
            this.chkWithDate.Size = new System.Drawing.Size(74, 17);
            this.chkWithDate.TabIndex = 34;
            this.chkWithDate.Text = "With Date";
            this.chkWithDate.UseVisualStyleBackColor = true;
            this.chkWithDate.CheckedChanged += new System.EventHandler(this.chkWithDate_CheckedChanged);
            // 
            // lblCGST
            // 
            this.lblCGST.AutoSize = true;
            this.lblCGST.Location = new System.Drawing.Point(11, 173);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(68, 13);
            this.lblCGST.TabIndex = 35;
            this.lblCGST.Text = "CGST (1.5%)";
            // 
            // lblSGST
            // 
            this.lblSGST.AutoSize = true;
            this.lblSGST.Location = new System.Drawing.Point(11, 196);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(68, 13);
            this.lblSGST.TabIndex = 35;
            this.lblSGST.Text = "SGST (1.5%)";
            // 
            // lblCGSValue
            // 
            this.lblCGSValue.AutoSize = true;
            this.lblCGSValue.Location = new System.Drawing.Point(88, 173);
            this.lblCGSValue.Name = "lblCGSValue";
            this.lblCGSValue.Size = new System.Drawing.Size(0, 13);
            this.lblCGSValue.TabIndex = 35;
            // 
            // lblSGSTValue
            // 
            this.lblSGSTValue.AutoSize = true;
            this.lblSGSTValue.Location = new System.Drawing.Point(88, 196);
            this.lblSGSTValue.Name = "lblSGSTValue";
            this.lblSGSTValue.Size = new System.Drawing.Size(0, 13);
            this.lblSGSTValue.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(104, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "D&elete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 531);
            this.Controls.Add(this.panel3);
            this.Name = "OrderDetails";
            this.Text = "OrderList";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}