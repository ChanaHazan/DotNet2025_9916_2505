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
    public enum FormMode { Create, Update, Delete, View, ViewAll }
    public partial class ProductForm : Form
    {


        public FormMode CurrentMode { get; set; }
        public ProductForm(FormMode mode)
        {
            InitializeComponent();
            CurrentMode = mode;
            SetupUI();
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

        private void backToMainForm_Click(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
