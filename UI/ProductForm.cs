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
            panelRead.Visible = false;
            panelReadAll.Visible = false;
            panelCreateProduct.Visible = false;
            paneDelate.Visible = false;
            formUpdateProduct.Visible = false;

            if (CurrentMode == FormMode.View)
            {
                panelRead.Visible = true;
            }
            if (CurrentMode == FormMode.Create)
            {
                panelCreateProduct.Visible = true;
                
            }
            if (CurrentMode == FormMode.ViewAll)
            {
                panelReadAll.Visible = true;
                var products = _bl.Product.ReadAll();
                dataGridViewReadAllProducts.DataSource = products;
            }
            if (CurrentMode == FormMode.Update)
            {
                formUpdateProduct.Visible = true;
            }
            if (CurrentMode == FormMode.Delete)
            {
                paneDelate.Visible = true;
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
                    Category = (Categories)comboBoxCategory.SelectedItem,
                    Price = double.Parse(textBoxPrice.Text),
                    Stock = (int)numericUpDownStock.Value
                };

                int newId = _bl.Product.Create(newProduct);

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

        private void dataGridViewReadAllProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToDelateProduct_Click(object sender, EventArgs e)
        {

            string input = IdToDelate.Text;

            if (int.TryParse(input, out int productId))
            {
                try
                {
                    _bl.Product.Delete(productId);
                    MessageBox.Show($"מוצר מספר {productId} נמחק בהצלחה!", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IdToDelate.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("חלה שגיאה: " + ex.Message, "שגיאה במערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("נא להזין מספר מוצר תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IdToDelate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelRead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneDelate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCreateProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formUpdateProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateProduct_Click(object sender, EventArgs e)
        { 

            try
            {
                string id = idToUpdate.Text;
                if (!int.TryParse(id, out int productId)){
                    
                     MessageBox.Show("נא להזין מספר מוצר לעדכון תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                }
                BO.Product newProduct = new BO.Product
                {
                    Id = productId,
                    ProductName = textBoxName.Text,
                    Category = (Categories)comboBoxCategory.SelectedItem,
                    Price = double.Parse(textBoxPrice.Text),
                    Stock = (int)numericUpDownStock.Value
                };
                _bl.Product.Update(newProduct);

                MessageBox.Show($"המוצר עודכן בהצלחה! המזהה שלו:{productId}");

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון המוצר: " + ex.Message);
            }
        }
    }
}
