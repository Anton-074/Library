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
    public partial class FormBooks : Form
    {
        private LibraryContext? db;
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormBooks(User user, bool guest)
        {
            InitializeComponent();
            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colAviableCopies = new DataGridViewTextBoxColumn();
            colAviableCopies.Name = "colAviableCopies";
            colAviableCopies.FillWeight = 10;
            colAviableCopies.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewBooks.Columns.AddRange(
            [
                colPhoto,
                colInfo,
                colAviableCopies
            ]);

            CurrentUser = user;
            IsGuest = guest;
            if (IsGuest == false)
            {
                buttonLoans.Visible = true;
                buttonAdd.Visible = true;
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;

            }

            labelName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadBooks();
        }
        public void LoadBooks()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var books = db.Books
                        .Include(i => i.Author)
                        .Include(i => i.Genre)
                        .Include(i => i.PublishingHouse)
                        .ToList();

                    dataGridViewBooks.SuspendLayout();
                    dataGridViewBooks.Rows.Clear();

                    foreach (var book in books)
                    {
                        int rowIndex = dataGridViewBooks.Rows.Add();
                        var row = dataGridViewBooks.Rows[rowIndex];
                        row.Tag = book;
                        //row.Cells["colPhoto"].Value = LoadProductImage()

                        row.Cells["colInfo"].Value = FormatBookInfo(book);

                        row.Cells["colAviableCopies"].Value = $"{book.AvailableCopies}";
                        row.Cells["colAviableCopies"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, book);
                    }
                    dataGridViewBooks.ResumeLayout();
                    dataGridViewBooks.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyRowStyles(DataGridViewRow row, Book book)
        {
            if (book.AvailableCopies <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                /*row.DefaultCellStyle.ForeColor = Color.White;*/
            }
            if (book.AvailableCopies > 0 && book.AvailableCopies <= 2)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF3CD");
            }
        }

        private string FormatBookInfo(Book book)
        {
            return $"{book.Author.Name} | {book.Genre.Name}" + Environment.NewLine +
                $"Издательство: {book.PublishingHouse.Name}" + Environment.NewLine +
                $"Год издания: {book.Year}" + Environment.NewLine +
                $"Страниц: {book.Pages}" + Environment.NewLine +
                $"Всего экземпляров: {book.TotalCopies}" + Environment.NewLine +
                $"Аннотация: {book.Annotation}";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            db = new LibraryContext();
            if (dataGridViewBooks.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            // Получаем выбранную строку и книгу из Tag
            var selectedRow = dataGridViewBooks.SelectedRows[0];
            if (selectedRow.Tag is not Book book)
            {
                MessageBox.Show("Не удалось получить данные книги.");
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    // Находим и удаляем книгу
                    var bookToDelete = context.Books.Find(book.Id); // Предполагая свойство Id в модели Book
                    if (bookToDelete == null)
                    {
                        MessageBox.Show("Книга не найдена в базе данных.");
                        return;
                    }

                    context.Books.Remove(bookToDelete);
                    context.SaveChanges();
                }
                MessageBox.Show("Объект удален");
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadBooks();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditBook form = new FormAddEditBook();
            using (db = new LibraryContext())
            {
                var authors = db.Authors.ToList();
                var genres = db.Genres.ToList();
                var publishingHouses = db.PublishingHouses.ToList();



                int indexAuthors = -1;
                int indexGenres = -1;
                int indexPublishingHouses = -1;


                foreach (Author u in authors)
                {
                    form.comboBoxAuthor.Items.Add(u.Name);
                }
                foreach (Genre u in genres)
                {
                    form.comboBoxGenre.Items.Add(u.Name);
                }
                foreach (PublishingHouse u in publishingHouses)
                {
                    form.comboBoxPubliserHouse.Items.Add(u.Name);
                }

                DialogResult result = form.ShowDialog(this);


                if (result == DialogResult.Cancel)
                    return;

                foreach (Author u in authors)
                {
                    if (u.Name == form.comboBoxAuthor.Text)
                    {
                        indexAuthors = u.Id;
                    }
                }
                foreach (Genre u in genres)
                {
                    if (u.Name == form.comboBoxGenre.Text)
                    {
                        indexGenres = u.Id;
                    }
                }
                foreach (PublishingHouse u in publishingHouses)
                {
                    if (u.Name == form.comboBoxPubliserHouse.Text)
                    {
                        indexPublishingHouses = u.Id;
                    }
                }

                Book book = new Book
                {
                    IdAuthor = indexAuthors,
                    IdGenre = indexGenres,
                    IdPublishingHouse = indexPublishingHouses,
                    Isbn = form.textBoxISBN.Text,
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
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, есть ли выбранная строка
            if (dataGridViewBooks.CurrentRow == null || dataGridViewBooks.CurrentRow.Tag == null)
            {
                MessageBox.Show("Выберите книгу в списке!");
                return;
            }

            // 2. Извлекаем объект Book напрямую из Tag
            // (Мы сохранили его там в методе LoadBooks: row.Tag = book)
            if (dataGridViewBooks.CurrentRow.Tag is not Book selectedBook)
            {
                MessageBox.Show("Ошибка данных строки.");
                return;
            }

            int bookId = selectedBook.Id; // Теперь ID берем из объекта

            using (var context = new LibraryContext()) // Используем локальный контекст
            {
                // 3. Находим книгу в БД по ID
                var book = context.Books.Find(bookId);
                if (book == null)
                {
                    MessageBox.Show("Книга не найдена в базе данных.");
                    return;
                }

                FormAddEditBook form = new FormAddEditBook();

                // Загружаем справочники
                var authors = context.Authors.ToList();
                var genres = context.Genres.ToList();
                var houses = context.PublishingHouses.ToList();

                foreach (var a in authors) form.comboBoxAuthor.Items.Add(a.Name);
                foreach (var g in genres) form.comboBoxGenre.Items.Add(g.Name);
                foreach (var p in houses) form.comboBoxPubliserHouse.Items.Add(p.Name);

                // 4. Заполняем поля формы данными
                form.textBoxISBN.Text = book.Isbn;
                form.textBoxPages.Text = book.Pages;
                form.textBoxYear.Text = book.Year.ToString();
                form.textBoxTotalCopies.Text = book.TotalCopies.ToString();
                form.textBoxAviableCopies.Text = book.AvailableCopies.ToString();
                form.textBoxAnnotation.Text = book.Annotation;

                // Устанавливаем текущие значения в комбобоксах
                form.comboBoxAuthor.Text = authors.FirstOrDefault(a => a.Id == book.IdAuthor)?.Name;
                form.comboBoxGenre.Text = genres.FirstOrDefault(g => g.Id == book.IdGenre)?.Name;
                form.comboBoxPubliserHouse.Text = houses.FirstOrDefault(p => p.Id == book.IdPublishingHouse)?.Name;

                // 5. Показываем форму
                if (form.ShowDialog(this) == DialogResult.Cancel) return;

                // 6. Обновляем данные объекта, который отслеживается контекстом
                var selectedAuthor = authors.FirstOrDefault(a => a.Name == form.comboBoxAuthor.Text);
                var selectedGenre = genres.FirstOrDefault(g => g.Name == form.comboBoxGenre.Text);
                var selectedHouse = houses.FirstOrDefault(p => p.Name == form.comboBoxPubliserHouse.Text);

                if (selectedAuthor != null) book.IdAuthor = selectedAuthor.Id;
                if (selectedGenre != null) book.IdGenre = selectedGenre.Id;
                if (selectedHouse != null) book.IdPublishingHouse = selectedHouse.Id;

                book.Isbn = form.textBoxISBN.Text;
                book.Pages = form.textBoxPages.Text;
                book.Year = int.TryParse(form.textBoxYear.Text, out int y) ? y : book.Year;
                book.TotalCopies = int.TryParse(form.textBoxTotalCopies.Text, out int tc) ? tc : book.TotalCopies;
                book.AvailableCopies = int.TryParse(form.textBoxAviableCopies.Text, out int ac) ? ac : book.AvailableCopies;
                book.Annotation = form.textBoxAnnotation.Text;

                // 7. Сохраняем
                context.SaveChanges();

                MessageBox.Show("Запись успешно изменена");
                LoadBooks();
            }
        }

        private void buttonLoans_Click(object sender, EventArgs e)
        {

        }
    }
}
