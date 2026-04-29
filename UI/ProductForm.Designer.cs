namespace UI
{
    partial class ProductForm
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
            backToLastForm = new Button();
            panelReadAll = new Panel();
            toViewallCategore = new Button();
            filterButton = new Button();
            label11 = new Label();
            comboBoxFilter = new ComboBox();
            dataGridViewReadAllProducts = new DataGridView();
            panelRead = new Panel();
            dataGridViewReadProduct = new DataGridView();
            buttonSearchProduct = new Button();
            textBoxEnterProductName = new TextBox();
            labelEnterProductName = new Label();
            panelCreateProduct = new Panel();
            btnAddProduct = new Button();
            numericUpDownStock = new NumericUpDown();
            textBoxPrice = new TextBox();
            comboBoxCategory = new ComboBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            paneDelate = new Panel();
            IdToDelate = new TextBox();
            ToDelateProduct = new Button();
            label1 = new Label();
            formUpdateProduct = new Panel();
            idToUpdate = new TextBox();
            label10 = new Label();
            updateProduct = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAllProducts).BeginInit();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadProduct).BeginInit();
            panelCreateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            paneDelate.SuspendLayout();
            formUpdateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(918, 593);
            backToLastForm.Margin = new Padding(1);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(181, 29);
            backToLastForm.TabIndex = 1;
            backToLastForm.Text = "חזרה ";
            backToLastForm.UseVisualStyleBackColor = true;
            backToLastForm.Click += backToMainForm_Click;
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(toViewallCategore);
            panelReadAll.Controls.Add(filterButton);
            panelReadAll.Controls.Add(label11);
            panelReadAll.Controls.Add(comboBoxFilter);
            panelReadAll.Controls.Add(dataGridViewReadAllProducts);
            panelReadAll.Location = new Point(0, 10);
            panelReadAll.Margin = new Padding(1);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(769, 420);
            panelReadAll.TabIndex = 2;
            panelReadAll.Visible = false;
            panelReadAll.Paint += panelReadAll_Paint;
            // 
            // toViewallCategore
            // 
            toViewallCategore.Location = new Point(586, 346);
            toViewallCategore.Name = "toViewallCategore";
            toViewallCategore.Size = new Size(125, 57);
            toViewallCategore.TabIndex = 4;
            toViewallCategore.Text = "להצגת כל הקטגוריות";
            toViewallCategore.UseVisualStyleBackColor = true;
            toViewallCategore.Click += toViewallCategore_Click;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(152, 356);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(101, 50);
            filterButton.TabIndex = 3;
            filterButton.Text = "לסינון לפי קטגוריה";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(269, 350);
            label11.Name = "label11";
            label11.Size = new Size(133, 20);
            label11.TabIndex = 2;
            label11.Text = "בחר קטגוריה לסינון";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(269, 378);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(151, 28);
            comboBoxFilter.TabIndex = 1;
            // 
            // dataGridViewReadAllProducts
            // 
            dataGridViewReadAllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAllProducts.Location = new Point(14, 9);
            dataGridViewReadAllProducts.Margin = new Padding(1);
            dataGridViewReadAllProducts.Name = "dataGridViewReadAllProducts";
            dataGridViewReadAllProducts.RowHeadersWidth = 123;
            dataGridViewReadAllProducts.Size = new Size(746, 322);
            dataGridViewReadAllProducts.TabIndex = 0;
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
            panelRead.Size = new Size(913, 628);
            panelRead.TabIndex = 3;
            panelRead.Visible = false;
            // 
            // dataGridViewReadProduct
            // 
            dataGridViewReadProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadProduct.Location = new Point(300, 236);
            dataGridViewReadProduct.Margin = new Padding(1);
            dataGridViewReadProduct.Name = "dataGridViewReadProduct";
            dataGridViewReadProduct.RowHeadersWidth = 123;
            dataGridViewReadProduct.Size = new Size(506, 188);
            dataGridViewReadProduct.TabIndex = 3;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(328, 184);
            buttonSearchProduct.Margin = new Padding(1);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(108, 29);
            buttonSearchProduct.TabIndex = 2;
            buttonSearchProduct.Text = "חפש מוצר זה";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            buttonSearchProduct.Click += buttonSearchProduct_Click;
            // 
            // textBoxEnterProductName
            // 
            textBoxEnterProductName.Location = new Point(460, 189);
            textBoxEnterProductName.Margin = new Padding(1);
            textBoxEnterProductName.Name = "textBoxEnterProductName";
            textBoxEnterProductName.Size = new Size(188, 27);
            textBoxEnterProductName.TabIndex = 1;
            // 
            // labelEnterProductName
            // 
            labelEnterProductName.AutoSize = true;
            labelEnterProductName.Location = new Point(666, 190);
            labelEnterProductName.Margin = new Padding(1, 0, 1, 0);
            labelEnterProductName.Name = "labelEnterProductName";
            labelEnterProductName.Size = new Size(117, 20);
            labelEnterProductName.TabIndex = 0;
            labelEnterProductName.Text = "הכנס מזהה מוצר";
            // 
            // panelCreateProduct
            // 
            panelCreateProduct.Controls.Add(btnAddProduct);
            panelCreateProduct.Controls.Add(numericUpDownStock);
            panelCreateProduct.Controls.Add(textBoxPrice);
            panelCreateProduct.Controls.Add(comboBoxCategory);
            panelCreateProduct.Controls.Add(textBoxName);
            panelCreateProduct.Controls.Add(label5);
            panelCreateProduct.Controls.Add(label4);
            panelCreateProduct.Controls.Add(label3);
            panelCreateProduct.Controls.Add(label2);
            panelCreateProduct.Location = new Point(0, 0);
            panelCreateProduct.Margin = new Padding(1);
            panelCreateProduct.Name = "panelCreateProduct";
            panelCreateProduct.Size = new Size(897, 610);
            panelCreateProduct.TabIndex = 4;
            panelCreateProduct.Visible = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(502, 356);
            btnAddProduct.Margin = new Padding(1);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(90, 29);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "הוסף מוצר";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(436, 312);
            numericUpDownStock.Margin = new Padding(1);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(144, 27);
            numericUpDownStock.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(460, 277);
            textBoxPrice.Margin = new Padding(1);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(122, 27);
            textBoxPrice.TabIndex = 7;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBoxCategory.Location = new Point(436, 245);
            comboBoxCategory.Margin = new Padding(1);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(148, 28);
            comboBoxCategory.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(457, 211);
            textBoxName.Margin = new Padding(1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(122, 27);
            textBoxName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 313);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "מלאי";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 278);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "מחיר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(597, 245);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "קטגוריה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 211);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "שם מוצר";
            // 
            // paneDelate
            // 
            paneDelate.Controls.Add(IdToDelate);
            paneDelate.Controls.Add(ToDelateProduct);
            paneDelate.Controls.Add(label1);
            paneDelate.Location = new Point(0, 0);
            paneDelate.Name = "paneDelate";
            paneDelate.Size = new Size(908, 622);
            paneDelate.TabIndex = 10;
            // 
            // IdToDelate
            // 
            IdToDelate.Location = new Point(586, 312);
            IdToDelate.Name = "IdToDelate";
            IdToDelate.Size = new Size(125, 27);
            IdToDelate.TabIndex = 2;
            // 
            // ToDelateProduct
            // 
            ToDelateProduct.Location = new Point(426, 305);
            ToDelateProduct.Name = "ToDelateProduct";
            ToDelateProduct.Size = new Size(146, 29);
            ToDelateProduct.TabIndex = 1;
            ToDelateProduct.Text = "למחיקת מוצר";
            ToDelateProduct.UseVisualStyleBackColor = true;
            ToDelateProduct.Click += ToDelateProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(715, 314);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס מס מזהה ";
            // 
            // formUpdateProduct
            // 
            formUpdateProduct.Controls.Add(idToUpdate);
            formUpdateProduct.Controls.Add(label10);
            formUpdateProduct.Controls.Add(updateProduct);
            formUpdateProduct.Controls.Add(numericUpDown1);
            formUpdateProduct.Controls.Add(textBox1);
            formUpdateProduct.Controls.Add(comboBox1);
            formUpdateProduct.Controls.Add(textBox2);
            formUpdateProduct.Controls.Add(label6);
            formUpdateProduct.Controls.Add(label7);
            formUpdateProduct.Controls.Add(label8);
            formUpdateProduct.Controls.Add(label9);
            formUpdateProduct.Location = new Point(0, 0);
            formUpdateProduct.Margin = new Padding(1);
            formUpdateProduct.Name = "formUpdateProduct";
            formUpdateProduct.Size = new Size(908, 628);
            formUpdateProduct.TabIndex = 11;
            formUpdateProduct.Visible = false;
            formUpdateProduct.Paint += formUpdateProduct_Paint;
            // 
            // idToUpdate
            // 
            idToUpdate.Location = new Point(488, 170);
            idToUpdate.Name = "idToUpdate";
            idToUpdate.Size = new Size(125, 27);
            idToUpdate.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(488, 149);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 10;
            label10.Text = "הכנס מזהה לעדכון";
            // 
            // updateProduct
            // 
            updateProduct.Location = new Point(523, 387);
            updateProduct.Margin = new Padding(1);
            updateProduct.Name = "updateProduct";
            updateProduct.Size = new Size(90, 29);
            updateProduct.TabIndex = 9;
            updateProduct.Text = "עדכן מוצר";
            updateProduct.UseVisualStyleBackColor = true;
            updateProduct.Click += updateProduct_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(470, 341);
            numericUpDown1.Margin = new Padding(1);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(494, 306);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBox1.Location = new Point(470, 274);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(490, 240);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 27);
            textBox2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(630, 342);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 4;
            label6.Text = "מלאי";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(630, 307);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 3;
            label7.Text = "מחיר";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(630, 274);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 2;
            label8.Text = "קטגוריה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(630, 240);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 1;
            label9.Text = "שם מוצר";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 440);
            Controls.Add(panelReadAll);
            Controls.Add(formUpdateProduct);
            Controls.Add(paneDelate);
            Controls.Add(panelCreateProduct);
            Controls.Add(panelRead);
            Controls.Add(backToLastForm);
            Margin = new Padding(1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            panelReadAll.ResumeLayout(false);
            panelReadAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAllProducts).EndInit();
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadProduct).EndInit();
            panelCreateProduct.ResumeLayout(false);
            panelCreateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            paneDelate.ResumeLayout(false);
            paneDelate.PerformLayout();
            formUpdateProduct.ResumeLayout(false);
            formUpdateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backToLastForm;
        private Panel panelReadAll;
        private Panel panelRead;
        private DataGridView dataGridViewReadProduct;
        private Button buttonSearchProduct;
        private TextBox textBoxEnterProductName;
        private Label labelEnterProductName;
        private Panel panelCreateProduct;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxCategory;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownStock;
        private TextBox textBoxPrice;
        private Button btnAddProduct;
        private Panel paneDelate;
        private TextBox IdToDelate;
        private Button ToDelateProduct;
        private Label label1;
        private DataGridView dataGridViewReadAllProducts;
        private Panel formUpdateProduct;
        private Button updateProduct;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox idToUpdate;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxFilter;
        private Button filterButton;
        private Button toViewallCategore;
    }
}