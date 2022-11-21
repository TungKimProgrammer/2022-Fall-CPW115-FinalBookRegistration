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
            PopulateCustomerList();
            PopulateBookList();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            FrmManageCustomer cusMngFrm = new FrmManageCustomer(); 
            cusMngFrm.ShowDialog();
            PopulateCustomerList();
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            FrmManageBook bookMngFrm = new FrmManageBook();
            bookMngFrm.ShowDialog();
            PopulateBookList();
        }

        private void PopulateCustomerList()
        {
            cbxCustomerName.Items.Clear();

            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer currCus in customers)
            {
                // Add entire customer object to combo box
                cbxCustomerName.Items.Add(currCus.FullName);
            }
        }

        private void PopulateBookList()
        {
            cbxBookTitle.Items.Clear();

            List<Book> books = BookDB.GetAllBooks();

            foreach (Book currBook in books)
            {
                // Add entire book object to combo box
                cbxBookTitle.Items.Add(currBook.Title);
            }
        }
    }
}