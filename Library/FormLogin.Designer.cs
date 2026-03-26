namespace Library
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            buttonGuest = new Button();
            buttonEnter = new Button();
            textBoxPass = new TextBox();
            labelPass = new Label();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(textBoxLogin);
            panelMain.Controls.Add(buttonGuest);
            panelMain.Controls.Add(buttonEnter);
            panelMain.Controls.Add(textBoxPass);
            panelMain.Controls.Add(labelPass);
            panelMain.Controls.Add(labelLogin);
            panelMain.Location = new Point(40, 130);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(360, 269);
            panelMain.TabIndex = 1;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.FromArgb(74, 111, 165);
            buttonGuest.FlatStyle = FlatStyle.Flat;
            buttonGuest.Location = new Point(105, 218);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(150, 30);
            buttonGuest.TabIndex = 5;
            buttonGuest.Text = "Войти как гость";
            buttonGuest.UseVisualStyleBackColor = false;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(74, 111, 165);
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Location = new Point(105, 172);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(150, 30);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(55, 130);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(250, 26);
            textBoxPass.TabIndex = 3;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(151, 95);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(58, 19);
            labelPass.TabIndex = 2;
            labelPass.Text = "Пароль";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(154, 18);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 19);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(55, 53);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(250, 26);
            textBoxLogin.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 411);
            Controls.Add(panelMain);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelMain;
        private TextBox textBox1;
        private Label labelLogin;
        private Button buttonGuest;
        private Button buttonEnter;
        private TextBox textBoxPass;
        private Label labelPass;
        private TextBox textBoxLogin;
    }
}