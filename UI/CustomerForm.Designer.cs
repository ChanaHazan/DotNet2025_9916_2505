namespace UI
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paneDelate = new Panel();
            IdToDelate = new TextBox();
            ToDelateCustomer = new Button();
            label1 = new Label();
            panelReadAll = new Panel();
            dataGridViewReadAllCustomers = new DataGridView();
            panelRead = new Panel();
            dataGridViewReadProduct = new DataGridView();
            buttonSearchProduct = new Button();
            textBoxEnterProductName = new TextBox();
            labelEnterProductName = new Label();
            panelUpdate = new Panel();
            textBoxPhone = new TextBox();
            label2 = new Label();
            idToUpdate = new TextBox();
            label10 = new Label();
            updateCustomer = new Button();
            textBoxAdress = new TextBox();
            textBoxName = new TextBox();
            label7 = new Label();
            label9 = new Label();
            buttonBack = new Button();
            panelCreate = new Panel();
            textBoxName1 = new TextBox();
            label6 = new Label();
            textBoxId = new TextBox();
            textBoxAdress1 = new TextBox();
            btnAdd = new Button();
            textBoxPhoneNumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            paneDelate.SuspendLayout();
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAllCustomers).BeginInit();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadProduct).BeginInit();
            panelUpdate.SuspendLayout();
            panelCreate.SuspendLayout();
            SuspendLayout();
            // 
            // paneDelate
            // 
            paneDelate.Controls.Add(IdToDelate);
            paneDelate.Controls.Add(ToDelateCustomer);
            paneDelate.Controls.Add(label1);
            paneDelate.Location = new Point(0, 0);
            paneDelate.Name = "paneDelate";
            paneDelate.Size = new Size(825, 551);
            paneDelate.TabIndex = 11;
            // 
            // IdToDelate
            // 
            IdToDelate.Location = new Point(416, 272);
            IdToDelate.Name = "IdToDelate";
            IdToDelate.Size = new Size(125, 27);
            IdToDelate.TabIndex = 2;
            // 
            // ToDelateCustomer
            // 
            ToDelateCustomer.Location = new Point(252, 269);
            ToDelateCustomer.Name = "ToDelateCustomer";
            ToDelateCustomer.Size = new Size(146, 29);
            ToDelateCustomer.TabIndex = 1;
            ToDelateCustomer.Text = "למחיקת לקוח";
            ToDelateCustomer.UseVisualStyleBackColor = true;
            ToDelateCustomer.Click += ToDelateCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 272);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס מס מזהה ";
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(dataGridViewReadAllCustomers);
            panelReadAll.Location = new Point(0, 0);
            panelReadAll.Margin = new Padding(1);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(824, 550);
            panelReadAll.TabIndex = 12;
            // 
            // dataGridViewReadAllCustomers
            // 
            dataGridViewReadAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAllCustomers.Location = new Point(8, 16);
            dataGridViewReadAllCustomers.Margin = new Padding(1);
            dataGridViewReadAllCustomers.Name = "dataGridViewReadAllCustomers";
            dataGridViewReadAllCustomers.RowHeadersWidth = 123;
            dataGridViewReadAllCustomers.Size = new Size(800, 529);
            dataGridViewReadAllCustomers.TabIndex = 0;
            // 
            // panelRead
            // 
            panelRead.Controls.Add(dataGridViewReadProduct);
            panelRead.Controls.Add(buttonSearchProduct);
            panelRead.Controls.Add(textBoxEnterProductName);
            panelRead.Controls.Add(labelEnterProductName);
            panelRead.Location = new Point(0, 0);
            panelRead.Margin = new Padding(1);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(832, 558);
            panelRead.TabIndex = 13;
            panelRead.Paint += panel1_Paint;
            // 
            // dataGridViewReadProduct
            // 
            dataGridViewReadProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadProduct.Location = new Point(236, 217);
            dataGridViewReadProduct.Margin = new Padding(1);
            dataGridViewReadProduct.Name = "dataGridViewReadProduct";
            dataGridViewReadProduct.RowHeadersWidth = 123;
            dataGridViewReadProduct.Size = new Size(506, 188);
            dataGridViewReadProduct.TabIndex = 7;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(274, 168);
            buttonSearchProduct.Margin = new Padding(1);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(108, 29);
            buttonSearchProduct.TabIndex = 6;
            buttonSearchProduct.Text = "חפש לקוח זה";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            buttonSearchProduct.Click += buttonSearchProduct_Click;
            // 
            // textBoxEnterProductName
            // 
            textBoxEnterProductName.Location = new Point(402, 171);
            textBoxEnterProductName.Margin = new Padding(1);
            textBoxEnterProductName.Name = "textBoxEnterProductName";
            textBoxEnterProductName.Size = new Size(188, 27);
            textBoxEnterProductName.TabIndex = 5;
            // 
            // labelEnterProductName
            // 
            labelEnterProductName.AutoSize = true;
            labelEnterProductName.Location = new Point(601, 173);
            labelEnterProductName.Margin = new Padding(1, 0, 1, 0);
            labelEnterProductName.Name = "labelEnterProductName";
            labelEnterProductName.Size = new Size(118, 20);
            labelEnterProductName.TabIndex = 4;
            labelEnterProductName.Text = "הכנס מזהה לקוח";
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(textBoxPhone);
            panelUpdate.Controls.Add(label2);
            panelUpdate.Controls.Add(idToUpdate);
            panelUpdate.Controls.Add(label10);
            panelUpdate.Controls.Add(updateCustomer);
            panelUpdate.Controls.Add(textBoxAdress);
            panelUpdate.Controls.Add(textBoxName);
            panelUpdate.Controls.Add(label7);
            panelUpdate.Controls.Add(label9);
            panelUpdate.Location = new Point(0, 0);
            panelUpdate.Margin = new Padding(1);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(826, 552);
            panelUpdate.TabIndex = 13;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(402, 309);
            textBoxPhone.Margin = new Padding(1);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(122, 27);
            textBoxPhone.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 309);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 23;
            label2.Text = "טלפון";
            // 
            // idToUpdate
            // 
            idToUpdate.Location = new Point(402, 168);
            idToUpdate.Name = "idToUpdate";
            idToUpdate.Size = new Size(125, 27);
            idToUpdate.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 145);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 21;
            label10.Text = "הכנס מזהה לעדכון";
            // 
            // updateCustomer
            // 
            updateCustomer.Location = new Point(440, 358);
            updateCustomer.Margin = new Padding(1);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Size = new Size(90, 29);
            updateCustomer.TabIndex = 20;
            updateCustomer.Text = "עדכן";
            updateCustomer.UseVisualStyleBackColor = true;
            updateCustomer.Click += updateCustomer_Click;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(402, 272);
            textBoxAdress.Margin = new Padding(1);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(122, 27);
            textBoxAdress.TabIndex = 18;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(402, 230);
            textBoxName.Margin = new Padding(1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(122, 27);
            textBoxName.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 272);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 14;
            label7.Text = "כתובת";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(542, 230);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 12;
            label9.Text = "שם";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(842, 528);
            buttonBack.Margin = new Padding(1);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(181, 29);
            buttonBack.TabIndex = 14;
            buttonBack.Text = "חזרה ";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelCreate
            // 
            panelCreate.Controls.Add(textBoxName1);
            panelCreate.Controls.Add(label6);
            panelCreate.Controls.Add(textBoxId);
            panelCreate.Controls.Add(textBoxAdress1);
            panelCreate.Controls.Add(btnAdd);
            panelCreate.Controls.Add(textBoxPhoneNumber);
            panelCreate.Controls.Add(label5);
            panelCreate.Controls.Add(label4);
            panelCreate.Controls.Add(label3);
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(1);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(826, 552);
            panelCreate.TabIndex = 15;
            panelCreate.Paint += panelCreate_Paint;
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(380, 190);
            textBoxName1.Margin = new Padding(1);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(122, 27);
            textBoxName1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(516, 186);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 19;
            label6.Text = "שם";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(380, 221);
            textBoxId.Margin = new Padding(1);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(122, 27);
            textBoxId.TabIndex = 18;
            // 
            // textBoxAdress1
            // 
            textBoxAdress1.Location = new Point(380, 252);
            textBoxAdress1.Margin = new Padding(1);
            textBoxAdress1.Name = "textBoxAdress1";
            textBoxAdress1.Size = new Size(122, 27);
            textBoxAdress1.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(436, 332);
            btnAdd.Margin = new Padding(1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "הוסף לקוח";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(380, 286);
            textBoxPhoneNumber.Margin = new Padding(1);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(122, 27);
            textBoxPhoneNumber.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 287);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 12;
            label5.Text = "מספר טלפון";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 252);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 11;
            label4.Text = "כתובת";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 219);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 10;
            label3.Text = "מספר זהות";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 440);
            Controls.Add(panelCreate);
            Controls.Add(paneDelate);
            Controls.Add(panelReadAll);
            Controls.Add(panelUpdate);
            Controls.Add(buttonBack);
            Controls.Add(panelRead);
            Margin = new Padding(1);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            paneDelate.ResumeLayout(false);
            paneDelate.PerformLayout();
            panelReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAllCustomers).EndInit();
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadProduct).EndInit();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel paneDelate;
        private TextBox IdToDelate;
        private Button ToDelateCustomer;
        private Label label1;
        private Panel panelReadAll;
        private DataGridView dataGridViewReadAllCustomers;
        private Panel panelRead;
        private DataGridView dataGridViewReadProduct;
        private Button buttonSearchProduct;
        private TextBox textBoxEnterProductName;
        private Label labelEnterProductName;
        private Panel panelUpdate;
        private TextBox idToUpdate;
        private Label label10;
        private Button updateCustomer;
        private TextBox textBoxAdress;
        private TextBox textBoxName;
        private Label label7;
        private Label label9;
        private TextBox textBoxPhone;
        private Label label2;
        private Button buttonBack;
        private Panel panelCreate;
        private Label label6;
        private TextBox textBoxId;
        private TextBox textBoxAdress1;
        private Button btnAdd;
        private TextBox textBoxPhoneNumber;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxName1;
    }
}