namespace UI
{
    partial class SaleForm
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
            panelRead = new Panel();
            dataGridViewRead = new DataGridView();
            buttonSearch = new Button();
            textBoxEnterName = new TextBox();
            labelEnterProductName = new Label();
            backToLastForm = new Button();
            formToUpdateProduct = new Panel();
            saleIdToUpdate = new TextBox();
            label14 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            toUpdateSale = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panelReadAll = new Panel();
            dataGridViewReadAll = new DataGridView();
            paneDelate = new Panel();
            IdToDelate = new TextBox();
            ToDelateSale = new Button();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxProductId = new ComboBox();
            textBoxPrice = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            btnAdd = new Button();
            checkBoxToAll = new CheckBox();
            panelCreate = new Panel();
            label6 = new Label();
            label1 = new Label();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).BeginInit();
            formToUpdateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAll).BeginInit();
            paneDelate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            panelCreate.SuspendLayout();
            SuspendLayout();
            // 
            // panelRead
            // 
            panelRead.Controls.Add(dataGridViewRead);
            panelRead.Controls.Add(buttonSearch);
            panelRead.Controls.Add(textBoxEnterName);
            panelRead.Controls.Add(labelEnterProductName);
            panelRead.Location = new Point(0, 0);
            panelRead.Margin = new Padding(1);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(975, 616);
            panelRead.TabIndex = 7;
            panelRead.Visible = false;
            // 
            // dataGridViewRead
            // 
            dataGridViewRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRead.Location = new Point(337, 235);
            dataGridViewRead.Margin = new Padding(1);
            dataGridViewRead.Name = "dataGridViewRead";
            dataGridViewRead.RowHeadersWidth = 123;
            dataGridViewRead.Size = new Size(506, 188);
            dataGridViewRead.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(365, 183);
            buttonSearch.Margin = new Padding(1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(108, 29);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "חפש מבצע זה";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.Location = new Point(497, 188);
            textBoxEnterName.Margin = new Padding(1);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(188, 27);
            textBoxEnterName.TabIndex = 1;
            // 
            // labelEnterProductName
            // 
            labelEnterProductName.AutoSize = true;
            labelEnterProductName.Location = new Point(703, 189);
            labelEnterProductName.Margin = new Padding(1, 0, 1, 0);
            labelEnterProductName.Name = "labelEnterProductName";
            labelEnterProductName.Size = new Size(123, 20);
            labelEnterProductName.TabIndex = 0;
            labelEnterProductName.Text = "הכנס מזהה מבצע";
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(1004, 587);
            backToLastForm.Margin = new Padding(1);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(181, 29);
            backToLastForm.TabIndex = 9;
            backToLastForm.Text = "חזרה ";
            backToLastForm.UseVisualStyleBackColor = true;
            backToLastForm.Click += backToLastForm_Click;
            // 
            // formToUpdateProduct
            // 
            formToUpdateProduct.Controls.Add(saleIdToUpdate);
            formToUpdateProduct.Controls.Add(label14);
            formToUpdateProduct.Controls.Add(label8);
            formToUpdateProduct.Controls.Add(label9);
            formToUpdateProduct.Controls.Add(dateTimePicker1);
            formToUpdateProduct.Controls.Add(dateTimePicker2);
            formToUpdateProduct.Controls.Add(checkBox1);
            formToUpdateProduct.Controls.Add(toUpdateSale);
            formToUpdateProduct.Controls.Add(numericUpDown1);
            formToUpdateProduct.Controls.Add(textBox1);
            formToUpdateProduct.Controls.Add(comboBox1);
            formToUpdateProduct.Controls.Add(label10);
            formToUpdateProduct.Controls.Add(label11);
            formToUpdateProduct.Controls.Add(label12);
            formToUpdateProduct.Controls.Add(label13);
            formToUpdateProduct.Location = new Point(0, 0);
            formToUpdateProduct.Margin = new Padding(1);
            formToUpdateProduct.Name = "formToUpdateProduct";
            formToUpdateProduct.Size = new Size(982, 609);
            formToUpdateProduct.TabIndex = 13;
            formToUpdateProduct.Visible = false;
            formToUpdateProduct.Paint += panelReadAll_Paint;
            // 
            // saleIdToUpdate
            // 
            saleIdToUpdate.Location = new Point(560, 126);
            saleIdToUpdate.Name = "saleIdToUpdate";
            saleIdToUpdate.Size = new Size(125, 27);
            saleIdToUpdate.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(565, 103);
            label14.Name = "label14";
            label14.Size = new Size(123, 20);
            label14.TabIndex = 15;
            label14.Text = "הכנס מזהה מבצע";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(719, 323);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 14;
            label8.Text = "תאריך התחלה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(719, 362);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 13;
            label9.Text = "תאריך סיום";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(449, 362);
            dateTimePicker1.Margin = new Padding(1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(450, 321);
            dateTimePicker2.Margin = new Padding(1);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(242, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(573, 285);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(201, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "האם המבצע לכל הלקוחות";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // toUpdateSale
            // 
            toUpdateSale.Location = new Point(606, 402);
            toUpdateSale.Margin = new Padding(1);
            toUpdateSale.Name = "toUpdateSale";
            toUpdateSale.Size = new Size(90, 29);
            toUpdateSale.TabIndex = 9;
            toUpdateSale.Text = "עדכן מבצע";
            toUpdateSale.UseVisualStyleBackColor = true;
            toUpdateSale.Click += toUpdateSale_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(545, 248);
            numericUpDown1.Margin = new Padding(1);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(569, 213);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBox1.Location = new Point(545, 181);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(706, 249);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 4;
            label10.Text = "כמות נדרשת";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(706, 214);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 3;
            label11.Text = "מחיר מבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(706, 181);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 2;
            label12.Text = "מזהה מוצר";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(468, 252);
            label13.Margin = new Padding(1, 0, 1, 0);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 1;
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(dataGridViewReadAll);
            panelReadAll.Location = new Point(0, 0);
            panelReadAll.Margin = new Padding(1);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(989, 616);
            panelReadAll.TabIndex = 10;
            panelReadAll.Visible = false;
            panelReadAll.Paint += panelReadAll_Paint;
            // 
            // dataGridViewReadAll
            // 
            dataGridViewReadAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAll.Location = new Point(13, 21);
            dataGridViewReadAll.Margin = new Padding(1);
            dataGridViewReadAll.Name = "dataGridViewReadAll";
            dataGridViewReadAll.RowHeadersWidth = 123;
            dataGridViewReadAll.Size = new Size(946, 584);
            dataGridViewReadAll.TabIndex = 0;
            // 
            // paneDelate
            // 
            paneDelate.Controls.Add(IdToDelate);
            paneDelate.Controls.Add(ToDelateSale);
            paneDelate.Controls.Add(label7);
            paneDelate.Location = new Point(0, 0);
            paneDelate.Name = "paneDelate";
            paneDelate.Size = new Size(986, 613);
            paneDelate.TabIndex = 12;
            paneDelate.Paint += paneDelate_Paint;
            // 
            // IdToDelate
            // 
            IdToDelate.Location = new Point(585, 284);
            IdToDelate.Name = "IdToDelate";
            IdToDelate.Size = new Size(125, 27);
            IdToDelate.TabIndex = 2;
            // 
            // ToDelateSale
            // 
            ToDelateSale.Location = new Point(423, 282);
            ToDelateSale.Name = "ToDelateSale";
            ToDelateSale.Size = new Size(146, 29);
            ToDelateSale.TabIndex = 1;
            ToDelateSale.Text = "למחיקת מבצע";
            ToDelateSale.UseVisualStyleBackColor = true;
            ToDelateSale.Click += ToDelateSale_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(722, 282);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 0;
            label7.Text = "הכנס מס מזהה ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 252);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 166);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "מזהה מוצר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(665, 199);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "מחיר מבצע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(665, 234);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "כמות נדרשת";
            // 
            // comboBoxProductId
            // 
            comboBoxProductId.FormattingEnabled = true;
            comboBoxProductId.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBoxProductId.Location = new Point(504, 166);
            comboBoxProductId.Margin = new Padding(1);
            comboBoxProductId.Name = "comboBoxProductId";
            comboBoxProductId.Size = new Size(148, 28);
            comboBoxProductId.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(528, 198);
            textBoxPrice.Margin = new Padding(1);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(122, 27);
            textBoxPrice.TabIndex = 7;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(504, 233);
            numericUpDownQuantity.Margin = new Padding(1);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(144, 27);
            numericUpDownQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(565, 387);
            btnAdd.Margin = new Padding(1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "הוסף מבצע";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkBoxToAll
            // 
            checkBoxToAll.AutoSize = true;
            checkBoxToAll.Location = new Point(532, 270);
            checkBoxToAll.Margin = new Padding(1);
            checkBoxToAll.Name = "checkBoxToAll";
            checkBoxToAll.Size = new Size(201, 24);
            checkBoxToAll.TabIndex = 10;
            checkBoxToAll.Text = "האם המבצע לכל הלקוחות";
            checkBoxToAll.UseVisualStyleBackColor = true;
            // 
            // panelCreate
            // 
            panelCreate.Controls.Add(label6);
            panelCreate.Controls.Add(label1);
            panelCreate.Controls.Add(dateEnd);
            panelCreate.Controls.Add(dateStart);
            panelCreate.Controls.Add(checkBoxToAll);
            panelCreate.Controls.Add(btnAdd);
            panelCreate.Controls.Add(numericUpDownQuantity);
            panelCreate.Controls.Add(textBoxPrice);
            panelCreate.Controls.Add(comboBoxProductId);
            panelCreate.Controls.Add(label5);
            panelCreate.Controls.Add(label4);
            panelCreate.Controls.Add(label3);
            panelCreate.Controls.Add(label2);
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(1);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(990, 622);
            panelCreate.TabIndex = 11;
            panelCreate.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(678, 308);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 14;
            label6.Text = "תאריך התחלה";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(678, 347);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 13;
            label1.Text = "תאריך סיום";
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(408, 347);
            dateEnd.Margin = new Padding(1);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(242, 27);
            dateEnd.TabIndex = 12;
            // 
            // dateStart
            // 
            dateStart.Location = new Point(409, 306);
            dateStart.Margin = new Padding(1);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(242, 27);
            dateStart.TabIndex = 11;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 440);
            Controls.Add(formToUpdateProduct);
            Controls.Add(panelCreate);
            Controls.Add(paneDelate);
            Controls.Add(panelReadAll);
            Controls.Add(backToLastForm);
            Controls.Add(panelRead);
            Location = new Point(38, 11);
            Margin = new Padding(1);
            Name = "SaleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaleForm";
            Load += SaleForm_Load;
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).EndInit();
            formToUpdateProduct.ResumeLayout(false);
            formToUpdateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAll).EndInit();
            paneDelate.ResumeLayout(false);
            paneDelate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRead;
        private DataGridView dataGridViewRead;
        private Button buttonSearch;
        private TextBox textBoxEnterName;
        private Label labelEnterProductName;
        private Panel panelReadAll;
        private Button backToLastForm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxProductId;
        private TextBox textBoxPrice;
        private NumericUpDown numericUpDownQuantity;
        private Button btnAdd;
        private CheckBox checkBoxToAll;
        private Panel panelCreate;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label label6;
        private Label label1;
        private Panel paneDelate;
        private TextBox IdToDelate;
        private Button ToDelateSale;
        private Label label7;
        private DataGridView dataGridViewReadAll;
        private Panel formToUpdateProduct;
        private TextBox saleIdToUpdate;
        private Label label14;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private Button toUpdateSale;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}