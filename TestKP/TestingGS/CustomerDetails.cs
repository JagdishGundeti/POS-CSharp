using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestKP
{
    public partial class CustomerDetails : Form
    {
        private DBConnect dbConnect;

        private string m_strTableName = "Customer";
        private int m_nID = 0;
        private string m_strID = "id";
        private string m_strFirstName = "firstname";
        private string m_strMiddleName = "middlename";
        private string m_strLastName = "lastname";
        private string m_strAddress = "address";
        private string m_strPhone = "phone_no";
        public CustomerDetails()
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
            // set query to fetch data "Select * from  tabelname"; 
            string query = 
                " SELECT * FROM  " + m_strTableName 
                + " WHERE "
                + " 1 = 1 "
                + " AND " + m_strFirstName + " like '%" + txtFirstName.Text + "%'"
                + " AND " + m_strMiddleName + " like '%" + txtMiddleName.Text + "%'"
                + " AND " + m_strLastName + " like '%" + txtLastName.Text + "%'"
                + " AND " + m_strAddress + " like '%" + txtLastName.Text + "%'"
                + " AND " + m_strPhone + " like '%" + txtPhoneNo.Text + "%'"
                ;

            dbConnect.GridDisplay(dataGridView1, query);
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
                string strQuery =
                                    "INSERT INTO "
                                    + m_strTableName
                                    + "("
                                    + m_strFirstName + ","
                                    + m_strMiddleName + ","
                                    + m_strLastName + ","
                                    + m_strAddress + ","
                                    + m_strPhone
                                    + ") VALUES("
                                    + "'" + txtFirstName.Text + "', "
                                    + "'" + txtMiddleName.Text + "', "
                                    + "'" + txtLastName.Text + "', "
                                    + "'" + txtAddress.Text + "', "
                                    + "'" + txtPhoneNo.Text + "'"
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
                string strQuery =
                                    "UPDATE "
                                    + m_strTableName
                                    + " SET "
                                    + m_strFirstName + "=" + "'" + txtFirstName.Text + "', "
                                    + m_strMiddleName + "=" + "'" + txtMiddleName.Text + "', "
                                    + m_strLastName + "=" + "'" + txtLastName.Text + "', "
                                    + m_strAddress + "=" + "'" + txtAddress.Text + "', "
                                    + m_strPhone + "=" + "'" + txtPhoneNo.Text + "'"
                                    + " WHERE "
                                    + m_strID + "=" + m_nID
                                    ;

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
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_nID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

    }
}
