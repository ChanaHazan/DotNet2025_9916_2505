using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{


    public partial class CustomerForm : Form
    {
        public FormMode CurrentMode { get; set; }

        private BlApi.IBl _bl = BlApi.Factory.Get();

        private ManagerForm _parentForm;

        public CustomerForm(FormMode mode, ManagerForm parentForm)
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
            panelCreate.Visible = false;
            paneDelate.Visible = false;
            panelUpdate.Visible = false;

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
                var customers = _bl.Customer.ReadAll();
                dataGridViewReadAllCustomers.DataSource = customers;
            }
            if (CurrentMode == FormMode.Update)
            {
                panelUpdate.Visible = true;
            }
            if (CurrentMode == FormMode.Delete)
            {
                paneDelate.Visible = true;
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void ToDelateCustomer_Click(object sender, EventArgs e)
        {

            string input = IdToDelate.Text;

            if (int.TryParse(input, out int customerId))
            {
                try
                {
                    _bl.Customer.Delete(customerId);
                    MessageBox.Show($"לקוח מספר {customerId} נמחק בהצלחה!", "אישור", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IdToDelate.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("חלה שגיאה: " + ex.Message, "שגיאה במערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("נא להזין מספר לקוח תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                    var customer = _bl.Customer.Read(id);

                    if (customer != null)
                    {
                        dataGridViewReadProduct.DataSource = new List<BO.Customer> { customer };
                    }
                    else
                    {
                        MessageBox.Show("הלקוח לא נמצא");
                        dataGridViewReadProduct.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("נא להזין מספרים בלבד");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("שגיאה בקריאה: " + ex.Message);
            }
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {

            try
            {
                string id = idToUpdate.Text;
                if (!int.TryParse(id, out int Id))
                {

                    MessageBox.Show("נא להזין מספר זהות לעדכון תקין בלבד.", "קלט לא תקין", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BO.Customer newCustomer = new BO.Customer
                {
                    Id = Id,
                    CustomerName = textBoxName.Text,
                    Phone = textBoxPhone.Text,
                    Adress = textBoxAdress.Text
                };
                _bl.Customer.Update(newCustomer);

                MessageBox.Show($"המוצר עודכן בהצלחה! המזהה שלו:{Id}");

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון המוצר: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxAdress.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer newCustomer = new BO.Customer
                {
                    Id = int.Parse(textBoxId.Text),
                    CustomerName =textBoxName1.Text,
                    Phone=textBoxPhoneNumber.Text,
                    Adress=textBoxAdress1.Text
                };

                int newId = _bl.Customer.Create(newCustomer);

                MessageBox.Show($"הלקוח נוסף בהצלחה! המזהה שלו:{newId}");


            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהוספת הלקוח: " + ex.Message);
            }
        }
    }
}
