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
            tabControlCPS = new TabControl();
            tabPageProducts = new TabPage();
            ReadProduct = new Button();
            UpdateProduct = new Button();
            ReadAllProduct = new Button();
            DeleteProduct = new Button();
            CreateProduct = new Button();
            tabPageCustomer = new TabPage();
            readCustomer = new Button();
            updateCustomer = new Button();
            readAllCustomer = new Button();
            deleteCustomer = new Button();
            createCustomer = new Button();
            tabPageSale = new TabPage();
            readSale = new Button();
            updateSale = new Button();
            readAllSales = new Button();
            deleteSale = new Button();
            createSale = new Button();
            tabControlCPS.SuspendLayout();
            tabPageProducts.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            tabPageSale.SuspendLayout();
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(802, 422);
            backToMainForm.Margin = new Padding(1, 1, 1, 1);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(181, 29);
            backToMainForm.TabIndex = 0;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            backToMainForm.Click += backToMainForm_Click;
            // 
            // tabControlCPS
            // 
            tabControlCPS.Controls.Add(tabPageProducts);
            tabControlCPS.Controls.Add(tabPageCustomer);
            tabControlCPS.Controls.Add(tabPageSale);
            tabControlCPS.Location = new Point(41, 5);
            tabControlCPS.Margin = new Padding(1, 1, 1, 1);
            tabControlCPS.Name = "tabControlCPS";
            tabControlCPS.SelectedIndex = 0;
            tabControlCPS.Size = new Size(752, 460);
            tabControlCPS.TabIndex = 7;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(ReadProduct);
            tabPageProducts.Controls.Add(UpdateProduct);
            tabPageProducts.Controls.Add(ReadAllProduct);
            tabPageProducts.Controls.Add(DeleteProduct);
            tabPageProducts.Controls.Add(CreateProduct);
            tabPageProducts.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageProducts.Location = new Point(4, 29);
            tabPageProducts.Margin = new Padding(1, 1, 1, 1);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(1, 1, 1, 1);
            tabPageProducts.Size = new Size(744, 427);
            tabPageProducts.TabIndex = 0;
            tabPageProducts.Text = "מוצרים";
            tabPageProducts.UseVisualStyleBackColor = true;
            tabPageProducts.Click += tabPageProducts_Click;
            // 
            // ReadProduct
            // 
            ReadProduct.Location = new Point(118, 229);
            ReadProduct.Margin = new Padding(1, 1, 1, 1);
            ReadProduct.Name = "ReadProduct";
            ReadProduct.Size = new Size(155, 71);
            ReadProduct.TabIndex = 9;
            ReadProduct.Text = "לקרוא מוצר";
            ReadProduct.UseVisualStyleBackColor = true;
            ReadProduct.Click += ReadProduct_Click;
            // 
            // UpdateProduct
            // 
            UpdateProduct.Location = new Point(470, 127);
            UpdateProduct.Margin = new Padding(1, 1, 1, 1);
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Size = new Size(155, 71);
            UpdateProduct.TabIndex = 8;
            UpdateProduct.Text = "לעדכן מוצר";
            UpdateProduct.UseVisualStyleBackColor = true;
            UpdateProduct.Click += UpdateProduct_Click;
            // 
            // ReadAllProduct
            // 
            ReadAllProduct.Location = new Point(293, 229);
            ReadAllProduct.Margin = new Padding(1, 1, 1, 1);
            ReadAllProduct.Name = "ReadAllProduct";
            ReadAllProduct.Size = new Size(155, 71);
            ReadAllProduct.TabIndex = 7;
            ReadAllProduct.Text = "לקרוא את כל המוצרים";
            ReadAllProduct.UseVisualStyleBackColor = true;
            ReadAllProduct.Click += ReadAllProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(293, 127);
            DeleteProduct.Margin = new Padding(1, 1, 1, 1);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(155, 71);
            DeleteProduct.TabIndex = 6;
            DeleteProduct.Text = "למחוק מוצר";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // CreateProduct
            // 
            CreateProduct.Location = new Point(118, 127);
            CreateProduct.Margin = new Padding(1, 1, 1, 1);
            CreateProduct.Name = "CreateProduct";
            CreateProduct.Size = new Size(155, 71);
            CreateProduct.TabIndex = 5;
            CreateProduct.Text = "ליצור מוצר";
            CreateProduct.UseVisualStyleBackColor = true;
            CreateProduct.Click += CreateProduct_Click;
            // 
            // tabPageCustomer
            // 
            tabPageCustomer.Controls.Add(readCustomer);
            tabPageCustomer.Controls.Add(updateCustomer);
            tabPageCustomer.Controls.Add(readAllCustomer);
            tabPageCustomer.Controls.Add(deleteCustomer);
            tabPageCustomer.Controls.Add(createCustomer);
            tabPageCustomer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageCustomer.Location = new Point(4, 29);
            tabPageCustomer.Margin = new Padding(1, 1, 1, 1);
            tabPageCustomer.Name = "tabPageCustomer";
            tabPageCustomer.Padding = new Padding(1, 1, 1, 1);
            tabPageCustomer.Size = new Size(744, 427);
            tabPageCustomer.TabIndex = 1;
            tabPageCustomer.Text = "לקוחות";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // readCustomer
            // 
            readCustomer.Location = new Point(118, 229);
            readCustomer.Margin = new Padding(1, 1, 1, 1);
            readCustomer.Name = "readCustomer";
            readCustomer.Size = new Size(155, 67);
            readCustomer.TabIndex = 9;
            readCustomer.Text = "לקרוא לקוח";
            readCustomer.UseVisualStyleBackColor = true;
            readCustomer.Click += readCustomer_Click;
            // 
            // updateCustomer
            // 
            updateCustomer.Location = new Point(470, 130);
            updateCustomer.Margin = new Padding(1, 1, 1, 1);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Size = new Size(155, 69);
            updateCustomer.TabIndex = 8;
            updateCustomer.Text = "לעדכן לקוח";
            updateCustomer.UseVisualStyleBackColor = true;
            updateCustomer.Click += updateCustomer_Click;
            // 
            // readAllCustomer
            // 
            readAllCustomer.Location = new Point(293, 229);
            readAllCustomer.Margin = new Padding(1, 1, 1, 1);
            readAllCustomer.Name = "readAllCustomer";
            readAllCustomer.Size = new Size(155, 67);
            readAllCustomer.TabIndex = 7;
            readAllCustomer.Text = "לקרוא את כל הלקוחות";
            readAllCustomer.UseVisualStyleBackColor = true;
            readAllCustomer.Click += readAllCustomer_Click;
            // 
            // deleteCustomer
            // 
            deleteCustomer.Location = new Point(293, 130);
            deleteCustomer.Margin = new Padding(1, 1, 1, 1);
            deleteCustomer.Name = "deleteCustomer";
            deleteCustomer.Size = new Size(155, 69);
            deleteCustomer.TabIndex = 6;
            deleteCustomer.Text = "למחוק לקוח";
            deleteCustomer.UseVisualStyleBackColor = true;
            deleteCustomer.Click += deleteCustomer_Click;
            // 
            // createCustomer
            // 
            createCustomer.Location = new Point(118, 130);
            createCustomer.Margin = new Padding(1, 1, 1, 1);
            createCustomer.Name = "createCustomer";
            createCustomer.Size = new Size(155, 69);
            createCustomer.TabIndex = 5;
            createCustomer.Text = "ליצור לקוח";
            createCustomer.UseVisualStyleBackColor = true;
            createCustomer.Click += createCustomer_Click;
            // 
            // tabPageSale
            // 
            tabPageSale.Controls.Add(readSale);
            tabPageSale.Controls.Add(updateSale);
            tabPageSale.Controls.Add(readAllSales);
            tabPageSale.Controls.Add(deleteSale);
            tabPageSale.Controls.Add(createSale);
            tabPageSale.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageSale.Location = new Point(4, 29);
            tabPageSale.Margin = new Padding(1, 1, 1, 1);
            tabPageSale.Name = "tabPageSale";
            tabPageSale.Padding = new Padding(1, 1, 1, 1);
            tabPageSale.Size = new Size(744, 427);
            tabPageSale.TabIndex = 2;
            tabPageSale.Text = "מבצעים";
            tabPageSale.UseVisualStyleBackColor = true;
            // 
            // readSale
            // 
            readSale.Location = new Point(118, 229);
            readSale.Margin = new Padding(1, 1, 1, 1);
            readSale.Name = "readSale";
            readSale.Size = new Size(155, 70);
            readSale.TabIndex = 9;
            readSale.Text = "לקרוא מבצע";
            readSale.UseVisualStyleBackColor = true;
            readSale.Click += readSale_Click;
            // 
            // updateSale
            // 
            updateSale.Location = new Point(470, 138);
            updateSale.Margin = new Padding(1, 1, 1, 1);
            updateSale.Name = "updateSale";
            updateSale.Size = new Size(155, 70);
            updateSale.TabIndex = 8;
            updateSale.Text = "לעדכן מבצע";
            updateSale.UseVisualStyleBackColor = true;
            updateSale.Click += updateSale_Click;
            // 
            // readAllSales
            // 
            readAllSales.Location = new Point(293, 229);
            readAllSales.Margin = new Padding(1, 1, 1, 1);
            readAllSales.Name = "readAllSales";
            readAllSales.Size = new Size(155, 70);
            readAllSales.TabIndex = 7;
            readAllSales.Text = "לקרוא את כל המבצעים";
            readAllSales.UseVisualStyleBackColor = true;
            readAllSales.Click += readAllSales_Click;
            // 
            // deleteSale
            // 
            deleteSale.Location = new Point(293, 138);
            deleteSale.Margin = new Padding(1, 1, 1, 1);
            deleteSale.Name = "deleteSale";
            deleteSale.Size = new Size(155, 70);
            deleteSale.TabIndex = 6;
            deleteSale.Text = "למחוק מבצע";
            deleteSale.UseVisualStyleBackColor = true;
            deleteSale.Click += deleteSale_Click;
            // 
            // createSale
            // 
            createSale.Location = new Point(118, 138);
            createSale.Margin = new Padding(1, 1, 1, 1);
            createSale.Name = "createSale";
            createSale.Size = new Size(155, 70);
            createSale.TabIndex = 5;
            createSale.Text = "ליצור מבצע";
            createSale.UseVisualStyleBackColor = true;
            createSale.Click += createSale_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 440);
            Controls.Add(tabControlCPS);
            Controls.Add(backToMainForm);
            Margin = new Padding(1, 1, 1, 1);
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            tabControlCPS.ResumeLayout(false);
            tabPageProducts.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            tabPageSale.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button backToMainForm;
        private Button readCustomer;
        private Button updateCustomer;
        private Button readAllCustomer;
        private Button deleteCustomer;
        private Button createCustomer;
        private Button readSale;
        private Button updateSale;
        private Button readAllSales;
        private Button deleteSale;
        private Button createSale;
        private TabControl tabControlCPS;
        private TabPage tabPageProducts;
        private TabPage tabPageCustomer;
        private TabPage tabPageSale;
        private Button ReadProduct;
        private Button UpdateProduct;
        private Button ReadAllProduct;
        private Button DeleteProduct;
        private Button CreateProduct;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}