using BlApi;
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


    public partial class CustomerForm : Form
    {
        public FormMode CurrentMode { get; set; }
        public CustomerForm(FormMode mode)
        {
            InitializeComponent();
            SetupUI();
            CurrentMode = mode;
        }

        private void SetupUI()
        {
            if (CurrentMode == FormMode.View)
            {

            }
            if (CurrentMode == FormMode.Create)
            {

            }
            if (CurrentMode == FormMode.ViewAll)
            {

            }
            if (CurrentMode == FormMode.Update)
            {

            }
            if (CurrentMode == FormMode.Delete)
            {

            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void backToLastForm_Click(object sender, EventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
        }
    }
}
