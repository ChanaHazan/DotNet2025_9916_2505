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
            DeleteColumn = new DataGridViewButtonColumn();
            productID = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            MinusColumn = new DataGridViewButtonColumn();
            PlusColumn = new DataGridViewButtonColumn();
            SalesColumn = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblFinalSum = new ToolStripStatusLabel();
            btnDoOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(2208, 1565);
            backToMainForm.Margin = new Padding(2);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(452, 70);
            backToMainForm.TabIndex = 1;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            backToMainForm.Click += backToMainForm_Click;
            // 
            // toAddProduct
            // 
            toAddProduct.Location = new Point(2413, 525);
            toAddProduct.Margin = new Padding(8, 7, 8, 7);
            toAddProduct.Name = "toAddProduct";
            toAddProduct.Size = new Size(368, 70);
            toAddProduct.TabIndex = 3;
            toAddProduct.Text = "להוספת מוצר";
            toAddProduct.UseVisualStyleBackColor = true;
            toAddProduct.Click += toAddProduct_Click;
            // 
            // toChooseProduct
            // 
            toChooseProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toChooseProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            toChooseProduct.FormattingEnabled = true;
            toChooseProduct.Location = new Point(2565, 374);
            toChooseProduct.Margin = new Padding(8, 7, 8, 7);
            toChooseProduct.Name = "toChooseProduct";
            toChooseProduct.Size = new Size(372, 56);
            toChooseProduct.TabIndex = 4;
            // 
            // codeToAddProduct
            // 
            codeToAddProduct.Location = new Point(2205, 375);
            codeToAddProduct.Margin = new Padding(8, 7, 8, 7);
            codeToAddProduct.Name = "codeToAddProduct";
            codeToAddProduct.Size = new Size(306, 55);
            codeToAddProduct.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2247, 258);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 48);
            label1.TabIndex = 6;
            label1.Text = "הכנס קוד מוצר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2631, 258);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 48);
            label2.TabIndex = 7;
            label2.Text = "לבחירת מוצר";
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Columns.AddRange(new DataGridViewColumn[] { DeleteColumn, productID, productName, amount, MinusColumn, PlusColumn, SalesColumn });
            dataGridViewOrder.Location = new Point(30, 110);
            dataGridViewOrder.Margin = new Padding(8, 7, 8, 7);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.Size = new Size(2124, 978);
            dataGridViewOrder.TabIndex = 8;
            dataGridViewOrder.CellContentClick += dataGridViewOrder_CellContentClick;
            dataGridViewOrder.CellFormatting += dataGridViewOrder_CellFormatting;
            dataGridViewOrder.CellValidating += dataGridViewOrder_CellValidating;
            dataGridViewOrder.CellValueChanged += dataGridViewOrder_CellValueChanged;
            dataGridViewOrder.CurrentCellDirtyStateChanged += dataGridViewOrder_CurrentCellDirtyStateChanged;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "";
            DeleteColumn.MinimumWidth = 15;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Text = "X";
            DeleteColumn.UseColumnTextForButtonValue = true;
            DeleteColumn.Width = 85;
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
            amount.Visible = false;
            amount.Width = 125;
            // 
            // MinusColumn
            // 
            MinusColumn.HeaderText = "";
            MinusColumn.MinimumWidth = 15;
            MinusColumn.Name = "MinusColumn";
            MinusColumn.Text = "-";
            MinusColumn.UseColumnTextForButtonValue = true;
            MinusColumn.Width = 80;
            // 
            // PlusColumn
            // 
            PlusColumn.HeaderText = "";
            PlusColumn.MinimumWidth = 15;
            PlusColumn.Name = "PlusColumn";
            PlusColumn.Text = "+";
            PlusColumn.UseColumnTextForButtonValue = true;
            PlusColumn.Width = 80;
            // 
            // SalesColumn
            // 
            SalesColumn.DataPropertyName = "SalesList";
            SalesColumn.HeaderText = "sales";
            SalesColumn.MinimumWidth = 15;
            SalesColumn.Name = "SalesColumn";
            SalesColumn.Width = 300;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(48, 48);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblFinalSum });
            statusStrip1.Location = new Point(0, 1497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(0, 0, 15, 0);
            statusStrip1.Size = new Size(3009, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblFinalSum
            // 
            lblFinalSum.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalSum.Name = "lblFinalSum";
            lblFinalSum.Size = new Size(0, 0);
            // 
            // btnDoOrder
            // 
            btnDoOrder.Location = new Point(2293, 757);
            btnDoOrder.Margin = new Padding(8, 7, 8, 7);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(605, 202);
            btnDoOrder.TabIndex = 10;
            btnDoOrder.Text = "לביצוע הזמנה";
            btnDoOrder.UseVisualStyleBackColor = true;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3009, 1519);
            Controls.Add(btnDoOrder);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(codeToAddProduct);
            Controls.Add(toChooseProduct);
            Controls.Add(toAddProduct);
            Controls.Add(backToMainForm);
            Margin = new Padding(2);
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierForm";
            Load += CashierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblFinalSum;
        private Button btnDoOrder;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewButtonColumn MinusColumn;
        private DataGridViewButtonColumn PlusColumn;
        private DataGridViewTextBoxColumn SalesColumn;
    }
}