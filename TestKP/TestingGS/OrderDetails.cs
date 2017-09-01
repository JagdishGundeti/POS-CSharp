using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        private string m_strSGST = "SGST";
        private string m_strCGST = "CGST";
        private string m_strTotalPrice = "total_price";
        private string m_strModifiedOn = "ModifiedOn";
        private string m_strModifiedOnValue = "";

        private float m_fCGST = 0.015f;
        private float m_fSGST = 0.015f;        
        

        private int m_nID = 0;
        private int m_nCustomerID = 0;
        private int m_nProductID = 0;

        public OrderDetails()
        {
            InitializeComponent();
            m_strModifiedOnValue = DateTime.Now.ToString("yyyy-MM-dd");
            dbConnect = new DBConnect();
        }

        //Clear Data  
        private void ClearData()
        {
            //m_nID = 0;
        }
        
        private void DisplayData()
        {            
            string strTableCategory = "category";
            string strTableProduct = "product";
            string strType = "type";
            
            string strQuery1 = 
                " SELECT "
                + m_strTableName + "." + m_strID + ","
                + " customer.firstname,"
                + " customer.phone_no,"
                + strTableProduct + "." + "name" + ","
                + strTableProduct + "." + "details" + ","
                //+ " product.category,"
                + strTableCategory + "." + strType + ","
                + m_strTableName + "." + m_strQuantity + ","
                + m_strTableName + "." + m_strAmount + ","
                + m_strTableName + "." + m_strCGST + ","
                + m_strTableName + "." + m_strSGST + ","
                + m_strTableName + "." + m_strTotalPrice + ","
                + m_strTableName + "." + m_strModifiedOn
                + " FROM  " + m_strTableName 
                + " JOIN customer "
                + "   ON (customer.id = "+m_strTableName + "." + m_strCustomerID + ") "
                + " JOIN " + strTableProduct
                + "   ON (product.id = order_txn.product_id) "
                + " JOIN " + strTableCategory
                + "   ON (" + strTableProduct + ".category_id = " + strTableCategory + ".id) "
                + " WHERE "
                + " 1 = 1 "
                + " AND " + m_strCustomerID + "=" + m_nCustomerID
                ;

            string query = strQuery1;
            if(chkWithDate.Checked==true)
            {
                query = query
                    + " AND " + m_strTableName + "." + m_strModifiedOn + " = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'";
            }
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
                DisplayData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool bReturn = false;

            if (m_nID != 0)
            {
                bReturn = true;
            }
            else
            {
                MessageBox.Show("Record is not selected to Delete");
            }

            if (bReturn == true)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Your are trying to Delete record", "Delete", MessageBoxButtons.YesNo);

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
                                "DELETE FROM "
                                + m_strTableName
                                + " WHERE "
                                + m_strID + "=" + m_nID
                                ;

                bReturn = dbConnect.Delete(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Deleted");
                    ClearData();
                    DisplayData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool bReturn = true;

            if (txtFirstName.Text == "")
            {
                bReturn = false;
                MessageBox.Show("First Name sould not be empty");
            }
            if ((m_nCustomerID == 0) || (m_nProductID == 0))
            {
                bReturn = false;
                MessageBox.Show("Customer or Product is not selected");
            }

            if (bReturn == true)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Your are trying to Insert record", "Insert", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
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
                                    + m_strSGST + ","
                                    + m_strCGST + ","
                                    + m_strTotalPrice + ","
                                    + m_strModifiedOn
                                    + ") VALUES("
                                    + m_nCustomerID + ", "
                                    +  m_nProductID + ", "
                                    + txtQuantity.Text + ", "
                                    + txtCalAmount.Text + ", "
                                    + txtCGST.Text + ", "
                                    + txtSGST.Text + ", "
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

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void chkWithDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithDate.Checked==true)
            {
                dtpDate.Enabled = true;
            }
            else
            {
                dtpDate.Enabled = false;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            int nQuantity = Convert.ToInt32(txtQuantity.Text);
            //txtCalAmount->Text = nQuantity *;
            
            string strDataValue = "";
            strDataValue = GetDataValue(m_nProductID);
            int nValuePerGm = Convert.ToInt32(strDataValue);
            int nCalAmount = nQuantity * nValuePerGm;
            float fCGSTAmount = nCalAmount * m_fCGST;
            float fSGSTAmount = nCalAmount * m_fSGST;
            txtCalAmount.Text = nCalAmount.ToString();
            txtCGST.Text = fCGSTAmount.ToString();
            txtSGST.Text = fSGSTAmount.ToString();
            float fTotalAmount = nCalAmount + fCGSTAmount + fSGSTAmount;
            txtAmount.Text = fTotalAmount.ToString();
            //frm.NGoldRate24Karat = Convert.ToInt32(strDataValue);
        }

        private string GetDataValue(object nProductId)
        {

            string strTableCategory = "category";
            string strTableProduct = "product";
            string strValue = "value";
            string strProductID = "id";
            string m_strDailyRatesEx = "daily_rates_ex";

            string strQuery =
                " SELECT "
                + strValue
                + " FROM  " 
                + m_strDailyRatesEx
                + " JOIN " + strTableCategory
                + "   ON (" + m_strDailyRatesEx + ".category_id = " + strTableCategory + ".id) "
                + " JOIN " + strTableProduct
                + "   ON (" + strTableProduct + ".category_id = " + strTableCategory + ".id) "
                + " WHERE "
                + " 1 = 1 "
                + " AND " + m_strDailyRatesEx + "." + m_strModifiedOn + " = '" + m_strModifiedOnValue + "'"
                + " AND " + strTableProduct + "." + strProductID + "=" + nProductId
                ;

            string strDataValue;
            strDataValue = dbConnect.GetDataValue(strQuery, strValue);
            return strDataValue;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_nID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

    }
}
