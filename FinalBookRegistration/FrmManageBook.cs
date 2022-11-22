using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBookRegistration
{
    public partial class FrmManageBook : Form
    {
        public FrmManageBook()
        {
            InitializeComponent();
        }

        private void FrmManageBook_Load(object sender, EventArgs e)
        {
            PoplulateBookListBox();

            // disable tab index of some controls
            lblBookForm.TabStop = false;
            lblISBN.TabStop = false;
            lblPrice.TabStop = false;
            lblErrMsg.TabStop = false;

        }

        /// <summary>
        /// Populates a listbox of Books from database
        /// </summary>
        private void PoplulateBookListBox()
        {
            lstBooks.Items.Clear();
            List<Book> books = BookDB.GetAllBooks();

            foreach (Book currBook in books)
            {
                // Add entire book object to listbox
                lstBooks.Items.Add(currBook);
            }

            // onload or when re-populating listbox after user's activities 
            // enable Add button
            // Update button and Delete button are disabled until an item in listbox selected
            txtISBN.Enabled = true;
            btnAddBook.Enabled = true;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string isbn = Validator.ToStandardISBN(txtISBN.Text);
                double price = Convert.ToDouble(txtPrice.Text);
                string title = Validator.FormalizeName(txtTitle.Text);
                
                Book newBook = new Book(isbn, title, price);

                BookDB.Add(newBook);
                MessageBox.Show($"{newBook.Title} has been added succesfully!");
                PoplulateBookListBox();
                clearTextbox();
                //System.Threading.Thread.Sleep(3000);
                //lblNotice.Text = "";
            }
        }

        /// <summary>
        /// Validates input before adding to database
        /// </summary>
        /// <returns>True when all conditions are met</returns>
        private bool IsValid()
        {
            if (IsValidInput())
            {
                if (Validator.IsExistedISBN(txtISBN.Text))
                {
                    lblErrMsg.Text = "This ISBN already exists in the database!";
                    return false;
                }
                lblErrMsg.Text = "";
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates input đata
        /// </summary>
        /// <returns>True when all input textboxes are filled with valid data: 
        /// Price should be a number equals to or greater than 0
        /// ISBN should contain dashes and maximum of 13 digits
        /// </returns>
        private bool IsValidInput()
        {
            // all textboxes are filled
            if (Validator.IsPresent(txtISBN) &&
                Validator.IsPresent(txtTitle) &&
                Validator.IsPresent(txtPrice))
            {
                // ISBN is valid and not existed, and price is a number
                if (Validator.IsValidISBN(txtISBN.Text) &&
                    double.TryParse(txtPrice.Text, out double price))
                {
                    if (price < 0) 
                    {
                        lblErrMsg.Text = "Price should be greater than or equal to 0!";
                        return false;
                    }
                    lblErrMsg.Text = "";
                    return true;
                }
                else
                {
                    if (!Validator.IsValidISBN(txtISBN.Text))
                    {
                        lblErrMsg.Text = "ISBN should contain dashes and maximum 13 digits!";
                    }
                    if (!double.TryParse(txtPrice.Text, out _))
                    {
                        lblErrMsg.Text = "Price should be a number!";
                    }
                    return false;
                }
            }

            lblErrMsg.Text = "All textboxes shouldn't be empty!";
            return false;
        }

        /// <summary>
        /// Clears all textboxes
        /// </summary>
        private void clearTextbox()
        {
            txtISBN.Text = "";
            txtISBN.Focus();
            txtTitle.Text = "";
            txtPrice.Text = string.Empty;

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            /* not neccessary when using button enable/disable 
            // Ensure book is selected
            if (lstBooks.SelectedIndex == -1) {
                MessageBox.Show("Please select a book to delete!");
                return;
            }
            */

            Book selectedBook = lstBooks.SelectedItem as Book;

            try
            {
                BookDB.Delete(selectedBook);
                clearTextbox();
                lblErrMsg.Text = "";
                MessageBox.Show($"{selectedBook.Title} has been deleted succesfully!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("That customer no longer exists");
                PoplulateBookListBox();
            }
            catch (SqlException)
            {
                MessageBox.Show("We are having server issues. Please try again later!");
            }

            PoplulateBookListBox();
        }

        private void bnUpdateBook_Click(object sender, EventArgs e)
        {
            /* not neccessary when using button enable/disable 
            if (lstBooks.SelectedIndex == -1)
            {
                MessageBox.Show("A book must be selected!");
                return;
            }
            */

            Book selectedBook = (Book)lstBooks.SelectedItem;

            // Tung's code:

            if (IsValidInput())
            {
                selectedBook.ISBN = Validator.ToStandardISBN(txtISBN.Text);
                selectedBook.Price = Convert.ToDouble(txtPrice.Text);
                selectedBook.Title = Validator.FormalizeName(txtTitle.Text);

                BookDB.Update(selectedBook);
                PoplulateBookListBox();
                clearTextbox();
                
            }
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrMsg.Text = "";

            // show a message when users click on blank part of listbox
            if (lstBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to Update or Delete!");
                return;
            }

            // when users select an item
            // enable Update button and Delete button
            // disable Add button
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnAddBook.Enabled = false;

            Book selectedBook = (Book)lstBooks.SelectedItem;

            // Tung's code:
            // users are not allowed to update/modify ISBN of a book as it is unique
            // in case of ISBN typos, best solution is to delete the item and add again
            txtISBN.Enabled = false;
            
            // show info to input textboxes when users select an item
            txtISBN.Text = selectedBook.ISBN;
            txtPrice.Text = selectedBook.Price.ToString();
            txtTitle.Text = selectedBook.Title;
        }
    }
}
