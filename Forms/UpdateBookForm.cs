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
    public partial class UpdateBookForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm;
        private string currentBook, copies;
        public UpdateBookForm(Form1 main, string ISBN, string copies)
        {
            InitializeComponent();
            this.mainForm = main;
            this.currentBook = ISBN;
            this.copies = copies;
            loadData();
        }


        private void loadData()
        {
            connection.Open();
            String query = "Select CID, Name, Author, Publication_Year from Book Where ISBN = " + currentBook;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            ISBNText.Text = currentBook;
            copiesText.Text = copies;
            reader.Read();
            cidText.Text = reader["CID"].ToString();
            bNameText.Text = reader["Name"].ToString();
            authorText.Text = reader["Author"].ToString();
            yearText.Text = reader["Publication_Year"].ToString();
            reader.Close();
            connection.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            int ISBN, cid, copies, year;
            string name = bNameText.Text;
            string author = authorText.Text;


            if (!int.TryParse(ISBNText.Text, out ISBN))
            {
                MessageBox.Show("Please enter valid ISBN.");
                return;
            }
            if (!int.TryParse(yearText.Text, out year) ||
                (year < 0 || year > int.Parse(DateTime.Now.Year.ToString())))
            {
                MessageBox.Show("Please enter valid year.");
                return;
            }
            if (!int.TryParse(cidText.Text, out cid))
            {
                MessageBox.Show("Please enter valid CID.");
                return;
            }
            if (!int.TryParse(copiesText.Text, out copies) || copies <= 0)
            {
                MessageBox.Show("Please enter valid copy numbers.");
                return;
            }
            //Check if category is there
            String query = "SELECT * FROM [Category] WHERE [CID] = " + cid + ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Category does not exist.");
                reader.Close();
                connection.Close();
                return;
            }
            reader.Close();

            query = "Update Book " +
                "Set ISBN = " + ISBN + ", Name = '" + name + "', CID = " + cid +
                ", Author = '" + author + "', Publication_Year = " + year +
                "where ISBN = " + ISBN;
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            reader.Close();

            MessageBox.Show("Updated book successfully!");
            mainForm.openChildForm(new BrowseForm(mainForm));
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (connection.State != ConnectionState.Open)
                connection.Open();

            String query = "Delete From Book Where ISBN = " + currentBook;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();

            MessageBox.Show("Deleted book successfully!");
            mainForm.openChildForm(new BrowseForm(mainForm));
            connection.Close();
        }
    }
}
