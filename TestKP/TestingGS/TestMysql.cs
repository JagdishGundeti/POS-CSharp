using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KPSonar
{
    public partial class TestMysql : Form
    {
        private DBConnect dbConnect;

        public TestMysql()
        {
            InitializeComponent();

            txtPath.Text = "D:\\Code\\Sonar\\Data";

            dbConnect = new DBConnect();
        }

        //Insert button clicked
        private void bInsert_Click(object sender, EventArgs e)
        {
            dbConnect.Insert();
        }

        //Update button is clicked
        private void bUpdate_Click(object sender, EventArgs e)
        {
            dbConnect.Update();
        }

        //Delete button is clicked
        private void bDelete_Click(object sender, EventArgs e)
        {
            dbConnect.Delete();
        }

        //Select button is clicked
        private void bSelect_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.Select();

            dgDisplay.Rows.Clear();
            for(int i = 0; i < list[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list[1][i];
                dgDisplay.Rows[number].Cells[2].Value = list[2][i];                
            }
        }

        //Count button clicked
        private void bCount_Click(object sender, EventArgs e)
        {
            int Count = dbConnect.Count();

            dgDisplay.Rows.Clear();
            int number = dgDisplay.Rows.Add();
            dgDisplay.Rows[number].Cells[0].Value = Count + "";
        }

        //Backup button clicked
        private void bBackup_Click(object sender, EventArgs e)
        {
            dbConnect.Backup(txtPath.Text);
        }

        //Restore button clicked
        private void bRestore_Click(object sender, EventArgs e)
        {
            dbConnect.Restore(txtFilePath.Text);
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = txtPath.Text;
            openFileDialog1.Title = "Browse SQL Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = txtPath.Text;
            openFileDialog1.Title = "Browse Exe Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "EXE files (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSQLDump.Text = openFileDialog1.FileName;
                dbConnect.SetMysqlDumpExe(txtSQLDump.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = txtPath.Text;
            openFileDialog1.Title = "Browse Exe Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "EXE files (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSQLExe.Text = openFileDialog1.FileName;
                dbConnect.SetMysqlExe(txtSQLExe.Text);

            }
        }
    }
}