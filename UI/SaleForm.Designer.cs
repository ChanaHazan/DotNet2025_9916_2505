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
            numericUpToAmount = new NumericUpDown();
            label15 = new Label();
            filterButton = new Button();
            toViewallCategore = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numericUpToAmount).BeginInit();
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
            panelRead.Margin = new Padding(2);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(2438, 1478);
            panelRead.TabIndex = 7;
            panelRead.Visible = false;
            // 
            // dataGridViewRead
            // 
            dataGridViewRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRead.Location = new Point(842, 564);
            dataGridViewRead.Margin = new Padding(2);
            dataGridViewRead.Name = "dataGridViewRead";
            dataGridViewRead.RowHeadersWidth = 123;
            dataGridViewRead.Size = new Size(1265, 451);
            dataGridViewRead.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(912, 439);
            buttonSearch.Margin = new Padding(2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(270, 70);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "חפש מבצע זה";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.Location = new Point(1242, 451);
            textBoxEnterName.Margin = new Padding(2);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(464, 55);
            textBoxEnterName.TabIndex = 1;
            // 
            // labelEnterProductName
            // 
            labelEnterProductName.AutoSize = true;
            labelEnterProductName.Location = new Point(1758, 454);
            labelEnterProductName.Margin = new Padding(2, 0, 2, 0);
            labelEnterProductName.Name = "labelEnterProductName";
            labelEnterProductName.Size = new Size(294, 48);
            labelEnterProductName.TabIndex = 0;
            labelEnterProductName.Text = "הכנס מזהה מבצע";
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(2510, 1409);
            backToLastForm.Margin = new Padding(2);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(452, 70);
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
            formToUpdateProduct.Margin = new Padding(2);
            formToUpdateProduct.Name = "formToUpdateProduct";
            formToUpdateProduct.Size = new Size(2455, 1462);
            formToUpdateProduct.TabIndex = 13;
            formToUpdateProduct.Visible = false;
            formToUpdateProduct.Paint += panelReadAll_Paint;
            // 
            // saleIdToUpdate
            // 
            saleIdToUpdate.Location = new Point(1400, 302);
            saleIdToUpdate.Margin = new Padding(8, 7, 8, 7);
            saleIdToUpdate.Name = "saleIdToUpdate";
            saleIdToUpdate.Size = new Size(306, 55);
            saleIdToUpdate.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1412, 247);
            label14.Margin = new Padding(8, 0, 8, 0);
            label14.Name = "label14";
            label14.Size = new Size(294, 48);
            label14.TabIndex = 15;
            label14.Text = "הכנס מזהה מבצע";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1798, 775);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(246, 48);
            label8.TabIndex = 14;
            label8.Text = "תאריך התחלה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1798, 869);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(198, 48);
            label9.TabIndex = 13;
            label9.Text = "תאריך סיום";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1122, 869);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(599, 55);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1125, 770);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(599, 55);
            dateTimePicker2.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1432, 684);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(477, 52);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "האם המבצע לכל הלקוחות";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // toUpdateSale
            // 
            toUpdateSale.Location = new Point(1515, 965);
            toUpdateSale.Margin = new Padding(2);
            toUpdateSale.Name = "toUpdateSale";
            toUpdateSale.Size = new Size(225, 70);
            toUpdateSale.TabIndex = 9;
            toUpdateSale.Text = "עדכן מבצע";
            toUpdateSale.UseVisualStyleBackColor = true;
            toUpdateSale.Click += toUpdateSale_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1362, 595);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(360, 55);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1422, 511);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 55);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBox1.Location = new Point(1362, 434);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 56);
            comboBox1.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1765, 598);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(215, 48);
            label10.TabIndex = 4;
            label10.Text = "כמות נדרשת";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1765, 514);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(196, 48);
            label11.TabIndex = 3;
            label11.Text = "מחיר מבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1765, 434);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(189, 48);
            label12.TabIndex = 2;
            label12.Text = "מזהה מוצר";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1170, 605);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(0, 48);
            label13.TabIndex = 1;
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(numericUpToAmount);
            panelReadAll.Controls.Add(label15);
            panelReadAll.Controls.Add(filterButton);
            panelReadAll.Controls.Add(toViewallCategore);
            panelReadAll.Controls.Add(dataGridViewReadAll);
            panelReadAll.Location = new Point(0, 0);
            panelReadAll.Margin = new Padding(2);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(2472, 1111);
            panelReadAll.TabIndex = 10;
            panelReadAll.Visible = false;
            panelReadAll.Paint += panelReadAll_Paint;
            // 
            // numericUpToAmount
            // 
            numericUpToAmount.Location = new Point(600, 970);
            numericUpToAmount.Margin = new Padding(8, 7, 8, 7);
            numericUpToAmount.Name = "numericUpToAmount";
            numericUpToAmount.Size = new Size(375, 55);
            numericUpToAmount.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(642, 881);
            label15.Margin = new Padding(8, 0, 8, 0);
            label15.Name = "label15";
            label15.Size = new Size(272, 48);
            label15.TabIndex = 2;
            label15.Text = "בחר כמות לסינון";
            // 
            // filterButton
            // 
            filterButton.Location = new Point(152, 910);
            filterButton.Margin = new Padding(8, 7, 8, 7);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(252, 166);
            filterButton.TabIndex = 3;
            filterButton.Text = "לסינון לפי כמות נדרשת למבצע";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // toViewallCategore
            // 
            toViewallCategore.Location = new Point(1650, 924);
            toViewallCategore.Margin = new Padding(8, 7, 8, 7);
            toViewallCategore.Name = "toViewallCategore";
            toViewallCategore.Size = new Size(312, 137);
            toViewallCategore.TabIndex = 4;
            toViewallCategore.Text = "להצגת כל המבצעים";
            toViewallCategore.UseVisualStyleBackColor = true;
            toViewallCategore.Click += toViewallCategore_Click;
            // 
            // dataGridViewReadAll
            // 
            dataGridViewReadAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAll.Location = new Point(32, 24);
            dataGridViewReadAll.Margin = new Padding(2);
            dataGridViewReadAll.Name = "dataGridViewReadAll";
            dataGridViewReadAll.RowHeadersWidth = 123;
            dataGridViewReadAll.Size = new Size(2365, 811);
            dataGridViewReadAll.TabIndex = 0;
            // 
            // paneDelate
            // 
            paneDelate.Controls.Add(IdToDelate);
            paneDelate.Controls.Add(ToDelateSale);
            paneDelate.Controls.Add(label7);
            paneDelate.Location = new Point(0, 0);
            paneDelate.Margin = new Padding(8, 7, 8, 7);
            paneDelate.Name = "paneDelate";
            paneDelate.Size = new Size(2465, 1471);
            paneDelate.TabIndex = 12;
            paneDelate.Paint += paneDelate_Paint;
            // 
            // IdToDelate
            // 
            IdToDelate.Location = new Point(1462, 682);
            IdToDelate.Margin = new Padding(8, 7, 8, 7);
            IdToDelate.Name = "IdToDelate";
            IdToDelate.Size = new Size(306, 55);
            IdToDelate.TabIndex = 2;
            // 
            // ToDelateSale
            // 
            ToDelateSale.Location = new Point(1058, 677);
            ToDelateSale.Margin = new Padding(8, 7, 8, 7);
            ToDelateSale.Name = "ToDelateSale";
            ToDelateSale.Size = new Size(365, 70);
            ToDelateSale.TabIndex = 1;
            ToDelateSale.Text = "למחיקת מבצע";
            ToDelateSale.UseVisualStyleBackColor = true;
            ToDelateSale.Click += ToDelateSale_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1805, 677);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(264, 48);
            label7.TabIndex = 0;
            label7.Text = "הכנס מס מזהה ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1170, 605);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 48);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1662, 398);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 48);
            label3.TabIndex = 2;
            label3.Text = "מזהה מוצר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1662, 478);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 48);
            label4.TabIndex = 3;
            label4.Text = "מחיר מבצע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1662, 562);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 48);
            label5.TabIndex = 4;
            label5.Text = "כמות נדרשת";
            // 
            // comboBoxProductId
            // 
            comboBoxProductId.FormattingEnabled = true;
            comboBoxProductId.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBoxProductId.Location = new Point(1260, 398);
            comboBoxProductId.Margin = new Padding(2);
            comboBoxProductId.Name = "comboBoxProductId";
            comboBoxProductId.Size = new Size(364, 56);
            comboBoxProductId.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(1320, 475);
            textBoxPrice.Margin = new Padding(2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(299, 55);
            textBoxPrice.TabIndex = 7;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(1260, 559);
            numericUpDownQuantity.Margin = new Padding(2);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(360, 55);
            numericUpDownQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1412, 929);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 70);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "הוסף מבצע";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkBoxToAll
            // 
            checkBoxToAll.AutoSize = true;
            checkBoxToAll.Location = new Point(1330, 648);
            checkBoxToAll.Margin = new Padding(2);
            checkBoxToAll.Name = "checkBoxToAll";
            checkBoxToAll.Size = new Size(477, 52);
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
            panelCreate.Margin = new Padding(2);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(2475, 1493);
            panelCreate.TabIndex = 11;
            panelCreate.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1695, 739);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(246, 48);
            label6.TabIndex = 14;
            label6.Text = "תאריך התחלה";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1695, 833);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 48);
            label1.TabIndex = 13;
            label1.Text = "תאריך סיום";
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(1020, 833);
            dateEnd.Margin = new Padding(2);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(599, 55);
            dateEnd.TabIndex = 12;
            // 
            // dateStart
            // 
            dateStart.Location = new Point(1022, 734);
            dateStart.Margin = new Padding(2);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(599, 55);
            dateStart.TabIndex = 11;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3009, 1519);
            Controls.Add(panelReadAll);
            Controls.Add(formToUpdateProduct);
            Controls.Add(panelCreate);
            Controls.Add(paneDelate);
            Controls.Add(backToLastForm);
            Controls.Add(panelRead);
            Location = new Point(38, 11);
            Margin = new Padding(2);
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
            panelReadAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpToAmount).EndInit();
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
        private Label label15;
        private Button filterButton;
        private Button toViewallCategore;
        private NumericUpDown numericUpToAmount;
    }
}