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
        private string m_strInvoiceID = "id";
        private string m_strTableInvoice = "invoices";
        private string m_strTableName = "order_txn";

        private string m_strCustomerID = "customer_id";
        private string m_strModifiedOnValue = "";
        private int m_nCustomerID = 0;
        private int m_nID = 0;

        public PaymentDetails()
        {
            InitializeComponent();
            m_strModifiedOnValue = DateTime.Now.ToString("yyyy-MM-dd");
            dbConnect = new DBConnect();
        }
        private void DisplayInvoiceData()
        {

            string strCol = "invoice_id";

            string query =
                "SELECT "
                + m_strTableInvoice + "." + m_strInvoiceID + ","
                + "invoice_date_created" + ","
                + "invoice_date_modified" + ","
                + "paid_price_1" + ","
                + "paid_price_2" + ","
                + "payment_method" + ","
                + "(SELECT sum(total_price) "
                + "FROM order_txn "
                + "WHERE "
                + m_strTableName + "." + strCol + " = " + m_strTableInvoice + "." + "id" + ") total_amount"
                + " FROM " + m_strTableInvoice
                + " WHERE "
                + " 1 = 1 AND "
                + m_strTableInvoice + "." + m_strInvoiceID + " = " + m_nID
                ;

            dbConnect.GridDisplay(dataGridView2, query);
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
    }
}
