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
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(1924, 911);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(452, 69);
            backToMainForm.TabIndex = 1;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            backToMainForm.Click += backToMainForm_Click;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2464, 1065);
            Controls.Add(backToMainForm);
            Name = "CashierForm";
            Text = "CashierForm";
            Load += CashierForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button backToMainForm;
    }
}