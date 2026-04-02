namespace Library
{
    partial class FormBooks
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
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            labelName = new Label();
            buttonLoans = new Button();
            buttonExit = new Button();
            dataGridViewBooks = new DataGridView();
            panel2 = new Panel();
            textBoxSearch = new TextBox();
            Поиск = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxSort = new ComboBox();
            comboBoxFilterPublisher = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(buttonLoans);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1011, 60);
            panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(74, 111, 165);
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(284, 10);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(137, 40);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(74, 111, 165);
            buttonEdit.Dock = DockStyle.Left;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(147, 10);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(137, 40);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Редактированить";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Visible = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(74, 111, 165);
            buttonAdd.Dock = DockStyle.Left;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(10, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(137, 40);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Visible = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(665, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(36, 17);
            labelName.TabIndex = 8;
            labelName.Text = "Имя";
            // 
            // buttonLoans
            // 
            buttonLoans.BackColor = Color.FromArgb(74, 111, 165);
            buttonLoans.Dock = DockStyle.Right;
            buttonLoans.FlatStyle = FlatStyle.Flat;
            buttonLoans.ForeColor = Color.White;
            buttonLoans.Location = new Point(701, 10);
            buttonLoans.Name = "buttonLoans";
            buttonLoans.Size = new Size(150, 40);
            buttonLoans.TabIndex = 7;
            buttonLoans.Text = "Выдача книг";
            buttonLoans.UseVisualStyleBackColor = false;
            buttonLoans.Visible = false;
            buttonLoans.Click += buttonLoans_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(74, 111, 165);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(851, 10);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 40);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.ColumnHeadersVisible = false;
            dataGridViewBooks.Dock = DockStyle.Bottom;
            dataGridViewBooks.Location = new Point(10, 140);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(1011, 511);
            dataGridViewBooks.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(Поиск);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBoxSort);
            panel2.Controls.Add(comboBoxFilterPublisher);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 64);
            panel2.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(742, 32);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(235, 26);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // Поиск
            // 
            Поиск.Location = new Point(742, 5);
            Поиск.Name = "Поиск";
            Поиск.Size = new Size(235, 24);
            Поиск.TabIndex = 4;
            Поиск.Text = "Поиск";
            Поиск.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(406, 5);
            label2.Name = "label2";
            label2.Size = new Size(188, 24);
            label2.TabIndex = 3;
            label2.Text = "Сортировка";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(33, 5);
            label1.Name = "label1";
            label1.Size = new Size(188, 24);
            label1.TabIndex = 2;
            label1.Text = "Фильтрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(406, 32);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(188, 27);
            comboBoxSort.TabIndex = 1;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // comboBoxFilterPublisher
            // 
            comboBoxFilterPublisher.FormattingEnabled = true;
            comboBoxFilterPublisher.Location = new Point(33, 32);
            comboBoxFilterPublisher.Name = "comboBoxFilterPublisher";
            comboBoxFilterPublisher.Size = new Size(188, 27);
            comboBoxFilterPublisher.TabIndex = 0;
            comboBoxFilterPublisher.SelectedIndexChanged += comboBoxFilterPublisher_SelectedIndexChanged;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 661);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBooks);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBooks";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список книг";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewBooks;
        private Button buttonExit;
        private Label labelName;
        private Button buttonLoans;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
        private Panel panel2;
        private ComboBox comboBoxFilterPublisher;
        private TextBox textBoxSearch;
        private Label Поиск;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxSort;
    }
}