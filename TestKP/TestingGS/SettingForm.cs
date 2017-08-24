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
    public partial class SettingForm : Form
    {
        private DBConnect dbConnect;
        private int m_nID = 0;


        private string m_strTableName = "daily_rates";
        private string m_strID = "id";
        private string m_strGold24Karat = "gold24karat";
        private string m_strGold22Karat = "gold22karat";
        private string m_strSilver = "silver";
        private string m_strModifiedOn = "ModifiedOn";
        private string m_strModifiedOnValue = "2017-08-02";

        public SettingForm()
        {
            InitializeComponent();
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
            // set query to fetch data "Select * from  tabelname"; 
            string query =
                " SELECT * FROM  " + m_strTableName
                + " WHERE "
                + " 1 = 1 "
                + " AND " + m_strGold24Karat + " like '%" + txtGoldRate24Karat.Text + "%'"
                + " AND " + m_strGold22Karat + " like '%" + txtGoldRate22Karat.Text + "%'"
                + " AND " + m_strSilver + " like '%" + txtSilverRate.Text + "%'"
                ;

            dbConnect.GridDisplay(dataGridView1, query);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DisplayData();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool bReturn = true;

            if ((txtGoldRate24Karat.Text == "") ||
                    (txtGoldRate22Karat.Text == "") || (txtSilverRate.Text == ""))
            {
                MessageBox.Show("First Name sould not be empty");
                bReturn = false;
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
                                    + m_strGold24Karat + ","
                                    + m_strGold22Karat + ","
                                    + m_strSilver + ","
                                    + m_strModifiedOn
                                    + ") VALUES("
                                    + txtGoldRate24Karat.Text + ", "
                                    + txtGoldRate22Karat.Text + ", "
                                    + txtSilverRate.Text + ", "
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
                                    + m_strGold24Karat + "=" + "'" + txtGoldRate24Karat.Text + "', "
                                    + m_strGold22Karat + "=" + "'" + txtGoldRate22Karat.Text + "', "
                                    + m_strSilver + "=" + "'" + txtSilverRate.Text + "', "
                                    + m_strModifiedOn + "=" + "'" + m_strModifiedOnValue + "'"
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

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string strData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (String.IsNullOrEmpty(strData) == false)
            {
                m_nID = Convert.ToInt32(strData);
                txtGoldRate24Karat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGoldRate22Karat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSilverRate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
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


            string strData = txtGoldRate24Karat.Text;
            if ((String.IsNullOrEmpty(txtGoldRate24Karat.Text) == false)
                && (String.IsNullOrEmpty(txtGoldRate22Karat.Text) == false)
                && (String.IsNullOrEmpty(txtSilverRate.Text) == false))
            {
                MDISonar frm = (MDISonar)this.MdiParent;

                frm.NGoldRate24Karat = Convert.ToInt32(txtGoldRate24Karat.Text);
                frm.NGoldRate22Karat = Convert.ToInt32(txtGoldRate22Karat.Text);
                frm.NSilverRate = Convert.ToInt32(txtSilverRate.Text);

            }

        }
    }
}
