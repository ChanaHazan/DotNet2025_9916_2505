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
    public partial class SaleForm : Form
    {
        private BlApi.IBl _bl = BlApi.Factory.Get();
        public FormMode CurrentMode { get; set; }
        public SaleForm(FormMode mode)
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
                panelCreate.Visible = false;
            }
            if (CurrentMode == FormMode.Create)
            {
                panelCreate.Visible = true;
                panelRead.Visible = false;
                panelReadAll.Visible = false;
            }
            if (CurrentMode == FormMode.ViewAll)
            {
                panelReadAll.Visible = true;
                panelRead.Visible = false;
                panelCreate.Visible = false;
                var sales = _bl.Sale.ReadAll();
                dataGridViewReadAll.DataSource = sales;
            }
            if (CurrentMode == FormMode.Update)
            {

            }
            if (CurrentMode == FormMode.Delete)
            {

            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            var allProducts = _bl.Product.ReadAll();
            var productIds = allProducts.Select(p => p.Id).ToList();
            comboBoxProductId.DataSource = productIds;
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת המוצר: " + ex.Message);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
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

        private void backToLastForm_Click(object sender, EventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
        }
    }
}
