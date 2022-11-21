using System.Data.SqlClient;

namespace FinalBookRegistration
{
    public partial class FrmBookRegistration : Form
    {
        public FrmBookRegistration()
        {
            InitializeComponent();
        }

        private void FrmBookRegistration_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            FrmManageCustomer cusMngFrm = new FrmManageCustomer(); 
            cusMngFrm.ShowDialog();

            // refresh combo box after users add/update/delete 
            resetForm();
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            FrmManageBook bookMngFrm = new FrmManageBook();
            bookMngFrm.ShowDialog();

            // refresh combo box after users add/update/delete 
            resetForm();
        }

        private void PopulateCustomerComboBox()
        {
            cbxCustomerName.Items.Clear();

            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer currCus in customers)
            {
                // Add entire customer object to combo box
                cbxCustomerName.Items.Add(currCus);
            }
        }

        private void PopulateBookComboBox()
        {
            cbxBookTitle.Items.Clear();

            List<Book> allValidBooks = BookDB.GetAllValidBooks();

            foreach (Book currBook in allValidBooks)
            {
                // Add entire book object to combo box
                cbxBookTitle.Items.Add(currBook);
            }
        }

        private void PopulateBookComboBox(int customerID)
        {
            cbxBookTitle.Items.Clear();

            List<Book> booksNotYetRegisterByCustomerID = BookDB.GetBooksNotYetRegisterByCustomerID(customerID);

            foreach (Book currBook in booksNotYetRegisterByCustomerID)
            {
                // Add entire book object to combo box
                cbxBookTitle.Items.Add(currBook);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // validates date

            // check if registration exists

            // make sure users select a customer and a book to register
            if (cbxCustomerName.SelectedIndex == -1 ||
                cbxBookTitle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer and a book to register!");
                return;
            }

            Customer selectedCus = (Customer)cbxCustomerName.SelectedItem;
            Book selectedBook = (Book)cbxBookTitle.SelectedItem;
            DateTime regDate = dtpRegistration.Value;

            Registration newReg = new Registration(selectedCus.CustomerID, selectedBook.ISBN, regDate);

            try
            {
                bool result = BookRegistrationDB.RegisterBook(newReg);
                MessageBox.Show($"Registration of {selectedCus.FullName} for {selectedBook.Title} has been addded succesfully!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("That customer or book no longer exists");
                resetForm();
            }
            catch (SqlException)
            {
                MessageBox.Show("We are having server issues. Please try again later!");
            }

            resetForm();
        }

        private void btnManageRegistration_Click(object sender, EventArgs e)
        {
            FrmManageRegistration registrationMngFrm = new FrmManageRegistration();
            registrationMngFrm.ShowDialog();
            resetForm();
        }

        private void cbxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to show available books to register!");
                return;
            }

            Customer selectedCus = (Customer)cbxCustomerName.SelectedItem;
            PopulateBookComboBox(selectedCus.CustomerID);
        }

        private void resetForm()
        {
            PopulateCustomerComboBox();
            PopulateBookComboBox();
            lblErrMsg.Text = "";
            dtpRegistration.Value = DateTime.Today;
        }
    }
}