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
    public partial class SettingForm : Form
    {
        private DBConnect dbConnect;
        private int m_nID = 0;


        private string m_strTableName = "daily_rates_ex";
        private string m_strID = "id";
        private string m_strCategoryID = "category_id";
        private string m_strValue = "value";
        //private string m_strGold24Karat = "gold24karat";
        //private string m_strGold22Karat = "gold22karat";
        //private string m_strSilver = "silver";
        private string m_strModifiedOn = "ModifiedOn";
        private string m_strModifiedOnValue = "";

        public SettingForm()
        {
            InitializeComponent();
            m_strModifiedOnValue = DateTime.Now.ToString("yyyy-MM-dd");
            dbConnect = new DBConnect();
        }

        //Clear Data  
        private void ClearData()
        {
            m_nID = 0;
            txtGoldRate24Karat.Text = "";
            txtGoldRate22Karat.Text = "";
            txtSilverRate.Text = "";
        }

        private void DisplayData()
        {

            //string strTableCategory = "category";
            //string strQuery =
            //    " SELECT "
            //    + m_strTableName + "." + m_strID + ","
            //    + "type" + ","
            //    + m_strValue + ","
            //    + m_strTableName + "." + m_strModifiedOn
            //    + " FROM  " + m_strTableName
            //    + " JOIN " + strTableCategory
            //    + "   ON (" + m_strTableName + ".category_id = " + strTableCategory + ".id) "
            //    + " WHERE "
            //    + " 1 = 1 "
            //    ;
            //if (chkCurrentDate.Checked == true)
            //{
            //    strQuery = strQuery
            //        + " AND " + m_strTableName + "." + m_strModifiedOn + " = '" + m_strModifiedOnValue + "'";
            //}
            string strQuery = SingletonSonar.Instance.SettingSelectQuery(
                chkCurrentDate.Checked, DateTime.Now.ToString("yyyy-MM-dd"));

            dbConnect.GridDisplay(dataGridView1, strQuery);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DisplayData();
        }


        private void btnInsertOrModify_Click(object sender, EventArgs e)
        {
            bool bReturn = true;

            if ((txtGoldRate24Karat.Text == "") ||
                    (txtGoldRate22Karat.Text == "") || (txtSilverRate.Text == ""))
            {
                MessageBox.Show("input is empty");
                bReturn = false;
            }


            if (bReturn == true)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Your are trying to Insert/Modify record", "Insert", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    bReturn = false;
                }
            }
            if (bReturn == true)
            {
                string strQuery = "";

                int nCategoryId = 1;
                string strDataValue = "";
                nCategoryId = 1;
                strDataValue = GetDataValue(nCategoryId);
                if (String.IsNullOrEmpty(strDataValue) == true)
                {
                    //strQuery = InsertStatement(nCategoryId, txtGoldRate24Karat.Text);
                    strQuery = SingletonSonar.Instance.SettingInsertQuery(nCategoryId, txtGoldRate24Karat.Text);
                }
                else
                {
                    //strQuery = UpdateStatement(nCategoryId, txtGoldRate24Karat.Text);
                    strQuery = SingletonSonar.Instance.SettingUpdateQueryWithDate(nCategoryId, txtGoldRate24Karat.Text);
                }
                bReturn = dbConnect.ExecuteGeneral(strQuery);

                if (bReturn == true)
                {
                    nCategoryId = 2;
                    strDataValue = GetDataValue(nCategoryId);
                    if (String.IsNullOrEmpty(strDataValue) == true)
                    {
                        //strQuery = InsertStatement(nCategoryId, txtGoldRate22Karat.Text);
                        strQuery = SingletonSonar.Instance.SettingInsertQuery(nCategoryId, txtGoldRate22Karat.Text);
                    }
                    else
                    {
                        //strQuery = UpdateStatement(nCategoryId, txtGoldRate22Karat.Text);
                        strQuery = SingletonSonar.Instance.SettingUpdateQueryWithDate(nCategoryId, txtGoldRate22Karat.Text);
                    }
                    bReturn = dbConnect.ExecuteGeneral(strQuery);
                }
                if (bReturn == true)
                {
                    nCategoryId = 3;
                    strDataValue = GetDataValue(nCategoryId);
                    if (String.IsNullOrEmpty(strDataValue) == true)
                    {
                        //strQuery = InsertStatement(nCategoryId, txtSilverRate.Text);
                        strQuery = SingletonSonar.Instance.SettingInsertQuery(nCategoryId, txtSilverRate.Text);
                    }
                    else
                    {
                        //strQuery = UpdateStatement(nCategoryId, txtSilverRate.Text);
                        strQuery = SingletonSonar.Instance.SettingUpdateQueryWithDate(nCategoryId, txtSilverRate.Text);

                    }

                    bReturn = dbConnect.ExecuteGeneral(strQuery);
                }
                if (bReturn == true)
                {
                    MessageBox.Show("Records Inserted");
                    ClearData();
                    DisplayData();
                }
            }
        }

        //private string InsertStatement(int nCategoryId, string strText)
        //{
        //    return "INSERT INTO "
        //            + m_strTableName
        //            + "("
        //            + m_strCategoryID + ","
        //            + m_strValue + ","
        //            + m_strModifiedOn
        //            + ") VALUES("
        //            + nCategoryId + ", "
        //            + strText + ", "
        //            + "'" + m_strModifiedOnValue + "'"
        //            + ")";
        //}

        //private string UpdateStatement(int nCategoryId, string strText)
        //{
        //    return "UPDATE "
        //            + m_strTableName
        //            + " SET "
        //            + m_strValue + "=" + "'" + strText + "'"
        //            + " WHERE "
        //            + m_strCategoryID + "=" + nCategoryId
        //            + " AND " + m_strTableName + "." + m_strModifiedOn + " = '" + m_strModifiedOnValue + "'";
        //}

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
                //m_strModifiedOnValue = DateTime.Now.ToString("yyyy-MM-dd");
                //string strQuery =
                //                    "UPDATE "
                //                    + m_strTableName
                //                    + " SET "
                //                    + m_strValue + "=" + "'" + txtValue.Text + "', "
                //                    + m_strModifiedOn + "=" + "'" + m_strModifiedOnValue + "'"
                //                    + " WHERE "
                //                    + m_strID + "=" + m_nID
                //                    ;

                string strQuery = SingletonSonar.Instance.SettingUpdateQuery(m_nID, txtValue.Text);
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

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string strData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (String.IsNullOrEmpty(strData) == false)
            {
                m_nID = Convert.ToInt32(strData);
                txtValue.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        public string GetGoldRate24Karat()
        {
            return txtGoldRate24Karat.Text;
        }

        public string GetGoldRate22Karat()
        {
            return txtGoldRate22Karat.Text;
        }

        public string GetSilverRate()
        {
            return txtSilverRate.Text;
        }

        public int GetID()
        {
            return m_nID;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            //MDISonar frm = (MDISonar)this.MdiParent;
            ////frm.NGoldRate24Karat = Convert.ToInt32(txtGoldRate24Karat.Text);
            ////frm.NGoldRate22Karat = Convert.ToInt32(txtGoldRate22Karat.Text);
            ////frm.NSilverRate = Convert.ToInt32(txtSilverRate.Text);
            //int nCategoryId = 1;
            //string strDataValue = "";
            //strDataValue = GetDataValue(nCategoryId);
            //txtGoldRate24Karat.Text = strDataValue;
            //frm.NGoldRate24Karat = Convert.ToInt32(strDataValue);
            //nCategoryId = 2;
            //strDataValue = GetDataValue(nCategoryId);
            //txtGoldRate22Karat.Text = strDataValue;
            //frm.NGoldRate22Karat = Convert.ToInt32(strDataValue);
            //nCategoryId = 3;
            //strDataValue = GetDataValue(nCategoryId);
            //txtSilverRate.Text = strDataValue;
            //frm.NSilverRate = Convert.ToInt32(strDataValue);

        }

        private string GetDataValue(int nCategoryId)
        {
            //string strTableCategory = "category";
            //string query =
            //    " SELECT "
            //    + m_strValue
            //    + " FROM  " + m_strTableName
            //    + " JOIN " + strTableCategory
            //    + "   ON (" + m_strTableName + ".category_id = " + strTableCategory + ".id) "
            //    + " WHERE "
            //    + " 1 = 1 "
            //    + " AND " + m_strTableName + "." + m_strModifiedOn + " = '" + m_strModifiedOnValue+"'"
            //    + " AND " + strTableCategory + ".id " + "=" + nCategoryId
            //    ;
            string query = SingletonSonar.Instance.SettingGetValueQuery(nCategoryId);
            string strDataValue;
            strDataValue = dbConnect.GetDataValue(query, m_strValue);
            return strDataValue;
        }

    }
}
