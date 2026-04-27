namespace UI
{
    partial class MainForm
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
            manager = new Button();
            cashier = new Button();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Location = new Point(137, 63);
            manager.Margin = new Padding(1, 1, 1, 1);
            manager.Name = "manager";
            manager.Size = new Size(342, 177);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // cashier
            // 
            cashier.Location = new Point(137, 262);
            cashier.Margin = new Padding(1, 1, 1, 1);
            cashier.Name = "cashier";
            cashier.Size = new Size(342, 177);
            cashier.TabIndex = 1;
            cashier.Text = "קופאי";
            cashier.UseVisualStyleBackColor = true;
            cashier.Click += cashier_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 459);
            Controls.Add(cashier);
            Controls.Add(manager);
            Margin = new Padding(1, 1, 1, 1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button cashier;
    }
}