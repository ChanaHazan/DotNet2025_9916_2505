namespace UI
{
    partial class ManagerForm
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
            products = new Button();
            customer = new Button();
            sales = new Button();
            panelProduct = new Panel();
            ReadProduct = new Button();
            UpdateProduct = new Button();
            ReadAllProduct = new Button();
            DeleteProduct = new Button();
            CreateProduct = new Button();
            panelCustomer = new Panel();
            readCustomer = new Button();
            updateCustomer = new Button();
            readAllCustomer = new Button();
            deleteCustomer = new Button();
            createCustomer = new Button();
            panelSale = new Panel();
            readSale = new Button();
            updateSale = new Button();
            readAllSales = new Button();
            deleteSale = new Button();
            createSale = new Button();
            panelProduct.SuspendLayout();
            panelCustomer.SuspendLayout();
            panelSale.SuspendLayout();
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(2006, 1013);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(452, 69);
            backToMainForm.TabIndex = 0;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            backToMainForm.Click += backToMainForm_Click;
            // 
            // products
            // 
            products.Location = new Point(51, 54);
            products.Name = "products";
            products.Size = new Size(449, 124);
            products.TabIndex = 1;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customer
            // 
            customer.Location = new Point(562, 54);
            customer.Name = "customer";
            customer.Size = new Size(456, 128);
            customer.TabIndex = 2;
            customer.Text = "לקוחות";
            customer.UseVisualStyleBackColor = true;
            customer.Click += customer_Click;
            // 
            // sales
            // 
            sales.Location = new Point(1074, 54);
            sales.Name = "sales";
            sales.Size = new Size(479, 124);
            sales.TabIndex = 3;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // panelProduct
            // 
            panelProduct.Controls.Add(ReadProduct);
            panelProduct.Controls.Add(UpdateProduct);
            panelProduct.Controls.Add(ReadAllProduct);
            panelProduct.Controls.Add(DeleteProduct);
            panelProduct.Controls.Add(CreateProduct);
            panelProduct.Location = new Point(51, 222);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1842, 834);
            panelProduct.TabIndex = 4;
            panelProduct.Visible = false;
            // 
            // ReadProduct
            // 
            ReadProduct.Location = new Point(36, 255);
            ReadProduct.Name = "ReadProduct";
            ReadProduct.Size = new Size(388, 146);
            ReadProduct.TabIndex = 4;
            ReadProduct.Text = "לקרוא מוצר";
            ReadProduct.UseVisualStyleBackColor = true;
            ReadProduct.Click += ReadProduct_Click;
            // 
            // UpdateProduct
            // 
            UpdateProduct.Location = new Point(917, 36);
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Size = new Size(388, 146);
            UpdateProduct.TabIndex = 3;
            UpdateProduct.Text = "לעדכן מוצר";
            UpdateProduct.UseVisualStyleBackColor = true;
            UpdateProduct.Click += UpdateProduct_Click;
            // 
            // ReadAllProduct
            // 
            ReadAllProduct.Location = new Point(475, 255);
            ReadAllProduct.Name = "ReadAllProduct";
            ReadAllProduct.Size = new Size(388, 146);
            ReadAllProduct.TabIndex = 2;
            ReadAllProduct.Text = "לקרוא את כל המוצרים";
            ReadAllProduct.UseVisualStyleBackColor = true;
            ReadAllProduct.Click += ReadAllProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(475, 36);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(388, 146);
            DeleteProduct.TabIndex = 1;
            DeleteProduct.Text = "למחוק מוצר";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // CreateProduct
            // 
            CreateProduct.Location = new Point(36, 36);
            CreateProduct.Name = "CreateProduct";
            CreateProduct.Size = new Size(388, 146);
            CreateProduct.TabIndex = 0;
            CreateProduct.Text = "ליצור מוצר";
            CreateProduct.UseVisualStyleBackColor = true;
            CreateProduct.Click += CreateProduct_Click;
            // 
            // panelCustomer
            // 
            panelCustomer.Controls.Add(readCustomer);
            panelCustomer.Controls.Add(updateCustomer);
            panelCustomer.Controls.Add(readAllCustomer);
            panelCustomer.Controls.Add(deleteCustomer);
            panelCustomer.Controls.Add(createCustomer);
            panelCustomer.Location = new Point(312, 20);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(1842, 834);
            panelCustomer.TabIndex = 5;
            panelCustomer.Visible = false;
            panelCustomer.Paint += panelCustomer_Paint;
            // 
            // readCustomer
            // 
            readCustomer.Location = new Point(36, 255);
            readCustomer.Name = "readCustomer";
            readCustomer.Size = new Size(388, 146);
            readCustomer.TabIndex = 4;
            readCustomer.Text = "לקרוא לקוח";
            readCustomer.UseVisualStyleBackColor = true;
            readCustomer.Click += readCustomer_Click;
            // 
            // updateCustomer
            // 
            updateCustomer.Location = new Point(917, 36);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Size = new Size(388, 146);
            updateCustomer.TabIndex = 3;
            updateCustomer.Text = "לעדכן לקוח";
            updateCustomer.UseVisualStyleBackColor = true;
            updateCustomer.Click += updateCustomer_Click;
            // 
            // readAllCustomer
            // 
            readAllCustomer.Location = new Point(475, 255);
            readAllCustomer.Name = "readAllCustomer";
            readAllCustomer.Size = new Size(388, 146);
            readAllCustomer.TabIndex = 2;
            readAllCustomer.Text = "לקרוא את כל הלקוחות";
            readAllCustomer.UseVisualStyleBackColor = true;
            readAllCustomer.Click += readAllCustomer_Click;
            // 
            // deleteCustomer
            // 
            deleteCustomer.Location = new Point(475, 36);
            deleteCustomer.Name = "deleteCustomer";
            deleteCustomer.Size = new Size(388, 146);
            deleteCustomer.TabIndex = 1;
            deleteCustomer.Text = "למחוק לקוח";
            deleteCustomer.UseVisualStyleBackColor = true;
            deleteCustomer.Click += deleteCustomer_Click;
            // 
            // createCustomer
            // 
            createCustomer.Location = new Point(36, 36);
            createCustomer.Name = "createCustomer";
            createCustomer.Size = new Size(388, 146);
            createCustomer.TabIndex = 0;
            createCustomer.Text = "ליצור לקוח";
            createCustomer.UseVisualStyleBackColor = true;
            createCustomer.Click += createCustomer_Click;
            // 
            // panelSale
            // 
            panelSale.Controls.Add(readSale);
            panelSale.Controls.Add(panelCustomer);
            panelSale.Controls.Add(updateSale);
            panelSale.Controls.Add(readAllSales);
            panelSale.Controls.Add(deleteSale);
            panelSale.Controls.Add(createSale);
            panelSale.Location = new Point(341, 199);
            panelSale.Name = "panelSale";
            panelSale.Size = new Size(1842, 834);
            panelSale.TabIndex = 6;
            panelSale.Visible = false;
            // 
            // readSale
            // 
            readSale.Location = new Point(36, 255);
            readSale.Name = "readSale";
            readSale.Size = new Size(388, 146);
            readSale.TabIndex = 4;
            readSale.Text = "לקרוא מבצע";
            readSale.UseVisualStyleBackColor = true;
            readSale.Click += readSale_Click;
            // 
            // updateSale
            // 
            updateSale.Location = new Point(917, 36);
            updateSale.Name = "updateSale";
            updateSale.Size = new Size(388, 146);
            updateSale.TabIndex = 3;
            updateSale.Text = "לעדכן מבצע";
            updateSale.UseVisualStyleBackColor = true;
            updateSale.Click += updateSale_Click;
            // 
            // readAllSales
            // 
            readAllSales.Location = new Point(475, 255);
            readAllSales.Name = "readAllSales";
            readAllSales.Size = new Size(388, 146);
            readAllSales.TabIndex = 2;
            readAllSales.Text = "לקרוא את כל המבצעים";
            readAllSales.UseVisualStyleBackColor = true;
            readAllSales.Click += readAllSales_Click;
            // 
            // deleteSale
            // 
            deleteSale.Location = new Point(475, 36);
            deleteSale.Name = "deleteSale";
            deleteSale.Size = new Size(388, 146);
            deleteSale.TabIndex = 1;
            deleteSale.Text = "למחוק מבצע";
            deleteSale.UseVisualStyleBackColor = true;
            deleteSale.Click += deleteSale_Click;
            // 
            // createSale
            // 
            createSale.Location = new Point(36, 36);
            createSale.Name = "createSale";
            createSale.Size = new Size(388, 146);
            createSale.TabIndex = 0;
            createSale.Text = "ליצור מבצע";
            createSale.UseVisualStyleBackColor = true;
            createSale.Click += createSale_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2498, 1118);
            Controls.Add(panelSale);
            Controls.Add(panelProduct);
            Controls.Add(sales);
            Controls.Add(customer);
            Controls.Add(products);
            Controls.Add(backToMainForm);
            Name = "ManagerForm";
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            panelProduct.ResumeLayout(false);
            panelCustomer.ResumeLayout(false);
            panelSale.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button backToMainForm;
        private Button products;
        private Button customer;
        private Button sales;
        private Panel panelProduct;
        private Button CreateProduct;
        private Button ReadProduct;
        private Button UpdateProduct;
        private Button ReadAllProduct;
        private Button DeleteProduct;
        private Panel panelCustomer;
        private Button readCustomer;
        private Button updateCustomer;
        private Button readAllCustomer;
        private Button deleteCustomer;
        private Button createCustomer;
        private Panel panelSale;
        private Button readSale;
        private Button updateSale;
        private Button readAllSales;
        private Button deleteSale;
        private Button createSale;
    }
}