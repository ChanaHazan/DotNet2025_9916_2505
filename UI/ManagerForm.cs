using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void backToMainForm_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void products_Click(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
            panelCustomer.Visible = false;
            panelSale.Visible = false;

        }

        private void customer_Click(object sender, EventArgs e)
        {
            panelCustomer.Visible = true;
            panelProduct.Visible = false;
            panelSale.Visible = false;
        }

        private void sales_Click(object sender, EventArgs e)
        {
            panelSale.Visible = true;
            panelCustomer.Visible = false;
            panelProduct.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {

        }
    }
}
