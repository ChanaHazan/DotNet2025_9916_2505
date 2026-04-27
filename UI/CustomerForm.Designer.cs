namespace UI
{
    partial class CustomerForm
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
            SuspendLayout();
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(2750, 1461);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(452, 69);
            backToLastForm.TabIndex = 5;
            backToLastForm.Text = "חזרה ";
            backToLastForm.UseVisualStyleBackColor = true;
            backToLastForm.Click += backToLastForm_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3280, 1589);
            Controls.Add(backToLastForm);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button backToLastForm;
    }
}