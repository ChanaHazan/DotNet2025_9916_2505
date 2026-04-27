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
            panelRead = new Panel();
            dataGridViewRead = new DataGridView();
            buttonSearch = new Button();
            textBoxEnterName = new TextBox();
            labelEnterProductName = new Label();
            panelReadAll = new Panel();
            dataGridViewReadAll = new DataGridView();
            backToLastForm = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxProductId = new ComboBox();
            textBoxPrice = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            btnAdd = new Button();
            checkBoxToAll = new CheckBox();
            panelCreate = new Panel();
            label6 = new Label();
            label1 = new Label();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).BeginInit();
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            panelCreate.SuspendLayout();
            SuspendLayout();
            // 
            // panelRead
            // 
            panelRead.Controls.Add(dataGridViewRead);
            panelRead.Controls.Add(buttonSearch);
            panelRead.Controls.Add(textBoxEnterName);
            panelRead.Controls.Add(labelEnterProductName);
            panelRead.Location = new Point(0, 0);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(1320, 1267);
            panelRead.TabIndex = 7;
            panelRead.Visible = false;
            // 
            // dataGridViewRead
            // 
            dataGridViewRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRead.Location = new Point(24, 419);
            dataGridViewRead.Name = "dataGridViewRead";
            dataGridViewRead.RowHeadersWidth = 123;
            dataGridViewRead.Size = new Size(1265, 450);
            dataGridViewRead.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(95, 296);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(270, 69);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "חפש מוצר זה";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxEnterName
            // 
            textBoxEnterName.Location = new Point(424, 306);
            textBoxEnterName.Name = "textBoxEnterName";
            textBoxEnterName.Size = new Size(463, 55);
            textBoxEnterName.TabIndex = 1;
            // 
            // labelEnterProductName
            // 
            labelEnterProductName.AutoSize = true;
            labelEnterProductName.Location = new Point(939, 309);
            labelEnterProductName.Name = "labelEnterProductName";
            labelEnterProductName.Size = new Size(250, 48);
            labelEnterProductName.TabIndex = 0;
            labelEnterProductName.Text = "הכנס שם מוצר";
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(dataGridViewReadAll);
            panelReadAll.Location = new Point(92, 190);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(1803, 1275);
            panelReadAll.TabIndex = 10;
            panelReadAll.Visible = false;
            // 
            // dataGridViewReadAll
            // 
            dataGridViewReadAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAll.Location = new Point(23, 31);
            dataGridViewReadAll.Name = "dataGridViewReadAll";
            dataGridViewReadAll.RowHeadersWidth = 123;
            dataGridViewReadAll.Size = new Size(1748, 1201);
            dataGridViewReadAll.TabIndex = 0;
            // 
            // backToLastForm
            // 
            backToLastForm.Location = new Point(2663, 1499);
            backToLastForm.Name = "backToLastForm";
            backToLastForm.Size = new Size(452, 69);
            backToLastForm.TabIndex = 9;
            backToLastForm.Text = "חזרה ";
            backToLastForm.UseVisualStyleBackColor = true;
            backToLastForm.Click += backToLastForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1171, 605);
            label2.Name = "label2";
            label2.Size = new Size(0, 48);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1320, 355);
            label3.Name = "label3";
            label3.Size = new Size(189, 48);
            label3.TabIndex = 2;
            label3.Text = "מזהה מוצר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1319, 434);
            label4.Name = "label4";
            label4.Size = new Size(196, 48);
            label4.TabIndex = 3;
            label4.Text = "מחיר מבצע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1320, 519);
            label5.Name = "label5";
            label5.Size = new Size(215, 48);
            label5.TabIndex = 4;
            label5.Text = "כמות נדרשת";
            // 
            // comboBoxProductId
            // 
            comboBoxProductId.FormattingEnabled = true;
            comboBoxProductId.Items.AddRange(new object[] { "Meats", "Poultry", "Spices", "Frozens", "Fish" });
            comboBoxProductId.Location = new Point(918, 355);
            comboBoxProductId.Name = "comboBoxProductId";
            comboBoxProductId.Size = new Size(363, 56);
            comboBoxProductId.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(978, 431);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(300, 55);
            textBoxPrice.TabIndex = 7;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(918, 517);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(360, 55);
            numericUpDownQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1070, 886);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "הוסף מבצע";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // checkBoxToAll
            // 
            checkBoxToAll.AutoSize = true;
            checkBoxToAll.Location = new Point(987, 605);
            checkBoxToAll.Name = "checkBoxToAll";
            checkBoxToAll.Size = new Size(477, 52);
            checkBoxToAll.TabIndex = 10;
            checkBoxToAll.Text = "האם המבצע לכל הלקוחות";
            checkBoxToAll.UseVisualStyleBackColor = true;
            // 
            // panelCreate
            // 
            panelCreate.Controls.Add(label6);
            panelCreate.Controls.Add(label1);
            panelCreate.Controls.Add(dateEnd);
            panelCreate.Controls.Add(dateStart);
            panelCreate.Controls.Add(checkBoxToAll);
            panelCreate.Controls.Add(btnAdd);
            panelCreate.Controls.Add(numericUpDownQuantity);
            panelCreate.Controls.Add(textBoxPrice);
            panelCreate.Controls.Add(comboBoxProductId);
            panelCreate.Controls.Add(label5);
            panelCreate.Controls.Add(label4);
            panelCreate.Controls.Add(label3);
            panelCreate.Controls.Add(label2);
            panelCreate.Location = new Point(640, 45);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(1731, 1437);
            panelCreate.TabIndex = 11;
            panelCreate.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1353, 697);
            label6.Name = "label6";
            label6.Size = new Size(246, 48);
            label6.TabIndex = 14;
            label6.Text = "תאריך התחלה";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1353, 790);
            label1.Name = "label1";
            label1.Size = new Size(198, 48);
            label1.TabIndex = 13;
            label1.Text = "תאריך סיום";
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(678, 790);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(600, 55);
            dateEnd.TabIndex = 12;
            // 
            // dateStart
            // 
            dateStart.Location = new Point(681, 692);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(600, 55);
            dateStart.TabIndex = 11;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3167, 1610);
            Controls.Add(panelRead);
            Controls.Add(panelCreate);
            Controls.Add(panelReadAll);
            Controls.Add(backToLastForm);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRead).EndInit();
            panelReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRead;
        private DataGridView dataGridViewRead;
        private Button buttonSearch;
        private TextBox textBoxEnterName;
        private Label labelEnterProductName;
        private Panel panelReadAll;
        private DataGridView dataGridViewReadAll;
        private Button backToLastForm;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxProductId;
        private TextBox textBoxPrice;
        private NumericUpDown numericUpDownQuantity;
        private Button btnAdd;
        private CheckBox checkBoxToAll;
        private Panel panelCreate;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label label6;
        private Label label1;
    }
}