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
    }
}
