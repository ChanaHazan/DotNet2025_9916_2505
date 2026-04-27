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
    public partial class SaleUpdateForm : Form
    {
        private BlApi.IBl _bl = BlApi.Factory.Get();
        public FormMode CurrentMode { get; set; }
        public SaleUpdateForm(FormMode mode)
        {
            InitializeComponent();
            CurrentMode = mode;
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
            comboBox1.DataSource = productIds;
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
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
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
                    SalePrice = double.Parse(textBoxPrice.Text),
                    QuantityRequier = (int)numericUpDownQuantity.Value,
                    IsSaleToAllCustomer = checkBoxToAll.Checked,
                    StartSale = dateStart.Value,
                    EndSale = dateEnd.Value
                };

                _bl.Sale.Update(newSale);

                MessageBox.Show($"המבצע נוסף בהצלחה! המזהה שלו:{saleId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון המבצע: " + ex.Message);
            }
        }

        private void panelReadAll_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
