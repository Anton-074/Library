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
                    form.comboBoxUser.Items.Add(u.Ticket);
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
                    DateIssue = DateOnly.FromDateTime(form.dateTimePickerIs.Value),
                    PlannedReturnDate = DateOnly.FromDateTime(form.dateTimePickerPlan.Value),
                    ReturnDate = DateOnly.FromDateTime(form.dateTimePickerReturn.Value),
                };
                db.Loans.Add(loan);
                db.SaveChanges();

                MessageBox.Show("Объект добавлен");
                LoadOrders();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, выбрана ли строка в таблице
            if (dataGridViewOrders.CurrentRow == null || dataGridViewOrders.CurrentRow.Tag == null)
            {
                MessageBox.Show("Выберите запись для редактирования!");
                return;
            }

            // 2. Извлекаем объект Loan из Tag (убедись, что в LoadOrders ты делаешь row.Tag = loan)
            if (dataGridViewOrders.CurrentRow.Tag is not Loan selectedLoan)
            {
                MessageBox.Show("Ошибка данных строки.");
                return;
            }

            int loanId = selectedLoan.Id;

            using (var context = new LibraryContext())
            {
                // 3. Находим запись в БД
                var loan = context.Loans.Find(loanId);
                if (loan == null)
                {
                    MessageBox.Show("Запись не найдена в базе данных.");
                    return;
                }

                FormAddLoans form = new FormAddLoans();

                // Загружаем справочники
                var users = context.Users.ToList();
                var statuses = context.Statuses.ToList();
                var books = context.Books.ToList();

                foreach (var u in users) form.comboBoxUser.Items.Add(u.Ticket);
                foreach (var s in statuses) form.comboBoxStatus.Items.Add(s.Name);
                foreach (var b in books) form.comboBoxBook.Items.Add(b.Annotation);

                // 4. Заполняем форму текущими данными
                form.comboBoxUser.Text = users.FirstOrDefault(u => u.Id == loan.IdUser)?.Ticket;
                form.comboBoxStatus.Text = statuses.FirstOrDefault(s => s.Id == loan.IdStatus)?.Name;
                form.comboBoxBook.Text = books.FirstOrDefault(b => b.Id == loan.IdBook)?.Annotation;

                // Конвертируем DateOnly обратно в DateTime для элементов управления
                form.dateTimePickerIs.Value = loan.DateIssue.ToDateTime(TimeOnly.MinValue);
                form.dateTimePickerPlan.Value = loan.PlannedReturnDate.ToDateTime(TimeOnly.MinValue);
                form.dateTimePickerReturn.Value = (loan.ReturnDate ?? DateOnly.FromDateTime(DateTime.Now)).ToDateTime(TimeOnly.MinValue);

                // 5. Показываем форму
                if (form.ShowDialog(this) == DialogResult.Cancel) return;

                // 6. Обновляем ID на основе выбранных текстов в комбобоксах
                var selectedUser = users.FirstOrDefault(u => u.Ticket == form.comboBoxUser.Text);
                var selectedStatus = statuses.FirstOrDefault(s => s.Name == form.comboBoxStatus.Text);
                var selectedBook = books.FirstOrDefault(b => b.Annotation == form.comboBoxBook.Text);

                if (selectedUser != null) loan.IdUser = selectedUser.Id;
                if (selectedStatus != null) loan.IdStatus = selectedStatus.Id;
                if (selectedBook != null) loan.IdBook = selectedBook.Id;

                // Обновляем даты
                loan.DateIssue = DateOnly.FromDateTime(form.dateTimePickerIs.Value);
                loan.PlannedReturnDate = DateOnly.FromDateTime(form.dateTimePickerPlan.Value);
                loan.ReturnDate = DateOnly.FromDateTime(form.dateTimePickerReturn.Value);

                // 7. Сохраняем и обновляем таблицу
                context.SaveChanges();

                MessageBox.Show("Запись успешно изменена");
                LoadOrders();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, выбрана ли строка
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }

            // 2. Спрашиваем подтверждение
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот заказ?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            // 3. Извлекаем объект Loan из Tag выбранной строки
            var selectedRow = dataGridViewOrders.SelectedRows[0];
            if (selectedRow.Tag is not Loan loan)
            {
                MessageBox.Show("Не удалось получить данные заказа.");
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    // 4. Находим запись в БД по ID
                    var loanToDelete = context.Loans.Find(loan.Id);

                    if (loanToDelete == null)
                    {
                        MessageBox.Show("Запись не найдена в базе данных.");
                        return;
                    }

                    // 5. Удаляем и сохраняем
                    context.Loans.Remove(loanToDelete);
                    context.SaveChanges();
                }

                MessageBox.Show("Запись успешно удалена");
                LoadOrders(); // Обновляем таблицу
            }
            catch (Exception ex)
            {
                // Если заказ связан с другими таблицами и есть ограничение Foreign Key,
                // здесь мы поймаем ошибку и выведем ее.
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
