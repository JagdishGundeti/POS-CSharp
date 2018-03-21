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

        //Clear Data  
        private void ClearData()
        {
            m_nID = 0;
            //m_nEmployeeID = 0;
            dtpStartDate.Text = "";
            dtpEndDate.Text = "";
        }
        private void DisplayData()
        {

            string strQuery = SingletonSonar.Instance.AssignmentSelectQuery(chkWithDate.Checked,
                dtpDate.Value.ToString("yyyy-MM-dd"), m_nEmployeeID);

            dbConnect.GridDisplay(dataGridView1, strQuery);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DisplayData();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_nID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtpStartDate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpEndDate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool bReturn = false;

            if (m_nEmployeeID != 0)
            {
                bReturn = true;
            }
            else
            {
                MessageBox.Show("Record is not selected to Update");
            }

            if (bReturn == true)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Your are trying to Update record", "Update", MessageBoxButtons.YesNo);

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
                string strQuery = SingletonSonar.Instance.EmployeeUpdatetQuery(
                    dtpStartDate.Value.Date.ToString("yyyy-MM-dd"), dtpEndDate.Value.Date.ToString("yyyy-MM-dd"), m_nID);
                bReturn = dbConnect.Update(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Updated");
                    ClearData();
                    DisplayData();
                }
            }
        }
    }
}
