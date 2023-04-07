using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Form1 : Form
    {
        private Button selectedButton;
        private Form openedForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void ChildForm(Form childForm , object btnSender)
        {
            if (openedForm != null)
            {
                openedForm.Close();
            }
            openedForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;   
            childForm.TopLevel = false; 
            this.containerPanel.Controls.Add(childForm);
            this.containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CategoryForm(), sender);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.SupplierForm(), sender);
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {
            ChildForm(new Forms.WarehouseForm(), sender);
        }

        private void wareHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.WarehouseForm(), sender);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CustomerForm(), sender);
        }

        private void inTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.ImportForm(), sender);
        }

        private void outTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.ExportForm(), sender);
        }

        private void transfareToolStripMenuItem_Click(object sender, EventArgs e)
        {
              ChildForm(new Forms.TransfareForm(),sender);
        }

        private void warehouseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.WarehouseReportForm(), sender);
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CategoryReportForm(), sender);
        }

        private void productTransferReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CategoryTransfareReportForm(), sender);
        }

        private void expireProductReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.ExpireCategoryReportForm(), sender);
        }

        private void productAfterPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Forms.CategoryAfterPeriodForm(), sender);
        }
    }
}
