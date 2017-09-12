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
    public partial class ProductDetails : Form
    {
        private DBConnect dbConnect;

        private string m_strTableName = "product";
        private int m_nID = 0;
        private int m_nCategoryID = 0;
        
        private string m_strID = "id";
        private string m_strName = "name";
        private string m_strDetails = "details";
        private string m_strCategory = "category";
        private string m_strCategoryID = "category_id";
        private string m_strType = "type";


        public ProductDetails()
        {
            InitializeComponent();
            cmbCategory.Items.Add("");
            cmbCategory.Items.Add("Gold-24-Karat");
            cmbCategory.Items.Add("Gold-22-Karat");
            cmbCategory.Items.Add("Silver");
            dbConnect = new DBConnect();
        }


        //Clear Data  
        private void ClearData()
        {
            m_nID = 0;
            txtName.Text = "";
            txtDetails.Text = "";
        }

        private void DisplayData()
        {
            //string strTableCategory = "category";
            //string strQuery =
            //        " SELECT "
            //        + m_strTableName + "." + m_strID + ","
            //        + m_strTableName + "." + m_strName + ","
            //        + m_strTableName + "." + m_strDetails + ","
            //        + strTableCategory + "." + m_strType
            //        + " FROM  " + m_strTableName
            //        + " JOIN " + strTableCategory
            //        + "   ON (" + m_strTableName + "." + m_strCategoryID
            //            + " = " + strTableCategory + "." + m_strID + ") "
            //        + " WHERE "
            //        + " 1 = 1 "
            //        + " AND " + m_strName + " like '%" + txtName.Text + "%'"
            //        + " AND " + m_strDetails + " like '%" + txtDetails.Text + "%'"
            //        //+ " AND " + m_strCategory + " like '%" + cmbCategory.Text + "%'"
            //        + " AND " + strTableCategory + "." + m_strType + " like '%" + cmbCategory.Text + "%'"
            //        ;
            string strQuery = SingletonSonar.Instance.ProductSelectQuery(
                txtName.Text, txtDetails.Text, cmbCategory.Text);

            dbConnect.GridDisplay(dataGridView1, strQuery);
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
                string strTableCategory = "category";

                string strQueryID =
                    " SELECT "
                    + m_strID 
                    + " FROM  "
                    + strTableCategory
                    + " WHERE "
                    + " 1 = 1 "
                    + " AND " + strTableCategory + "." + m_strType + " like '%" + cmbCategory.Text + "%'"
                    ;

                string strDataValue;
                strDataValue = dbConnect.GetDataValue(strQueryID, m_strID);
                int nID = Convert.ToInt32(strDataValue);

                //string strQuery =
                //    "INSERT INTO "
                //    + m_strTableName
                //    + "("
                //    + m_strName + ","
                //    + m_strDetails + ","
                //    + m_strCategoryID
                //    + ") VALUES("
                //    + "'" + txtName.Text + "', "
                //    + "'" + txtDetails.Text + "', "
                //    + nID 
                //    + ")";
                string strQuery = SingletonSonar.Instance.ProductInsertQuery(txtName.Text, 
                    txtDetails.Text, nID);
                
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
                //string strQuery =
                //                    "UPDATE "
                //                    + m_strTableName
                //                    + " SET "
                //                    + m_strName + "=" + "'" + txtName.Text + "', "
                //                    + m_strDetails + "=" + "'" + txtDetails.Text + "', "
                //                    + m_strCategory + "=" + "'" + cmbCategory.Text + "'"
                //                    + " WHERE "
                //                    + m_strID + "=" + m_nID
                //                    ;
                string strQuery = SingletonSonar.Instance.ProductUpdatetQuery(
                    txtName.Text, txtDetails.Text, cmbCategory.Text, m_nID);
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
                //string strQuery =
                //                "DELETE FROM "
                //                + m_strTableName
                //                + " WHERE "
                //                + m_strID + "=" + m_nID
                //                ;

                string strQuery = SingletonSonar.Instance.ProductDeleteQuery(m_nID);
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
            else
            {
                m_nID = 0;
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string GetName()
        {
            return txtName.Text;
        }

        public int GetID()
        {
            return m_nID;
        }
        public int GetCategoryID()
        {
            return m_nCategoryID;
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
