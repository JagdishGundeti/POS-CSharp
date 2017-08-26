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
    public partial class MDISonar : Form
    {
        private int childFormNumber = 0;
        private int m_nGoldRate24Karat = 0;
        private int m_nGoldRate22Karat = 0;
        private int m_nSilverRate = 0;

        private CustomerDetails frmCustomerDetails;

        public MDISonar()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerDetails = new CustomerDetails();
            frmCustomerDetails.MdiParent = this;  
            frmCustomerDetails.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestMysql frmForm = new TestMysql();
            frmForm.MdiParent = this;
            frmForm.Show();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetails frmProductDetails = new ProductDetails();
            frmProductDetails.MdiParent = this;
            frmProductDetails.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails frmOrderDetails = new OrderDetails();
            frmOrderDetails.MdiParent = this;
            frmOrderDetails.Show();
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm frmSettingForm = new SettingForm();
            frmSettingForm.MdiParent = this;
            frmSettingForm.Show();
        }
        public int NGoldRate24Karat
        {
            get
            {
                return m_nGoldRate24Karat;
            }

            set
            {
                m_nGoldRate24Karat = value;
            }
        }

        public int NGoldRate22Karat
        {
            get
            {
                return m_nGoldRate22Karat;
            }

            set
            {
                m_nGoldRate22Karat = value;
            }
        }

        public int NSilverRate
        {
            get
            {
                return m_nSilverRate;
            }

            set
            {
                m_nSilverRate = value;
            }
        }

    }
}
