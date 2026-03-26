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
        public User CurrentUser {  get; private set; }
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
            /*if(IsGuest == false)
            {
                button
            }*/

            labelName.Text = IsGuest? "Гость":CurrentUser.Name;

            LoadBooks();
        }
        public void LoadBooks()
        {
            try
            {
                using( var db = new LibraryContext())
                {
                    var books = db.Books
                        .Include(i => i.Author)
                        .Include(i => i.Genre)
                        .Include(i => i.PublishingHouse)
                        .ToList();

                    dataGridViewBooks.SuspendLayout();
                    dataGridViewBooks.Rows.Clear();

                    foreach(var book in books)
                    {
                        int rowIndex = dataGridViewBooks.Rows.Add();
                        var row = dataGridViewBooks.Rows[rowIndex];

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
            if(book.AvailableCopies <=0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                /*row.DefaultCellStyle.ForeColor = Color.White;*/
            }
            if(book.AvailableCopies > 0 && book.AvailableCopies <=2)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF3CD");
            }
        }

        private string FormatBookInfo(Book book)
        {
            return $"{book}";
        }


    }
}
