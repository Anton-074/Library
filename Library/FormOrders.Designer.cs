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
            labelName = new Label();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panelTop.SuspendLayout();
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
            dataGridViewOrders.Dock = DockStyle.Fill;
            dataGridViewOrders.Location = new Point(0, 76);
            dataGridViewOrders.Margin = new Padding(4);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(984, 585);
            dataGridViewOrders.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(labelName);
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
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Location = new Point(741, 13);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(37, 19);
            labelName.TabIndex = 8;
            labelName.Text = "Имя";
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
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(dataGridViewOrders);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormOrders";
            Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private Panel panelTop;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label labelName;
        private Button buttonExit;
    }
}