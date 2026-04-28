using BO;


namespace UI
{
    public partial class ProductForm : Form
    {
        private BlApi.IBl _bl = BlApi.Factory.Get();
        public FormMode CurrentMode { get; set; }

        private ManagerForm _parentForm;
        public ProductForm(FormMode mode, ManagerForm parentForm)
        {
            InitializeComponent();
            CurrentMode = mode;
            SetupUI();
            _parentForm = parentForm;
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

            _parentForm.Show();
            this.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = Enum.GetValues(typeof(BO.Categories));
            comboBox1.DataSource = Enum.GetValues(typeof(BO.Categories));

        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בקריאה: " + ex.Message);
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

                ClearAllProductFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת המוצר: " + ex.Message);
            }
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
        private void updateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idToUpdate.Text;
                if (!int.TryParse(id, out int productId))
                {

                    MessageBox.Show("נא להזין מספר מוצר לעדכון תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BO.Product newProduct = new BO.Product
                {
                    Id = productId,
                    ProductName = textBox2.Text,
                    Category = (Categories)comboBox1.SelectedItem,
                    Price = string.IsNullOrWhiteSpace(textBox1.Text) ? 0 : double.Parse(textBox1.Text),
                    Stock = (int)numericUpDown1.Value
                };
                _bl.Product.Update(newProduct);


                MessageBox.Show($"המוצר עודכן בהצלחה!");
                ClearAllProductFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון המוצר: " + ex.Message);
            }
        }
        private void ClearAllProductFields()
        {
            Panel[] productPanels = {
        formUpdateProduct,
        paneDelate,
        panelCreateProduct,
        panelRead,
        panelReadAll
    };

            foreach (var panel in productPanels)
            {
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is TextBox txt)
                        txt.Clear();

                    if (ctrl is ComboBox cb)
                        cb.SelectedIndex = -1;

                    if (ctrl is NumericUpDown nud)
                        nud.Value = 0;

                    if (ctrl is DateTimePicker dtp)
                        dtp.Value = DateTime.Now;

                    if (ctrl is CheckBox chk)
                        chk.Checked = false;
                }
            }
        }

        private void formUpdateProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
