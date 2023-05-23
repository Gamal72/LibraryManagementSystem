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

namespace Library_Management_System.Forms
{
    public partial class ReportForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm;

        public ReportForm(Form1 main)
        {
            InitializeComponent();
            this.mainForm = main;
            loadTable();
        }

        private void loadTable()
        {
            reportView.Rows.Clear();
            connection.Open();

            reportView.Columns.Add("Metric", "Metric");
            reportView.Columns.Add("Value", "Value");

            // Calculate the width for each column
            int columnWidth = reportView.Width / 2;

            // Set the column width for each column
            foreach (DataGridViewColumn column in reportView.Columns)
            {
                column.Width = columnWidth;
            }

            // Retrieve the number of Users
            string query = "Select count(User_ID) as cnt from [User]";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            string cnt = "0";
            if (reader.Read())
            {
                cnt = reader["cnt"].ToString();

            }
            reader.Close();
            reportView.Rows.Add("Number of users", cnt);

            // Retrieve the number of Users
            query = "Select count(ISBN) as cnt from Book";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();

            cnt = "0";
            if (reader.Read())
            {
                cnt = reader["cnt"].ToString();

            }
            reader.Close();

            reportView.Rows.Add("Number of books", cnt);


            // Retrieve the max borrowing user
            query = "Select User_ID from (Select User_ID, count(*) as Borrow_count from Borrows group by User_ID) as x where Borrow_count >= all(Select count(User_ID) from Borrows group by User_ID)";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            string userID = "0";
            if (reader.Read())
            {
                userID = reader["User_ID"].ToString();

            }

            reader.Close();

            query = "Select First_Name, Last_Name from [User] where User_ID = " + userID;
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            string name = "0";
            if (reader.Read())
            {
                name = reader["First_Name"].ToString() + " " + reader["Last_Name"].ToString();
            }
            reader.Close();

            reportView.Rows.Add("Most borrowing user", name);


            // Retrieve the max borrowing user
            query = "Select ISBN from (Select ISBN, count(*) as Borrow_count from Borrows group by ISBN) as x where Borrow_count >= all(Select count(ISBN) from Borrows group by ISBN)";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            string isbn = "0";
            if (reader.Read())
            {
                isbn = reader["ISBN"].ToString();

            }

            reader.Close();

            query = "Select Name from [Book] where ISBN = " + isbn;
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            name = "0";
            if (reader.Read())
            {
                name = reader["Name"].ToString();

            }
            reader.Close();

            reportView.Rows.Add("Most borrowed book", name);

            // Retrieve the Number of available book copies
            query = "Select count(*) as cnt from Book_copy where Available = 'True'";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();

            cnt = "0";
            if (reader.Read())
            {
                cnt = reader["cnt"].ToString();

            }

            reportView.Rows.Add("Number of available book copies", cnt);
            
            connection.Close();
        }
    }
}
