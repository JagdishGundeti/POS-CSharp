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
    public partial class EmployeeDetails : Form
    {
        private DBConnect dbConnect;
        private int m_nID = 0;

        public EmployeeDetails()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        //Clear Data  
        private void ClearData()
        {
            m_nID = 0;
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
        }
        
        private void DisplayData()
        {

            string strQuery = SingletonSonar.Instance.EmployeeSelectQuery(txtCode.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                txtAddress.Text, txtPhoneNo.Text);

            dbConnect.GridDisplay(dataGridView1, strQuery);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            if(bReturn == true)
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
            if(bReturn == true)
            {

                string strQuery = SingletonSonar.Instance.EmployeeInsertQuery(txtCode.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                    txtAddress.Text, txtPhoneNo.Text);

                bReturn = dbConnect.Insert(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Inserted");
                    ClearData();
                    DisplayData();
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
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

            if(bReturn == true)
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
            if(bReturn == true)
            {
                string strQuery = SingletonSonar.Instance.EmployeeUpdateQuery(txtCode.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                    txtAddress.Text, txtPhoneNo.Text, m_nID);

                bReturn = dbConnect.Update(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Updated");
                    ClearData();
                    DisplayData();
                }
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

            if(bReturn == true)
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
            if(bReturn == true)
            {

                string strQuery = SingletonSonar.Instance.EmployeeDeleteQuery(m_nID);
                bReturn = dbConnect.Delete(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record Deleted");
                    ClearData();
                    DisplayData();
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_nID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string GetFirstName()
        {
            return txtFirstName.Text;
        }

        public string GetCode()
        {
            return txtCode.Text;
        }

        public int GetID()
        {
            return m_nID;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
