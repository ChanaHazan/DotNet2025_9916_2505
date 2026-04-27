using BO;
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
    public partial class ProductForm : Form
    {
        private BlApi.IBl _bl = BlApi.Factory.Get();
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
                panelRead.Visible = true;
                panelReadAll.Visible = false;
                panelCreateProduct.Visible = false;
            }
            if (CurrentMode == FormMode.Create)
            {
                panelCreateProduct.Visible = true;
                panelRead.Visible = false;
                panelReadAll.Visible = false;
            }
            if (CurrentMode == FormMode.ViewAll)
            {
                panelReadAll.Visible = true;
                panelRead.Visible = false;
                panelCreateProduct.Visible = false;
                var products = _bl.Product.ReadAll();
                dataGridViewReadAllProducts.DataSource = products;
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
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = Enum.GetValues(typeof(BO.Categories));
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEnterProductName.Text))
            {
                MessageBox.Show("נא להזין מספר ID");
                return;
            }
            if (int.TryParse(textBoxEnterProductName.Text, out int id))
            {
                var product = _bl.Product.Read(id);

                if (product != null)
                {
                    dataGridViewReadProduct.DataSource = new List<BO.Product> { product };
                }
                else
                {
                    MessageBox.Show("המוצר לא נמצא");
                    dataGridViewReadProduct.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("נא להזין מספרים בלבד");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product newProduct = new BO.Product
                {
                    ProductName = textBoxName.Text,
                    Category =(Categories)comboBoxCategory.SelectedItem,
                    Price = double.Parse(textBoxPrice.Text),
                    Stock = (int)numericUpDownStock.Value
                };

                int newId=_bl.Product.Create(newProduct);

                MessageBox.Show($"המוצר נוסף בהצלחה! המזהה שלו:{newId}");

                ClearFields();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת המוצר: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxPrice.Clear();
            numericUpDownStock.Value = 0;
        }
    }
}
