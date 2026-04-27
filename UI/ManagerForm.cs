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

        private void ManagerForm_Load(object sender, EventArgs e)
        {
        }

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.Create);
            pf.Show();
            this.Hide();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.Delete);
            pf.Show();
            this.Hide();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.Update);
            pf.Show();
            this.Hide();
        }

        private void ReadProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.View);
            pf.Show();
            this.Hide();
        }

        private void ReadAllProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.ViewAll);
            pf.Show();
            this.Hide();
        }

        private void createSale_Click(object sender, EventArgs e)
        {
            SaleUpdateForm sf = new SaleUpdateForm(FormMode.Create);
            sf.Show();
            this.Hide();
        }

        private void deleteSale_Click(object sender, EventArgs e)
        {
            SaleUpdateForm sf = new SaleUpdateForm(FormMode.Delete);
            sf.Show();
            this.Hide();
        }

        private void updateSale_Click(object sender, EventArgs e)
        {
            SaleUpdateForm sf = new SaleUpdateForm(FormMode.Update);
            sf.Show();
            this.Hide();
        }

        private void readSale_Click(object sender, EventArgs e)
        {
            SaleUpdateForm sf = new SaleUpdateForm(FormMode.View);
            sf.Show();
            this.Hide();
        }

        private void readAllSales_Click(object sender, EventArgs e)
        {
            SaleUpdateForm sf = new SaleUpdateForm(FormMode.ViewAll);
            sf.Show();
            this.Hide();
        }

        private void createCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.Create);
            cf.Show();
            this.Hide();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.Delete);
            cf.Show();
            this.Hide();
        }

        private void readCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.View);
            cf.Show();
            this.Hide();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.Update);
            cf.Show();
            this.Hide();
        }

        private void readAllCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.ViewAll);
            cf.Show();
            this.Hide();
        }
    }
}
