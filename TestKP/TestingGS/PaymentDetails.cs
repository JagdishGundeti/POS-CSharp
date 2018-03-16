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
    public partial class PaymentDetails : Form
    {
        private DBConnect dbConnect;
        //private string m_strInvoiceID = "id";
        //private string m_strTableInvoice = "invoices";
        //private string m_strOrderTxn = "order_txn";
        //private string m_strCustomer = "customer";

        //private string m_strCustomerID = "customer_id";
        //private string m_strModifiedOnValue = "";
        //private string m_strModifiedOn = "invoice_date_modified";
        //private string m_strPayment1 = "paid_price_1";
        //private string m_strPayment2 = "paid_price_2";

        private int m_nCustomerID = 0;
        private int m_nID = 0;

        public PaymentDetails()
        {
            InitializeComponent();
            //m_strModifiedOnValue = DateTime.Now.ToString("yyyy-MM-dd");
            dbConnect = new DBConnect();
        }
        private void DisplayInvoiceData()
        {

            //string strCol = "invoice_id";

            //string query =
            //    "SELECT "
            //    + m_strTableInvoice + "." + m_strInvoiceID + ","
            //    + "invoice_date_created" + ","
            //    + "invoice_date_modified" + ","
            //    + "paid_price_1" + ","
            //    + "paid_price_2" + ","
            //    + "payment_method" + ","
            //    + "(SELECT sum(total_price) "
            //    + "FROM " + m_strOrderTxn
            //    + " WHERE "
            //    + m_strOrderTxn + "." + strCol + " = " + m_strTableInvoice + "." + "id" + ") total_amount" + ","
            //    + "(SELECT sum(total_price) "
            //    + "FROM " + m_strOrderTxn
            //    + " WHERE "
            //    + m_strOrderTxn + "." + strCol + " = " + m_strTableInvoice + "." + "id" + ") "+"- (paid_price_1 + paid_price_2) Balance"
            //    + " FROM " + m_strTableInvoice
            //   + " JOIN " + m_strCustomer
            //    + "   ON (" + m_strCustomer + ".id = " + m_strTableInvoice + "." + m_strCustomerID + ") "
            //    + " WHERE "
            //    + " 1 = 1 AND "
            //    + m_strCustomer + "." + "id  = " + m_nCustomerID
            //    ;
            //if (chkWithDate.Checked == true)
            //{
            //    query = query
            //        + " AND " + m_strTableInvoice + "." + m_strModifiedOn + " = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'";
            //}
            
            string query = SingletonSonar.Instance.InvoiceSelectQuery(chkWithDate.Checked,
                dtpDate.Value.ToString("yyyy-MM-dd"),m_nCustomerID);
            dbConnect.GridDisplay(dataGridView1, query);
        }
        private void DisplayData()
        {
            DisplayInvoiceData();
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
                m_nID = 0;
            }
            else
            {
                txtFirstName.Text = "";
                m_nCustomerID = 0;
                frmCustomerDetails.Dispose();
            }
        }

        private void btnFirstName_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (String.IsNullOrEmpty(strData) == false)
            {
                m_nID = Convert.ToInt32(strData);
                txtPayment1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPayment2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                m_nID = 0;
            }
        }

        private void btnViewInvoices_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            bool bReturn = false;
            if (m_nID != 0)
            {
                bReturn = true;
            }
            else
            {
                MessageBox.Show("Record is not selected to Update");
            }
            if (bReturn == true)
            {

                //string strQuery =
                //                "UPDATE "
                //                + m_strTableInvoice
                //                + " SET "
                //                + m_strPayment1 + "=" + "'" + txtPayment1.Text + "', "
                //                + m_strPayment2 + "=" + "'" + txtPayment2.Text + "'"
                //                + " WHERE "
                //                + m_strInvoiceID + "=" + m_nID
                //                ;
                string strQuery = SingletonSonar.Instance.InvoiceUpdateQuery(
                    txtPayment1.Text,txtPayment2.Text,
                    m_nID);

                bReturn = dbConnect.Update(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Updated");
                    //ClearData();
                    DisplayData();
                }
            }
        }
    }
}
