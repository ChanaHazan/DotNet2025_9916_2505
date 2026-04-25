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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cashier_Click(object sender, EventArgs e)
        {
            CashierForm cashier = new CashierForm();
            cashier.Show();
            this.Hide();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            ManagerForm manager= new ManagerForm();
            manager.Show();
            this.Hide();
        }
    }
}
