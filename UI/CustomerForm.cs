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

namespace UI
{


    public partial class CustomerForm : Form
    {
        public FormMode CurrentMode { get; set; }

        private BlApi.IBl _bl = BlApi.Factory.Get();

        public CustomerForm(FormMode mode)
        {
            InitializeComponent();
            CurrentMode = mode;
            SetupUI();

        }

        private void SetupUI()
        {
            if (CurrentMode == FormMode.View)
            {

            }
            if (CurrentMode == FormMode.Create)
            {

            }
            if (CurrentMode == FormMode.ViewAll)
            {

            }
            if (CurrentMode == FormMode.Update)
            {

            }
            if (CurrentMode == FormMode.Delete)
            {
                paneDelate.Visible = true;
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void backToLastForm_Click(object sender, EventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
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
    }
}
