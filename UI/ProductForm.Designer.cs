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
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAllProducts).BeginInit();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadProduct).BeginInit();
            panelCreateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(2756, 1352);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(452, 69);
            backToLastForm.TabIndex = 1;
            backToLastForm.Text = "חזרה ";
            backToLastForm.UseVisualStyleBackColor = true;
            backToLastForm.Click += backToMainForm_Click;
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(dataGridViewReadAllProducts);
            panelReadAll.Location = new Point(95, 33);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(1803, 1275);
            panelReadAll.TabIndex = 2;
            panelReadAll.Visible = false;
            // 
            // dataGridViewReadAllProducts
            // 
            dataGridViewReadAllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAllProducts.Location = new Point(23, 31);
            dataGridViewReadAllProducts.Name = "dataGridViewReadAllProducts";
            dataGridViewReadAllProducts.RowHeadersWidth = 123;
            dataGridViewReadAllProducts.Size = new Size(1748, 1201);
            dataGridViewReadAllProducts.TabIndex = 0;
            // 
            // panelRead
            // 
            panelRead.Controls.Add(dataGridViewReadProduct);
            panelRead.Controls.Add(buttonSearchProduct);
            panelRead.Controls.Add(textBoxEnterProductName);
            panelRead.Controls.Add(labelEnterProductName);
            panelRead.Location = new Point(1942, 33);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(1320, 1267);
            panelRead.TabIndex = 3;
            panelRead.Visible = false;
            // 
            // dataGridViewReadProduct
            // 
            dataGridViewReadProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadProduct.Location = new Point(24, 419);
            dataGridViewReadProduct.Name = "dataGridViewReadProduct";
            dataGridViewReadProduct.RowHeadersWidth = 123;
            dataGridViewReadProduct.Size = new Size(1265, 450);
            dataGridViewReadProduct.TabIndex = 3;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(95, 296);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(270, 69);
            buttonSearchProduct.TabIndex = 2;
            buttonSearchProduct.Text = "חפש מוצר זה";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            buttonSearchProduct.Click += buttonSearchProduct_Click;
            // 
            // textBoxEnterProductName
            // 
            textBoxEnterProductName.Location = new Point(424, 306);
            textBoxEnterProductName.Name = "textBoxEnterProductName";
            textBoxEnterProductName.Size = new Size(463, 55);
            textBoxEnterProductName.TabIndex = 1;
            // 
            // labelEnterProductName
            // 
            labelEnterProductName.AutoSize = true;
            labelEnterProductName.Location = new Point(939, 309);
            labelEnterProductName.Name = "labelEnterProductName";
            labelEnterProductName.Size = new Size(250, 48);
            labelEnterProductName.TabIndex = 0;
            labelEnterProductName.Text = "הכנס שם מוצר";
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
            panelCreateProduct.Location = new Point(812, 18);
            panelCreateProduct.Name = "panelCreateProduct";
            panelCreateProduct.Size = new Size(1731, 1437);
            panelCreateProduct.TabIndex = 4;
            panelCreateProduct.Visible = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(1053, 626);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(225, 69);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "הוסף מוצר";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(918, 517);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(360, 55);
            numericUpDownStock.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(978, 431);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(300, 55);
            textBoxPrice.TabIndex = 7;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBoxCategory.Location = new Point(918, 355);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(363, 56);
            comboBoxCategory.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(971, 274);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 55);
            textBoxName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1320, 519);
            label5.Name = "label5";
            label5.Size = new Size(97, 48);
            label5.TabIndex = 4;
            label5.Text = "מלאי";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1319, 434);
            label4.Name = "label4";
            label4.Size = new Size(98, 48);
            label4.TabIndex = 3;
            label4.Text = "מחיר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1320, 355);
            label3.Name = "label3";
            label3.Size = new Size(148, 48);
            label3.TabIndex = 2;
            label3.Text = "קטגוריה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1320, 274);
            label2.Name = "label2";
            label2.Size = new Size(158, 48);
            label2.TabIndex = 1;
            label2.Text = "שם מוצר";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3294, 1486);
            Controls.Add(panelCreateProduct);
            Controls.Add(panelRead);
            Controls.Add(panelReadAll);
            Controls.Add(backToLastForm);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            panelReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAllProducts).EndInit();
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadProduct).EndInit();
            panelCreateProduct.ResumeLayout(false);
            panelCreateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backToLastForm;
        private Panel panelReadAll;
        private DataGridView dataGridViewReadAllProducts;
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
    }
}