namespace Library
{
    partial class FormAddLoans
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
            panelFill = new Panel();
            comboBoxBook = new ComboBox();
            label2 = new Label();
            comboBoxStatus = new ComboBox();
            dateTimePickerReturn = new DateTimePicker();
            dateTimePickerPlan = new DateTimePicker();
            dateTimePickerIs = new DateTimePicker();
            label1 = new Label();
            labelAveableCopies = new Label();
            labePages = new Label();
            labelISBN = new Label();
            labelAuthor = new Label();
            comboBoxUser = new ComboBox();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelTop = new Panel();
            labelAddOrder = new Label();
            panelFill.SuspendLayout();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(comboBoxBook);
            panelFill.Controls.Add(label2);
            panelFill.Controls.Add(comboBoxStatus);
            panelFill.Controls.Add(dateTimePickerReturn);
            panelFill.Controls.Add(dateTimePickerPlan);
            panelFill.Controls.Add(dateTimePickerIs);
            panelFill.Controls.Add(label1);
            panelFill.Controls.Add(labelAveableCopies);
            panelFill.Controls.Add(labePages);
            panelFill.Controls.Add(labelISBN);
            panelFill.Controls.Add(labelAuthor);
            panelFill.Controls.Add(comboBoxUser);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 72);
            panelFill.Margin = new Padding(4);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(13);
            panelFill.Size = new Size(384, 513);
            panelFill.TabIndex = 5;
            // 
            // comboBoxBook
            // 
            comboBoxBook.FormattingEnabled = true;
            comboBoxBook.Location = new Point(81, 152);
            comboBoxBook.Margin = new Padding(4);
            comboBoxBook.Name = "comboBoxBook";
            comboBoxBook.Size = new Size(238, 27);
            comboBoxBook.TabIndex = 21;
            // 
            // label2
            // 
            label2.Location = new Point(78, 434);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 34);
            label2.TabIndex = 20;
            label2.Text = "Статус";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(80, 472);
            comboBoxStatus.Margin = new Padding(4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(238, 27);
            comboBoxStatus.TabIndex = 19;
            // 
            // dateTimePickerReturn
            // 
            dateTimePickerReturn.Location = new Point(78, 393);
            dateTimePickerReturn.Name = "dateTimePickerReturn";
            dateTimePickerReturn.Size = new Size(238, 26);
            dateTimePickerReturn.TabIndex = 18;
            // 
            // dateTimePickerPlan
            // 
            dateTimePickerPlan.Location = new Point(79, 317);
            dateTimePickerPlan.Name = "dateTimePickerPlan";
            dateTimePickerPlan.Size = new Size(238, 26);
            dateTimePickerPlan.TabIndex = 17;
            // 
            // dateTimePickerIs
            // 
            dateTimePickerIs.Location = new Point(81, 235);
            dateTimePickerIs.Name = "dateTimePickerIs";
            dateTimePickerIs.Size = new Size(238, 26);
            dateTimePickerIs.TabIndex = 16;
            // 
            // label1
            // 
            label1.Location = new Point(78, 356);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 34);
            label1.TabIndex = 14;
            label1.Text = "Фактическая дата возврата";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAveableCopies
            // 
            labelAveableCopies.Location = new Point(81, 280);
            labelAveableCopies.Margin = new Padding(4, 0, 4, 0);
            labelAveableCopies.Name = "labelAveableCopies";
            labelAveableCopies.Size = new Size(239, 34);
            labelAveableCopies.TabIndex = 12;
            labelAveableCopies.Text = "Планируемая дата возврата";
            labelAveableCopies.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labePages
            // 
            labePages.Location = new Point(79, 198);
            labePages.Margin = new Padding(4, 0, 4, 0);
            labePages.Name = "labePages";
            labePages.Size = new Size(239, 34);
            labePages.TabIndex = 8;
            labePages.Text = "Дата выдачи";
            labePages.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelISBN
            // 
            labelISBN.Location = new Point(80, 114);
            labelISBN.Margin = new Padding(4, 0, 4, 0);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(239, 34);
            labelISBN.TabIndex = 4;
            labelISBN.Text = "Книга";
            labelISBN.TextAlign = ContentAlignment.MiddleLeft;
            labelISBN.Click += labelISBN_Click;
            // 
            // labelAuthor
            // 
            labelAuthor.Location = new Point(80, 27);
            labelAuthor.Margin = new Padding(4, 0, 4, 0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(239, 34);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Читательский билет";
            labelAuthor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxUser
            // 
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(80, 65);
            comboBoxUser.Margin = new Padding(4);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(238, 27);
            comboBoxUser.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 585);
            panelBottom.Margin = new Padding(4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(384, 103);
            panelBottom.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(74, 111, 165);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(202, 18);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(132, 67);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(74, 111, 165);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(51, 18);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(132, 67);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(labelAddOrder);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(13);
            panelTop.Size = new Size(384, 72);
            panelTop.TabIndex = 3;
            // 
            // labelAddOrder
            // 
            labelAddOrder.Dock = DockStyle.Fill;
            labelAddOrder.Location = new Point(13, 13);
            labelAddOrder.Margin = new Padding(4, 0, 4, 0);
            labelAddOrder.Name = "labelAddOrder";
            labelAddOrder.Size = new Size(358, 46);
            labelAddOrder.TabIndex = 0;
            labelAddOrder.Text = "Добавить заказ";
            labelAddOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAddLoans
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 688);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormAddLoans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddLoans";
            panelFill.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Label labelAveableCopies;
        private Label labePages;
        private Label labelISBN;
        private Label labelAuthor;
        public ComboBox comboBoxUser;
        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelTop;
        private Label label1;
        private Label label2;
        public ComboBox comboBoxStatus;
        public ComboBox comboBoxBook;
        public DateTimePicker dateTimePickerReturn;
        public DateTimePicker dateTimePickerPlan;
        public DateTimePicker dateTimePickerIs;
        public Label labelAddOrder;
    }
}