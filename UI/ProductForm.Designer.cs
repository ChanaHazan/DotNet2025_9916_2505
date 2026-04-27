namespace UI
{
    partial class ProductForm
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backToMainForm
            // 
            backToMainForm.Location = new Point(2756, 1352);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(452, 69);
            backToMainForm.TabIndex = 1;
            backToMainForm.Text = "חזרה לדף הראשי";
            backToMainForm.UseVisualStyleBackColor = true;
            backToMainForm.Click += backToMainForm_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(96, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(1803, 964);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(1732, 902);
            dataGridView1.TabIndex = 0;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3294, 1486);
            Controls.Add(panel1);
            Controls.Add(backToMainForm);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backToMainForm;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}