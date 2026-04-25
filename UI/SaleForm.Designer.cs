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
            backToMainForm = new Button();
            cmbReadSale = new ComboBox();
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(1897, 994);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(452, 69);
            backToMainForm.TabIndex = 2;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            // 
            // cmbReadSale
            // 
            cmbReadSale.FormattingEnabled = true;
            cmbReadSale.Location = new Point(66, 96);
            cmbReadSale.Name = "cmbReadSale";
            cmbReadSale.Size = new Size(813, 56);
            cmbReadSale.TabIndex = 3;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2425, 1111);
            Controls.Add(cmbReadSale);
            Controls.Add(backToMainForm);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backToMainForm;
        private ComboBox cmbReadSale;
    }
}