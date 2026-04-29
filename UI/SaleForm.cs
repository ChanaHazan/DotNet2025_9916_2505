using BO;


namespace UI
{
    public partial class SaleForm : Form
    {
        private BlApi.IBl _bl = BlApi.Factory.Get();
        public FormMode CurrentMode { get; set; }

        private ManagerForm _parentForm;
        public SaleForm(FormMode mode, ManagerForm parent)
        {
            InitializeComponent();
            CurrentMode = mode;
            _parentForm = parent;
            SetupUI();
        }

        private void SetupUI()
        {
            paneDelate.Visible = false;
            panelRead.Visible = false;
            panelReadAll.Visible = false;
            panelCreate.Visible = false;
            formToUpdateProduct.Visible = false;
            if (CurrentMode == FormMode.View)
            {
                panelRead.Visible = true;
            }
            if (CurrentMode == FormMode.Create)
            {
                panelCreate.Visible = true;
            }
            if (CurrentMode == FormMode.ViewAll)
            {
                panelReadAll.Visible = true;
                var sales = _bl.Sale.ReadAll();
                dataGridViewReadAll.DataSource = sales;

            }
            if (CurrentMode == FormMode.Update)
            {
                formToUpdateProduct.Visible = true;
            }
            if (CurrentMode == FormMode.Delete)
            {
                paneDelate.Visible = true;
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            var allProducts = _bl.Product.ReadAll();
            var productIds = allProducts.Select(p => p.Id).ToList();
            comboBoxProductId.DataSource = productIds;
            comboBox1.DataSource = new List<int>(productIds);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale newSale = new BO.Sale
                {
                    ProductId = (int)comboBoxProductId.SelectedItem,
                    SalePrice = double.Parse(textBoxPrice.Text),
                    QuantityRequier = (int)numericUpDownQuantity.Value,
                    IsSaleToAllCustomer = checkBoxToAll.Checked,
                    StartSale = dateStart.Value,
                    EndSale = dateEnd.Value
                };

                int newId = _bl.Sale.Create(newSale);

                MessageBox.Show($"המבצע נוסף בהצלחה! המזהה שלו:{newId}");
                ClearAllSaleFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת המוצר: " + ex.Message);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxEnterName.Text))
                {
                    MessageBox.Show("נא להזין מספר ID");
                    return;
                }
                if (int.TryParse(textBoxEnterName.Text, out int id))
                {
                    var sale = _bl.Sale.Read(id);

                    if (sale != null)
                    {
                        dataGridViewRead.DataSource = new List<BO.Sale> { sale };
                    }
                    else
                    {
                        MessageBox.Show("המבצע לא נמצא");
                        dataGridViewRead.DataSource = null;
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

        private void backToLastForm_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }

        private void ToDelateSale_Click(object sender, EventArgs e)
        {
            string input = IdToDelate.Text;

            if (int.TryParse(input, out int saleId))
            {
                try
                {
                    _bl.Sale.Delete(saleId);
                    MessageBox.Show($"מבצע מספר {saleId} נמחק בהצלחה!", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IdToDelate.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("חלה שגיאה: " + ex.Message, "שגיאה במערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("נא להזין מספר מבצע תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void paneDelate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toUpdateSale_Click(object sender, EventArgs e)
        {
            try
            {
                string id = saleIdToUpdate.Text;
                if (!int.TryParse(id, out int saleId))
                {
                    MessageBox.Show("נא להזין מספר מבצע לעדכון תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BO.Sale newSale = new BO.Sale
                {
                    Id = saleId,
                    ProductId = int.Parse(comboBox1.Text),
                    SalePrice = string.IsNullOrWhiteSpace(textBox1.Text) ? 0 : double.Parse(textBox1.Text),
                    QuantityRequier = (int)numericUpDown1.Value,
                    IsSaleToAllCustomer = checkBox1.Checked,
                    StartSale = dateTimePicker2.Value,
                    EndSale = dateTimePicker1.Value
                };

                _bl.Sale.Update(newSale);

                MessageBox.Show($"המבצע התעדכן בהצלחה! המזהה שלו:{saleId}");
                ClearAllSaleFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון המבצע: " + ex.Message);
            }
        }
        private void ClearAllSaleFields()
        {
            Panel[] allPanels = { formToUpdateProduct, panelCreate, paneDelate, panelReadAll, panelRead };

            foreach (var panel in allPanels)
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

        private void panelReadAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formToUpdateProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toViewallCategore_Click(object sender, EventArgs e)
        {
            var sales = _bl.Sale.ReadAll();
            dataGridViewReadAll.DataSource = sales;
            ClearAllSaleFields();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount=(int)numericUpToAmount.Value;
                var sales = _bl.Sale.ReadAll(s => (s.QuantityRequier== amount));
                dataGridViewReadAll.DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("חלה שגיאה: " + ex.Message, "שגיאה במערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    public enum FormMode { Create, Update, Delete, View, ViewAll }
}
