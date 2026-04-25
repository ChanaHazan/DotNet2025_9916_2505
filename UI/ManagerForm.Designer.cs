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
            Read = new Button();
            Update = new Button();
            ReadAll = new Button();
            Delete = new Button();
            Create = new Button();
            panelCustomer = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panelSale = new Panel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
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
            panelProduct.Controls.Add(Read);
            panelProduct.Controls.Add(Update);
            panelProduct.Controls.Add(ReadAll);
            panelProduct.Controls.Add(Delete);
            panelProduct.Controls.Add(Create);
            panelProduct.Location = new Point(51, 222);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1842, 834);
            panelProduct.TabIndex = 4;
            panelProduct.Visible = false;
            // 
            // Read
            // 
            Read.Location = new Point(36, 255);
            Read.Name = "Read";
            Read.Size = new Size(388, 146);
            Read.TabIndex = 4;
            Read.Text = "לקרוא מוצר";
            Read.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.Location = new Point(917, 36);
            Update.Name = "Update";
            Update.Size = new Size(388, 146);
            Update.TabIndex = 3;
            Update.Text = "לעדכן מוצר";
            Update.UseVisualStyleBackColor = true;
            // 
            // ReadAll
            // 
            ReadAll.Location = new Point(475, 255);
            ReadAll.Name = "ReadAll";
            ReadAll.Size = new Size(388, 146);
            ReadAll.TabIndex = 2;
            ReadAll.Text = "לקרוא את כל המוצרים";
            ReadAll.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(475, 36);
            Delete.Name = "Delete";
            Delete.Size = new Size(388, 146);
            Delete.TabIndex = 1;
            Delete.Text = "למחוק מוצר";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            Create.Location = new Point(36, 36);
            Create.Name = "Create";
            Create.Size = new Size(388, 146);
            Create.TabIndex = 0;
            Create.Text = "ליצור מוצר";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // panelCustomer
            // 
            panelCustomer.Controls.Add(button1);
            panelCustomer.Controls.Add(button2);
            panelCustomer.Controls.Add(button3);
            panelCustomer.Controls.Add(button4);
            panelCustomer.Controls.Add(button5);
            panelCustomer.Location = new Point(920, 219);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(1842, 834);
            panelCustomer.TabIndex = 5;
            panelCustomer.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(36, 255);
            button1.Name = "button1";
            button1.Size = new Size(388, 146);
            button1.TabIndex = 4;
            button1.Text = "לקרוא לקוח";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(917, 36);
            button2.Name = "button2";
            button2.Size = new Size(388, 146);
            button2.TabIndex = 3;
            button2.Text = "לעדכן לקוח";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(475, 255);
            button3.Name = "button3";
            button3.Size = new Size(388, 146);
            button3.TabIndex = 2;
            button3.Text = "לקרוא את כל הלקוחות";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(475, 36);
            button4.Name = "button4";
            button4.Size = new Size(388, 146);
            button4.TabIndex = 1;
            button4.Text = "למחוק לקוח";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 36);
            button5.Name = "button5";
            button5.Size = new Size(388, 146);
            button5.TabIndex = 0;
            button5.Text = "ליצור לקוח";
            button5.UseVisualStyleBackColor = true;
            // 
            // panelSale
            // 
            panelSale.Controls.Add(button6);
            panelSale.Controls.Add(button7);
            panelSale.Controls.Add(button8);
            panelSale.Controls.Add(button9);
            panelSale.Controls.Add(button10);
            panelSale.Location = new Point(449, 222);
            panelSale.Name = "panelSale";
            panelSale.Size = new Size(1842, 834);
            panelSale.TabIndex = 6;
            panelSale.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(36, 255);
            button6.Name = "button6";
            button6.Size = new Size(388, 146);
            button6.TabIndex = 4;
            button6.Text = "לקרוא מבצע";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(917, 36);
            button7.Name = "button7";
            button7.Size = new Size(388, 146);
            button7.TabIndex = 3;
            button7.Text = "לעדכן מבצע";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(475, 255);
            button8.Name = "button8";
            button8.Size = new Size(388, 146);
            button8.TabIndex = 2;
            button8.Text = "לקרוא את כל המבצעים";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(475, 36);
            button9.Name = "button9";
            button9.Size = new Size(388, 146);
            button9.TabIndex = 1;
            button9.Text = "למחוק מבצע";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(36, 36);
            button10.Name = "button10";
            button10.Size = new Size(388, 146);
            button10.TabIndex = 0;
            button10.Text = "ליצור מבצע";
            button10.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2498, 1118);
            Controls.Add(panelCustomer);
            Controls.Add(panelSale);
            Controls.Add(panelProduct);
            Controls.Add(sales);
            Controls.Add(customer);
            Controls.Add(products);
            Controls.Add(backToMainForm);
            Name = "ManagerForm";
            Text = "ManagerForm";
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
        private Button Create;
        private Button Read;
        private Button Update;
        private Button ReadAll;
        private Button Delete;
        private Panel panelCustomer;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panelSale;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}