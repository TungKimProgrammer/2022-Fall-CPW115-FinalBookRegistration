using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalBookRegistration
{
    static class CustomerDB
    {
        /// <summary>
        /// Adds a Customer to the database
        /// </summary>
        /// <param name="c">The Customer to be added</param>
        public static void Add(Customer c)
        {
            SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            // prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;
            // parameterized query
            insertCmd.CommandText = "INSERT INTO Customer(Title, FirstName, LastName, DateOfBirth)" +
                                                 "VALUES (@title, @fName, @lName, @dob)";
            insertCmd.Parameters.AddWithValue("@title", c.Title);
            insertCmd.Parameters.AddWithValue("@fName", c.FirstName);
            insertCmd.Parameters.AddWithValue("@lName", c.LastName);
            insertCmd.Parameters.AddWithValue("@dob", c.DateOfBirth);

            // open connection to the database
            con.Open();

            // execute insert qury
            insertCmd.ExecuteNonQuery();

            // close connection to the database
            con.Close();
        }

        /// <summary>
        /// Gets a list of all Customers ordered by last name in ascending order
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetAllCustomers()
        {
            // Get connection
            SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            // Prepare the query 
            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT CustomerID, Title, FirstName, LastName, DateOfBirth " +
                                 "FROM Customer " +
                                 "ORDER BY LastName";

            // open connection to the database
            con.Open();

            // Execute the query and use results
            SqlDataReader reader = selectCmd.ExecuteReader();

            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CustomerID"]);
                string title = reader["Title"].ToString();
                string fName = reader["FirstName"].ToString();
                string lName = reader["LastName"].ToString();
                DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);

                Customer tempCus = new Customer(title, fName, lName, dob);
                tempCus.CustomerID = id;
                customers.Add(tempCus);
            }

            // Close the connection
            con.Close();

            // Return list of Customers
            return customers;
        }

        public static void Update(Customer c)
        {
            // use "using" statement to close connection automatically
            using SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;
            updateCmd.CommandText = "UPDATE Customer " +
                                    "SET Title = @title " +
                                      ", FirstName = @firstName " +
                                      ", LastName = @lastName " +
                                      ", DateOfBirth = @dob " +
                                    "WHERE CustomerID = @customerID";
            updateCmd.Parameters.AddWithValue("@customerID", c.CustomerID);
            updateCmd.Parameters.AddWithValue("@title", c.Title);
            updateCmd.Parameters.AddWithValue("@firstName", c.FirstName);
            updateCmd.Parameters.AddWithValue("@lastName", c.LastName);
            updateCmd.Parameters.AddWithValue("@dob", c.DateOfBirth);

            // Open connection to the database
            con.Open();

            // Execute query
            int rows = updateCmd.ExecuteNonQuery();
            if (rows == 0)
            {
                throw new ArgumentException("A customer with that id does not exist!");
            }
        }

        /// <summary>
        /// Deletes a student
        /// </summary>
        /// <param name="c">The Customer to be deleted</param>
        /// <exception cref="SqlException">Thrown for SQL problems</exception>
        /// <exception cref="ArgumentException">Thrown if the customer does not exist</exception></param>
        public static void Delete(Customer c)
        {
            if (c.CustomerID == 0)
            {
                throw new ArgumentException("The CustomerID must be populated!");
            }
            Delete(c.CustomerID);
        }

        /// <summary>
        /// Deletes a customer by the CustomerID number
        /// </summary>
        /// <param name="id">The CustomerID of Customer to be deleted</param>
        /// <exception cref="SqlException">Thrown for SQL problems</exception>
        /// <exception cref="ArgumentException">Thrown if the customer does not exist</exception>
        public static void Delete(int id)
        {
            // use "using" statement to close connection automatically
            using SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            SqlCommand deleteCmd = new SqlCommand();
            deleteCmd.Connection = con;
            deleteCmd.CommandText = "DELETE FROM Customer " +
                                    "WHERE CustomerID = @customerID";
            deleteCmd.Parameters.AddWithValue("@customerID", id);

            // Open connection to the database
            con.Open();

            // Execute query
            int rows = deleteCmd.ExecuteNonQuery();
            if (rows == 0)
            {
                throw new ArgumentException("A customer with that id does not exist!");
            }
        }

        public static Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
