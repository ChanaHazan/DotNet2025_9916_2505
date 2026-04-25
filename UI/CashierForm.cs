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
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void backToMainForm_Click(object sender, EventArgs e)
        {
            MainForm main=new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
