namespace Library
{
    partial class FormOrders
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
            dataGridViewOrders = new DataGridView();
            panelTop = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonExit = new Button();
            panel2 = new Panel();
            textBoxSearch = new TextBox();
            Поиск = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxSort = new ComboBox();
            comboBoxStatusFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.ColumnHeadersVisible = false;
            dataGridViewOrders.Dock = DockStyle.Bottom;
            dataGridViewOrders.Location = new Point(0, 143);
            dataGridViewOrders.Margin = new Padding(4);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(984, 518);
            dataGridViewOrders.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(buttonExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(13);
            panelTop.Size = new Size(984, 76);
            panelTop.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(74, 111, 165);
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(399, 13);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(193, 50);
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
            buttonEdit.Location = new Point(206, 13);
            buttonEdit.Margin = new Padding(4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(193, 50);
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
            buttonAdd.Location = new Point(13, 13);
            buttonAdd.Margin = new Padding(4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(193, 50);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Visible = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(74, 111, 165);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(778, 13);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(193, 50);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(Поиск);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBoxSort);
            panel2.Controls.Add(comboBoxStatusFilter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 64);
            panel2.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(719, 34);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(235, 26);
            textBoxSearch.TabIndex = 5;
            // 
            // Поиск
            // 
            Поиск.Location = new Point(719, 7);
            Поиск.Name = "Поиск";
            Поиск.Size = new Size(235, 24);
            Поиск.TabIndex = 4;
            Поиск.Text = "Поиск";
            Поиск.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(383, 7);
            label2.Name = "label2";
            label2.Size = new Size(188, 24);
            label2.TabIndex = 3;
            label2.Text = "Сортировка";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(188, 24);
            label1.TabIndex = 2;
            label1.Text = "Фильтрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(383, 34);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(188, 27);
            comboBoxSort.TabIndex = 1;
            // 
            // comboBoxStatusFilter
            // 
            comboBoxStatusFilter.FormattingEnabled = true;
            comboBoxStatusFilter.Location = new Point(10, 34);
            comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            comboBoxStatusFilter.Size = new Size(188, 27);
            comboBoxStatusFilter.TabIndex = 0;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel2);
            Controls.Add(dataGridViewOrders);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private Panel panelTop;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonExit;
        private Panel panel2;
        private TextBox textBoxSearch;
        private Label Поиск;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxSort;
        private ComboBox comboBoxStatusFilter;
    }
}