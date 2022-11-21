﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBookRegistration
{
    static class BookDB
    {
        public static void Add(Book b) 
        {
            // establish connection to database
            SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            // prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;
            // parameterized query
            insertCmd.CommandText = "INSERT INTO Book(ISBN, Price, Title)" +
                                             "VALUES (@isbn, @price, @title)";
            insertCmd.Parameters.AddWithValue("@isbn", b.ISBN);
            insertCmd.Parameters.AddWithValue("@price", b.Price);
            insertCmd.Parameters.AddWithValue("@title", b.Title);

            // open connection to the database
            con.Open();

            // execute insert qury
            insertCmd.ExecuteNonQuery();

            // close connection to the database
            con.Close();
        }

        public static List<Book> GetAllBooks(){
            // Get connection
            SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            // Prepare the query 
            SqlCommand selectCmd = new SqlCommand();
            selectCmd.Connection = con;
            selectCmd.CommandText = "SELECT ISBN, Title, Price " +
                                 "FROM Book " +
                                 "ORDER BY ISBN";

            // open connection to the database
            con.Open();

            // Execute the query and use results
            SqlDataReader reader = selectCmd.ExecuteReader();

            List<Book> books = new();

            while (reader.Read())
            {
                string isbn = reader["ISBN"].ToString(); 
                string title = reader["Title"].ToString();
                double price = Convert.ToDouble(reader["Price"]);

                Book tempBook = new Book(isbn, title, price);
                books.Add(tempBook);
            }

            // Close the connection
            con.Close();

            // Return list of Customers
            return books;
        }

        public static void Update(Book b)
        {
            // use "using" statement to close connection automatically
            using SqlConnection con = DBHelper.GetDatabaseConnection("BookRegistration");

            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;
            updateCmd.CommandText = "UPDATE Book " +
                                    "SET Price = @price " +
                                    "  , Title = @title " +
                                    "WHERE ISBN = @isbn";
            updateCmd.Parameters.AddWithValue("@price", b.Price);
            updateCmd.Parameters.AddWithValue("@title", b.Title);
            updateCmd.Parameters.AddWithValue("@isbn", b.ISBN);

            // Open connection to the database
            con.Open();

            // Execute query
            int rows = updateCmd.ExecuteNonQuery();
            if (rows == 0)
            {
                throw new ArgumentException("A book with that ISBN does not exist!");
            }
        }

        /// <summary>
        /// Deletes a book
        /// </summary>
        /// <param name="id">The Book to be deleted</param>
        /// <exception cref="SqlException">Thrown for SQL problems</exception>
        /// <exception cref="ArgumentException">Thrown if the book does not exist</exception>
        public static void Delete(Book b)
        {
            Delete(b.ISBN);
        }

        /// <summary>
        /// Deletes a book by the ISBN number
        /// </summary>
        /// <param name="id">The ISBN of Book to be deleted</param>
        /// <exception cref="SqlException">Thrown for SQL problems</exception>
        /// <exception cref="ArgumentException">Thrown if the book does not exist</exception>
        public static void Delete(string isbn)
        {
            // use "using" statement to close connection automatically
            using SqlConnection con = DBHelper.GetDatabaseConnection();

            SqlCommand deleteCmd = new SqlCommand();
            deleteCmd.Connection = con;
            deleteCmd.CommandText = "DELETE FROM Book " +
                                    "WHERE ISBN = @isbn";
            deleteCmd.Parameters.AddWithValue("@isbn", isbn);

            // Open connection to the database
            con.Open();

            // Execute query
            int rows = deleteCmd.ExecuteNonQuery();
            if (rows == 0)
            {
                throw new ArgumentException("A customer with that id does not exist!");
            }
        }

        public static Book GetBook(int id)
        {
            throw new NotImplementedException() ;
        }
    }
}
