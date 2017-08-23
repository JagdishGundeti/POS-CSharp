using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPSonar
{
    public partial class OrderDetails : Form
    {
        private DBConnect dbConnect;
        private string m_strTableName = "order_txn";

        private string m_strID = "id";
        private string m_strCustomerID = "customer_id";
        private string m_strProductID = "product_id";
        private string m_strQuantity = "quantity";
        private string m_strAmount = "price";
        private string m_strModifiedOn = "ModifiedOn";
        private string m_strModifiedOnValue = "2017-08-02";
        

        private int m_nID = 0;
        private int m_nCustomerID = 0;
        private int m_nProductID = 0;

        public OrderDetails()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        //Clear Data  
        private void ClearData()
        {
            m_nID = 0;
            //txtFirstName.Text = "";
            //txtMiddleName.Text = "";
            //txtLastName.Text = "";
            //txtAddress.Text = "";
            //txtPhoneNo.Text = "";
        }
        
        private void DisplayData()
        {
            // set query to fetch data "Select * from  tabelname"; 
            string query = 
                " SELECT * FROM  " + m_strTableName 
                + " WHERE "
                + " 1 = 1 "
                //+ " AND " + m_strFirstName + " like '%" + txtFirstName.Text + "%'"
                //+ " AND " + m_strMiddleName + " like '%" + txtMiddleName.Text + "%'"
                //+ " AND " + m_strLastName + " like '%" + txtLastName.Text + "%'"
                //+ " AND " + m_strAddress + " like '%" + txtLastName.Text + "%'"
                //+ " AND " + m_strPhone + " like '%" + txtPhoneNo.Text + "%'"
                ;

            dbConnect.GridDisplay(dataGridView1, query);
        }
        private void btnFirstName_Click(object sender, EventArgs e)
        {
            CustomerDetails frmCustomerDetails = new CustomerDetails();
            //frmCustomerDetails.MdiParent = this;
            DialogResult dr = frmCustomerDetails.ShowDialog(this);
            if (dr == DialogResult.OK)
            {

                txtFirstName.Text = frmCustomerDetails.GetFirstName();
                m_nCustomerID = frmCustomerDetails.GetID();
                frmCustomerDetails.Dispose();
            }
            else
            {

                txtFirstName.Text = "";
                m_nCustomerID = 0;
                frmCustomerDetails.Dispose();
            }

        }

        private void btnProductName_Click(object sender, EventArgs e)
        {
            ProductDetails frmProductDetails = new ProductDetails();
            DialogResult dr = frmProductDetails.ShowDialog(this);
            if (dr == DialogResult.OK)
            {

                txtProductName.Text = frmProductDetails.GetName();
                m_nProductID = frmProductDetails.GetID();
                frmProductDetails.Dispose();
            }
            else
            {

                txtProductName.Text = "";
                m_nProductID = 0;
                frmProductDetails.Dispose();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool bReturn = false;

            if (txtFirstName.Text != "")
            {
                bReturn = true;
            }
            else
            {
                MessageBox.Show("First Name sould not be empty");
            }

            if (bReturn == true)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Your are trying to Insert record", "Insert", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bReturn = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    bReturn = false;
                }
            }
            if (bReturn == true)
            {
                string strQuery =
                                    "INSERT INTO "
                                    + m_strTableName
                                    + "("
                                    + m_strCustomerID + ","
                                    + m_strProductID + ","
                                    + m_strQuantity + ","
                                    + m_strAmount + ","
                                    + m_strModifiedOn
                                    + ") VALUES("
                                    + m_nCustomerID + ", "
                                    +  m_nProductID + ", "
                                    + txtQuantity.Text + ", "
                                    + txtAmount.Text + ", "
                                    + "'" + m_strModifiedOnValue + "'"
                                    + ")";

                bReturn = dbConnect.Insert(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Inserted");
                    ClearData();
                    DisplayData();
                }
            }
        }
    }
}
