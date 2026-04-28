

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

        private void ManagerForm_Load(object sender, EventArgs e)
        {
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.Create, this);
            pf.Show();
            this.Hide();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.Delete, this);
            pf.Show();
            this.Hide();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.Update, this);
            pf.Show();
            this.Hide();
        }

        private void ReadProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.View, this);
            pf.Show();
            this.Hide();
        }

        private void ReadAllProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(FormMode.ViewAll, this);
            pf.Show();
            this.Hide();
        }

        private void createSale_Click(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm(FormMode.Create, this);
            sf.Show();
            this.Hide();
        }

        private void deleteSale_Click(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm(FormMode.Delete, this);
            sf.Show();
            this.Hide();
        }

        private void updateSale_Click(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm(FormMode.Update, this);
            sf.Show();
            this.Hide();
        }

        private void readSale_Click(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm(FormMode.View, this);
            sf.Show();
            this.Hide();
        }

        private void readAllSales_Click(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm(FormMode.ViewAll, this);
            sf.Show();
            this.Hide();
        }

        private void createCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.Create, this);
            cf.Show();
            this.Hide();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.Delete, this);
            cf.Show();
            this.Hide();
        }

        private void readCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.View, this);
            cf.Show();
            this.Hide();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.Update, this);
            cf.Show();
            this.Hide();
        }

        private void readAllCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(FormMode.ViewAll, this);
            cf.Show();
            this.Hide();
        }

        private void tabPageProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
