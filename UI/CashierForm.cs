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
    public partial class CashierForm : Form
    {
        BindingList<BO.ProductInOrder> cartList = new BindingList<BO.ProductInOrder>();
        BO.Order currentOrder = new BO.Order { ProductInOrder = new List<BO.ProductInOrder>() };
        private BlApi.IBl _bl = BlApi.Factory.Get();
        public CashierForm()
        {
            InitializeComponent();
        }

        private void backToMainForm_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            dataGridViewOrder.DataSource = cartList;
            dataGridViewOrder.AllowUserToAddRows = false;
            var allProducts = _bl.Product.ReadAll();
            toChooseProduct.DataSource = allProducts.ToList();
            toChooseProduct.DisplayMember = "ProductName";
            toChooseProduct.ValueMember = "Id";
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = cartList[e.RowIndex];
            string columnName = dataGridViewOrder.Columns[e.ColumnIndex].Name;
            if (columnName == "PlusColumn")
            {
                RefreshRowData(e.RowIndex, 1);
            }
            else if (columnName == "MinusColumn")
            {
                if (item.Amount > 1)
                {
                    RefreshRowData(e.RowIndex, -1);
                }
            }
            else if (columnName == "DeleteColumn")
            {
                cartList.RemoveAt(e.RowIndex);
                UpdateFinalTotal();
            }
        }

        // פונקציית עזר קטנה כדי לא לחזור על קוד
        private void RefreshRowData(int rowIndex, int amountToAdd)
        {
            var item = cartList[rowIndex];
            try
            {
                _bl.Order.AddProductToOrder(currentOrder, item.ProductId, amountToAdd);
                dataGridViewOrder.InvalidateRow(rowIndex);
                UpdateFinalTotal();
            }
            catch (BO.BLThereIsNotEnoughInStock ex)
            {
                MessageBox.Show(ex.Message, "מחסור במלאי", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewOrder.Refresh();
            }
        }

        private void dataGridViewOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewOrder.Columns[e.ColumnIndex].Name == "Amount")
            {
                var item = cartList[e.RowIndex];

                try
                {
                    var product = _bl.Product.Read(item.ProductId);

                    if (item.Amount > product.Stock)
                    {
                        throw new BO.BLThereIsNotEnoughInStock($"אין מספיק במלאי. קיים רק {product.Stock} יחידות.");
                    }

                    _bl.Order.SearchSaleForProduct(item, true);
                    _bl.Order.CalcTotalPriceForProduct(item);

                    dataGridViewOrder.InvalidateRow(e.RowIndex);
                    UpdateFinalTotal();
                }
                catch (BO.BLThereIsNotEnoughInStock ex)
                {
                    MessageBox.Show(ex.Message, "שגיאת מלאי", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    item.Amount = 1;
                    _bl.Order.CalcTotalPriceForProduct(item);
                    dataGridViewOrder.Refresh();
                    UpdateFinalTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה בעדכון הכמות: " + ex.Message);
                }
            }
        }
        private void dataGridViewOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrder.IsCurrentCellDirty)
            {
                dataGridViewOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // בודקים אם השינוי הוא בעמודת הכמות
            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "Amount")
            {
                int newAmount;
                // 1. בדיקה שהוזן מספר תקין
                if (!int.TryParse(e.FormattedValue.ToString(), out newAmount) || newAmount <= 0)
                {
                    MessageBox.Show("נא להזין כמות תקינה גדולה מ-0.");
                    dataGridViewOrder.CancelEdit(); // מבטל את ההקלדה הנוכחית
                    cartList[e.RowIndex].Amount = 1; // מחזיר ל-1
                    return;
                }

                // 2. בדיקת מלאי מול ה-BL
                var item = cartList[e.RowIndex];
                var product = _bl.Product.Read(item.ProductId);

                if (newAmount > product.Stock)
                {
                    MessageBox.Show($"טעות! אין מספיק במלאי. קיים רק {product.Stock} יחידות.", "חריגה מהמלאי");
                    dataGridViewOrder.CancelEdit();
                    item.Amount = 1;
                    _bl.Order.CalcTotalPriceForProduct(item);
                    UpdateFinalTotal();
                }
            }
        }
        private void toAddProduct_Click(object sender, EventArgs e)
        {
            int productId = 0;
            if (!string.IsNullOrWhiteSpace(codeToAddProduct.Text) && int.TryParse(codeToAddProduct.Text, out int id))
            {
                productId = id;
            }
            else if (toChooseProduct.SelectedValue is int selectedId)
            {
                productId = selectedId;
            }

            if (productId > 0)
            {
                try
                {
                    var appliedSales = _bl.Order.AddProductToOrder(currentOrder, productId, 1);

                    cartList.Clear();
                    foreach (var item in currentOrder.ProductInOrder)
                    {
                        cartList.Add(item);
                    }

                    codeToAddProduct.Clear();
                    toChooseProduct.SelectedIndex = -1;
                    UpdateFinalTotal();
                    dataGridViewOrder.Refresh();
                }
                catch (BO.BLThereIsNotEnoughInStock ex)
                {
                    MessageBox.Show(ex.Message, "מחסור במלאי", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה: " + ex.Message);
                }
            }
        }

        private void UpdateFinalTotal()
        {
            double total = cartList.Sum(x => x.TotalPrice);
            lblFinalSum.Text = $"סה\"כ לתשלום: {total:N2} ₪";
        }

        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            
                if (!cartList.Any())
                {
                    MessageBox.Show("הסל ריק!");
                    return;
                }

                try
                {
                    _bl.Order.DoOrder(currentOrder);

                    MessageBox.Show("ההזמנה בוצעה בהצלחה! המלאי עודכן במערכת.");

                    currentOrder = new BO.Order { ProductInOrder = new List<BO.ProductInOrder>() };
                    cartList.Clear();
                    UpdateFinalTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"שגיאה בביצוע ההזמנה: {ex.Message}");
                }
            
        }
    }
}
