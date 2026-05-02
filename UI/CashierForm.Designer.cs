namespace UI
{
    partial class CashierForm
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
            backToMainForm = new Button();
            toAddProduct = new Button();
            toChooseProduct = new ComboBox();
            codeToAddProduct = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewOrder = new DataGridView();
            productID = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(883, 652);
            backToMainForm.Margin = new Padding(1);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(181, 29);
            backToMainForm.TabIndex = 1;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            backToMainForm.Click += backToMainForm_Click;
            // 
            // toAddProduct
            // 
            toAddProduct.Location = new Point(748, 220);
            toAddProduct.Name = "toAddProduct";
            toAddProduct.Size = new Size(147, 29);
            toAddProduct.TabIndex = 3;
            toAddProduct.Text = "להוספת מוצר";
            toAddProduct.UseVisualStyleBackColor = true;
            // 
            // toChooseProduct
            // 
            toChooseProduct.FormattingEnabled = true;
            toChooseProduct.Location = new Point(857, 154);
            toChooseProduct.Name = "toChooseProduct";
            toChooseProduct.Size = new Size(151, 28);
            toChooseProduct.TabIndex = 4;
            // 
            // codeToAddProduct
            // 
            codeToAddProduct.Location = new Point(677, 154);
            codeToAddProduct.Name = "codeToAddProduct";
            codeToAddProduct.Size = new Size(125, 27);
            codeToAddProduct.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 106);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 6;
            label1.Text = "הכנס קוד מוצר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(883, 106);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 7;
            label2.Text = "לבחירת מוצר";
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Columns.AddRange(new DataGridViewColumn[] { productID, productName, amount });
            dataGridViewOrder.Location = new Point(12, 46);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.Size = new Size(650, 621);
            dataGridViewOrder.TabIndex = 8;
            dataGridViewOrder.CellContentClick += dataGridViewOrder_CellContentClick;
            // 
            // productID
            // 
            productID.HeaderText = "קוד מוצר";
            productID.MinimumWidth = 6;
            productID.Name = "productID";
            productID.ReadOnly = true;
            productID.Visible = false;
            productID.Width = 125;
            // 
            // productName
            // 
            productName.HeaderText = "שם מוצר";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Visible = false;
            productName.Width = 125;
            // 
            // amount
            // 
            amount.HeaderText = "כמות";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Visible = false;
            amount.Width = 125;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 709);
            Controls.Add(dataGridViewOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(codeToAddProduct);
            Controls.Add(toChooseProduct);
            Controls.Add(toAddProduct);
            Controls.Add(backToMainForm);
            Margin = new Padding(1);
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierForm";
            Load += CashierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMainForm;
        private Button toAddProduct;
        private ComboBox toChooseProduct;
        private TextBox codeToAddProduct;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewOrder;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn amount;
    }
}