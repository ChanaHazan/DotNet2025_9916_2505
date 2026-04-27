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
            paneDelate = new Panel();
            IdToDelate = new TextBox();
            ToDelateCustomer = new Button();
            label1 = new Label();
            paneDelate.SuspendLayout();
            SuspendLayout();
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(1100, 609);
            backToLastForm.Margin = new Padding(1, 1, 1, 1);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(181, 29);
            backToLastForm.TabIndex = 5;
            backToLastForm.Text = "חזרה ";
            backToLastForm.UseVisualStyleBackColor = true;
            backToLastForm.Click += backToLastForm_Click;
            // 
            // paneDelate
            // 
            paneDelate.Controls.Add(IdToDelate);
            paneDelate.Controls.Add(ToDelateCustomer);
            paneDelate.Controls.Add(label1);
            paneDelate.Location = new Point(53, 27);
            paneDelate.Name = "paneDelate";
            paneDelate.Size = new Size(664, 386);
            paneDelate.TabIndex = 11;
            // 
            // IdToDelate
            // 
            IdToDelate.Location = new Point(108, 151);
            IdToDelate.Name = "IdToDelate";
            IdToDelate.Size = new Size(125, 27);
            IdToDelate.TabIndex = 2;
            // 
            // ToDelateCustomer
            // 
            ToDelateCustomer.Location = new Point(317, 149);
            ToDelateCustomer.Name = "ToDelateCustomer";
            ToDelateCustomer.Size = new Size(146, 29);
            ToDelateCustomer.TabIndex = 1;
            ToDelateCustomer.Text = "למחיקת לקוח";
            ToDelateCustomer.UseVisualStyleBackColor = true;
            ToDelateCustomer.Click += ToDelateCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 117);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס מס מזהה ";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 440);
            Controls.Add(paneDelate);
            Controls.Add(backToLastForm);
            Margin = new Padding(1, 1, 1, 1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            paneDelate.ResumeLayout(false);
            paneDelate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button backToLastForm;
        private Panel paneDelate;
        private TextBox IdToDelate;
        private Button ToDelateCustomer;
        private Label label1;
    }
}