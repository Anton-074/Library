namespace Library
{
    partial class FormAddEditBook
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
            components = new System.ComponentModel.Container();
            panelTop = new Panel();
            labelAddBook = new Label();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelFill = new Panel();
            labelPublisherHouse = new Label();
            comboBoxPubliserHouse = new ComboBox();
            textBoxAnnotation = new TextBox();
            labelAnnotation = new Label();
            textBoxAviableCopies = new TextBox();
            labelAveableCopies = new Label();
            textBoxTotalCopies = new TextBox();
            labelTotalCopies = new Label();
            textBoxPages = new TextBox();
            labePages = new Label();
            textBoxYear = new TextBox();
            labelYear = new Label();
            textBoxISBN = new TextBox();
            labelISBN = new Label();
            labelGenre = new Label();
            comboBoxGenre = new ComboBox();
            labelAuthor = new Label();
            comboBoxAuthor = new ComboBox();
            errorProvider = new ErrorProvider(components);
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(labelAddBook);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(584, 57);
            panelTop.TabIndex = 0;
            // 
            // labelAddBook
            // 
            labelAddBook.Dock = DockStyle.Fill;
            labelAddBook.Location = new Point(10, 10);
            labelAddBook.Name = "labelAddBook";
            labelAddBook.Size = new Size(564, 37);
            labelAddBook.TabIndex = 0;
            labelAddBook.Text = "Добавить книгу";
            labelAddBook.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 489);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(584, 81);
            panelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(74, 111, 165);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(323, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(231, 53);
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
            buttonSave.Location = new Point(30, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(231, 53);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(labelPublisherHouse);
            panelFill.Controls.Add(comboBoxPubliserHouse);
            panelFill.Controls.Add(textBoxAnnotation);
            panelFill.Controls.Add(labelAnnotation);
            panelFill.Controls.Add(textBoxAviableCopies);
            panelFill.Controls.Add(labelAveableCopies);
            panelFill.Controls.Add(textBoxTotalCopies);
            panelFill.Controls.Add(labelTotalCopies);
            panelFill.Controls.Add(textBoxPages);
            panelFill.Controls.Add(labePages);
            panelFill.Controls.Add(textBoxYear);
            panelFill.Controls.Add(labelYear);
            panelFill.Controls.Add(textBoxISBN);
            panelFill.Controls.Add(labelISBN);
            panelFill.Controls.Add(labelGenre);
            panelFill.Controls.Add(comboBoxGenre);
            panelFill.Controls.Add(labelAuthor);
            panelFill.Controls.Add(comboBoxAuthor);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 57);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(584, 432);
            panelFill.TabIndex = 2;
            // 
            // labelPublisherHouse
            // 
            labelPublisherHouse.Location = new Point(335, 108);
            labelPublisherHouse.Name = "labelPublisherHouse";
            labelPublisherHouse.Size = new Size(186, 27);
            labelPublisherHouse.TabIndex = 17;
            labelPublisherHouse.Text = "Издательство";
            labelPublisherHouse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxPubliserHouse
            // 
            comboBoxPubliserHouse.FormattingEnabled = true;
            comboBoxPubliserHouse.Location = new Point(335, 138);
            comboBoxPubliserHouse.Name = "comboBoxPubliserHouse";
            comboBoxPubliserHouse.Size = new Size(186, 27);
            comboBoxPubliserHouse.TabIndex = 16;
            comboBoxPubliserHouse.TextChanged += comboBoxPubliserHouse_TextChanged;
            comboBoxPubliserHouse.Validating += comboBoxPubliserHouse_Validating;
            // 
            // textBoxAnnotation
            // 
            textBoxAnnotation.Location = new Point(62, 387);
            textBoxAnnotation.Name = "textBoxAnnotation";
            textBoxAnnotation.Size = new Size(460, 26);
            textBoxAnnotation.TabIndex = 15;
            textBoxAnnotation.TextChanged += textBoxAnnotation_TextChanged;
            textBoxAnnotation.Validating += textBoxAnnotation_Validating;
            // 
            // labelAnnotation
            // 
            labelAnnotation.Location = new Point(62, 357);
            labelAnnotation.Name = "labelAnnotation";
            labelAnnotation.Size = new Size(460, 27);
            labelAnnotation.TabIndex = 14;
            labelAnnotation.Text = "Аннотация";
            labelAnnotation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAviableCopies
            // 
            textBoxAviableCopies.Location = new Point(62, 309);
            textBoxAviableCopies.Name = "textBoxAviableCopies";
            textBoxAviableCopies.Size = new Size(186, 26);
            textBoxAviableCopies.TabIndex = 13;
            textBoxAviableCopies.TextChanged += textBoxAviableCopies_TextChanged;
            textBoxAviableCopies.Validating += textBoxAviableCopies_Validating;
            // 
            // labelAveableCopies
            // 
            labelAveableCopies.Location = new Point(62, 279);
            labelAveableCopies.Name = "labelAveableCopies";
            labelAveableCopies.Size = new Size(186, 27);
            labelAveableCopies.TabIndex = 12;
            labelAveableCopies.Text = "Доступно экземпляров";
            labelAveableCopies.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTotalCopies
            // 
            textBoxTotalCopies.Location = new Point(335, 309);
            textBoxTotalCopies.Name = "textBoxTotalCopies";
            textBoxTotalCopies.Size = new Size(186, 26);
            textBoxTotalCopies.TabIndex = 11;
            textBoxTotalCopies.TextChanged += textBoxTotalCopies_TextChanged;
            textBoxTotalCopies.Validating += textBoxTotalCopies_Validating;
            // 
            // labelTotalCopies
            // 
            labelTotalCopies.Location = new Point(335, 279);
            labelTotalCopies.Name = "labelTotalCopies";
            labelTotalCopies.Size = new Size(186, 27);
            labelTotalCopies.TabIndex = 10;
            labelTotalCopies.Text = "Всего экземпляров";
            labelTotalCopies.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(62, 223);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(186, 26);
            textBoxPages.TabIndex = 9;
            textBoxPages.TextChanged += textBoxPages_TextChanged;
            textBoxPages.Validating += textBoxPages_Validating;
            // 
            // labePages
            // 
            labePages.Location = new Point(62, 193);
            labePages.Name = "labePages";
            labePages.Size = new Size(186, 27);
            labePages.TabIndex = 8;
            labePages.Text = "Количество страниц";
            labePages.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(335, 223);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(186, 26);
            textBoxYear.TabIndex = 7;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            textBoxYear.Validating += textBoxYear_Validating;
            // 
            // labelYear
            // 
            labelYear.Location = new Point(335, 193);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(186, 27);
            labelYear.TabIndex = 6;
            labelYear.Text = "Год";
            labelYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(62, 138);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(186, 26);
            textBoxISBN.TabIndex = 5;
            textBoxISBN.TextChanged += textBoxISBN_TextChanged;
            textBoxISBN.Validating += textBoxISBN_Validating;
            // 
            // labelISBN
            // 
            labelISBN.Location = new Point(62, 108);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(186, 27);
            labelISBN.TabIndex = 4;
            labelISBN.Text = "ISBN";
            labelISBN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelGenre
            // 
            labelGenre.Location = new Point(335, 21);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(186, 27);
            labelGenre.TabIndex = 3;
            labelGenre.Text = "Жанр";
            labelGenre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(335, 51);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(186, 27);
            comboBoxGenre.TabIndex = 2;
            comboBoxGenre.TextChanged += comboBoxGenre_TextChanged;
            comboBoxGenre.Validating += comboBoxGenre_Validating;
            // 
            // labelAuthor
            // 
            labelAuthor.Location = new Point(62, 21);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(186, 27);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Автор";
            labelAuthor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(62, 51);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(186, 27);
            comboBoxAuthor.TabIndex = 0;
            comboBoxAuthor.TextChanged += comboBoxAuthor_TextChanged;
            comboBoxAuthor.Validating += comboBoxAuthor_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddEditBook
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 570);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormAddEditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddEditBook";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelAddBook;
        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Panel panelFill;
        private Label labePages;
        private Label labelYear;
        private Label labelISBN;
        private Label labelGenre;
        private Label labelAuthor;
        private TextBox textBox3;
        private Label labelAnnotation;
        private TextBox textBox2;
        private Label labelAveableCopies;
        private Label labelTotalCopies;
        private Label labelPublisherHouse;
        private ErrorProvider errorProvider;
        public TextBox textBoxYear;
        public TextBox textBoxPages;
        public TextBox textBoxISBN;
        public ComboBox comboBoxGenre;
        public ComboBox comboBoxAuthor;
        public TextBox textBoxAviableCopies;
        public TextBox textBoxAnnotation;
        public TextBox textBoxTotalCopies;
        public ComboBox comboBoxPubliserHouse;
    }
}