using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FormOrders : Form
    {
        private LibraryContext? db;
        public User CurrentUser { get; private set; }
        public FormOrders(User user)
        {
            labelName.Text = CurrentUser.FullName;

            InitializeComponent();
            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDataIs = new DataGridViewTextBoxColumn();
            colDataIs.Name = "colDataIs";
            colDataIs.FillWeight = 10;
            colDataIs.HeaderText = "Дата выдачи";
            colDataIs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colDataPlan = new DataGridViewTextBoxColumn();
            colDataPlan.Name = "colDataPlan";
            colDataPlan.FillWeight = 10;
            colDataPlan.HeaderText = "Планируемая дата возврата";
            colDataPlan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colDataReturn = new DataGridViewTextBoxColumn();
            colDataReturn.Name = "colDataReturn";
            colDataReturn.FillWeight = 10;
            colDataReturn.HeaderText = "Дата возврата";
            colDataReturn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewOrders.Columns.AddRange(
           [
                colInfo,
                colDataIs,
                colDataPlan,
                colDataReturn
           ]);

            CurrentUser = user;
            LoadOrders();

            if(user.IdRole == 1)
            {
                buttonAdd.Visible = true;
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
            }
        }
        public void LoadOrders()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var loans = db.Loans
                        .Include(i => i.User)
                        .Include(i => i.Status)
                        .Include(i => i.Book)
                        .ToList();

                    dataGridViewOrders.SuspendLayout();
                    dataGridViewOrders.Rows.Clear();

                    foreach (var loan in loans)
                    {
                        int rowIndex = dataGridViewOrders.Rows.Add();
                        var row = dataGridViewOrders.Rows[rowIndex];
                        row.Tag = loan;
                        //row.Cells["colPhoto"].Value = LoadProductImage()

                        row.Cells["colInfo"].Value = FormatOrderInfo(loan);

                        row.Cells["colDataIs"].Value = $"{loan.DateIssue}";
                        row.Cells["colDataPlan"].Value = $"{loan.PlannedReturnDate}";
                        row.Cells["colDataReturn"].Value = $"{loan.ReturnDate}";
                        row.Cells["colDataPlan"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        row.Cells["colDataIs"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        row.Cells["colDataReturn"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    }
                    dataGridViewOrders.ResumeLayout();
                    dataGridViewOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string FormatOrderInfo(Loan loan)
        {
            return $"{loan.User.Name}" + Environment.NewLine +
                $"Статус: {loan.Status.Name}" + Environment.NewLine +
                $"Аннотация: {loan.Book.Annotation}";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddLoans form = new FormAddLoans();
            using (db = new LibraryContext())
            {
                var user = db.Users.ToList();
                var status = db.Statuses.ToList();
                var book = db.Books.ToList();



                int indexUser = -1;
                int indexStatus = -1;
                int indexBook = -1;


                foreach (User u in user)
                {
                    form.comboBoxUser.Items.Add(u.Name);
                }
                foreach (Status u in status)
                {
                    form.comboBoxStatus.Items.Add(u.Name);
                }
                foreach (Book u in book)
                {
                    form.comboBoxBook.Items.Add(u.Annotation);
                }

                DialogResult result = form.ShowDialog(this);


                if (result == DialogResult.Cancel)
                    return;

                foreach (User u in user)
                {
                    if (u.Name == form.comboBoxUser.Text)
                    {
                        indexUser = u.Id;
                    }
                }
                foreach (Status u in status)
                {
                    if (u.Name == form.comboBoxStatus.Text)
                    {
                        indexStatus = u.Id;
                    }
                }
                foreach (Book u in book)
                {
                    if (u.Annotation == form.comboBoxBook.Text)
                    {
                        indexBook = u.Id;
                    }
                }

                Loan loan = new Loan
                {
                    IdUser = indexUser,
                    IdStatus = indexStatus,
                    IdBook = indexBook,
                    DateIssue = form.dateTimePickerIs.Value,
                    Pages = form.textBoxPages.Text,
                    Year = Int32.Parse(form.textBoxYear.Text),
                    TotalCopies = Int32.Parse(form.textBoxTotalCopies.Text),
                    AvailableCopies = Int32.Parse(form.textBoxAviableCopies.Text),
                    Annotation = form.textBoxAnnotation.Text
                };
                db.Books.Add(book);
                db.SaveChanges();

                MessageBox.Show("Объект добавлен");
                LoadBooks();


            }
        }
    }
}
