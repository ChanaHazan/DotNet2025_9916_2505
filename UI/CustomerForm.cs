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
            CurrentMode = mode;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
