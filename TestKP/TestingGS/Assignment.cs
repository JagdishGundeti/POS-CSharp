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
    public partial class Assignment : Form
    {
        private DBConnect dbConnect;
        private int m_nID = 0;
        private int m_nEmployeeID = 0;
        public Assignment()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void DisplayData()
        {

            string strQuery = SingletonSonar.Instance.AssignmentSelectQuery(chkWithDate.Checked,
                dtpDate.Value.ToString("yyyy-MM-dd"), m_nID);

            dbConnect.GridDisplay(dataGridView1, strQuery);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_nID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            EmployeeDetails frmEmployeeDetails = new EmployeeDetails();
            //frmCustomerDetails.MdiParent = this;
            DialogResult dr = frmEmployeeDetails.ShowDialog(this);
            if (dr == DialogResult.OK)
            {

                txtCode.Text = frmEmployeeDetails.GetCode();
                m_nEmployeeID = frmEmployeeDetails.GetID();
                frmEmployeeDetails.Dispose();
                DisplayData();

            }
            else
            {
                txtCode.Text = "";
                m_nEmployeeID = 0;
                frmEmployeeDetails.Dispose();
            }

        }
    }
}
