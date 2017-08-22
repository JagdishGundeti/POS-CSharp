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
    public partial class ProductDetails : Form
    {
        private DBConnect dbConnect;

        private string m_strTableName = "Product";
        private int m_nID = 0;
        private string m_strID = "id";
        private string m_strName = "name";
        private string m_strDetails = "details";
        private string m_strCategory = "category";
        
        public ProductDetails()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{

        //    string strQuery =
        //                        "INSERT INTO "
        //                        + m_strTableName
        //                        + "("
        //                        + m_strName + ","
        //                        + m_strDetails
        //                        + ") VALUES("
        //                        + "'" + txtName.Text + "', "
        //                        + "'" + txtDetails.Text + "'"
        //                        + ")";

        //    bool bReturn = dbConnect.Insert(strQuery);
        //    if(bReturn==true)
        //    {
        //        MessageBox.Show("Record inserted");
        //    }
        //}

        //Clear Data  
        private void ClearData()
        {
            m_nID = 0;
            txtName.Text = "";
            txtDetails.Text = "";
        }

        private void DisplayData()
        {
            // set query to fetch data "Select * from  tabelname"; 
            string query =
                " SELECT * FROM  " + m_strTableName
                + " WHERE "
                + " 1 = 1 "
                + " AND " + m_strName + " like '%" + txtName.Text + "%'"
                + " AND " + m_strDetails + " like '%" + txtDetails.Text + "%'"
                + " AND " + m_strCategory + " like '%" + cmbCategory.Text + "%'"
                
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

            if (txtName.Text != "")
            {
                bReturn = true;
            }
            else
            {
                MessageBox.Show("Name sould not be empty");
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
                                    + m_strName + ","
                                    + m_strDetails + ","
                                    + m_strCategory
                                    + ") VALUES("
                                    + "'" + txtName.Text + "', "
                                    + "'" + txtDetails.Text + "', "
                                    + "'" + cmbCategory.Text + "'"
                                    + ")";

                bReturn = dbConnect.Insert(strQuery);
                if (bReturn == true)
                {
                    MessageBox.Show("Record inserted");
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
                string strQuery =
                                    "UPDATE "
                                    + m_strTableName
                                    + " SET "
                                    + m_strName + "=" + "'" + txtName.Text + "', "
                                    + m_strDetails + "=" + "'" + txtDetails.Text + "', "
                                    + m_strCategory + "=" + "'" + cmbCategory.Text + "'"
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (String.IsNullOrEmpty(strData) == false) 
            {
                m_nID = Convert.ToInt32(strData);
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDetails.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

    }
}
