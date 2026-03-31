using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library
{
    public partial class FormAddEditBook : Form
    {

        private string msError = "поле не может быть пустым";
        public FormAddEditBook()
        {
            InitializeComponent();
        }

        private void comboBoxAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(comboBoxAuthor.Text))
            {
                errorProvider.SetError(comboBoxAuthor, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void comboBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(comboBoxAuthor.Text))
            {
                errorProvider.SetError(comboBoxAuthor, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void comboBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(comboBoxAuthor.Text))
            {
                errorProvider.SetError(comboBoxAuthor, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void comboBoxGenre_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(comboBoxGenre.Text))
            {
                errorProvider.SetError(comboBoxGenre, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxISBN.Text))
            {
                errorProvider.SetError(textBoxISBN, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxISBN_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxISBN.Text))
            {
                errorProvider.SetError(textBoxISBN, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void comboBoxPubliserHouse_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(comboBoxPubliserHouse.Text))
            {
                errorProvider.SetError(comboBoxPubliserHouse, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void comboBoxPubliserHouse_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(comboBoxPubliserHouse.Text))
            {
                errorProvider.SetError(comboBoxPubliserHouse, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxPages_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxPages.Text))
            {
                errorProvider.SetError(textBoxPages, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxPages_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxPages.Text))
            {
                errorProvider.SetError(textBoxPages, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxYear.Text))
            {
                errorProvider.SetError(textBoxYear, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxYear_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxYear.Text))
            {
                errorProvider.SetError(textBoxYear, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxAviableCopies_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxAviableCopies.Text))
            {
                errorProvider.SetError(textBoxAviableCopies, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxAviableCopies_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxAviableCopies.Text))
            {
                errorProvider.SetError(textBoxAviableCopies, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxTotalCopies_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxTotalCopies.Text))
            {
                errorProvider.SetError(textBoxTotalCopies, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxTotalCopies_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxTotalCopies.Text))
            {
                errorProvider.SetError(textBoxTotalCopies, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxAnnotation_Validating(object sender, CancelEventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxAnnotation.Text))
            {
                errorProvider.SetError(textBoxAnnotation, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxAnnotation_TextChanged(object sender, EventArgs e)
        {
            if (System.String.IsNullOrEmpty(textBoxAnnotation.Text))
            {
                errorProvider.SetError(textBoxAnnotation, msError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
