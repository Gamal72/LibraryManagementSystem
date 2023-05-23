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
    public partial class AddBookForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm = null;
        //ADD PHONE NUMBER

        public AddBookForm(Form1 main)
        {
            InitializeComponent();
            mainForm = main;
        }
        private void addButton_Click_1(object sender, EventArgs e)
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
            //Check ISBN is not there
            String query = "SELECT * FROM [Book] WHERE [ISBN] = " + ISBN + ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Book already exists, please update the existing book.");
                reader.Close();
                connection.Close();
                return;
            }
            reader.Close();
            //Check if category is there
            query = "SELECT * FROM [Category] WHERE [CID] = " + cid + ";";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Category does not exist.");
                reader.Close();
                connection.Close();
                return;
            }
            reader.Close();

            query = "INSERT INTO [Book] (ISBN, Name, CID, Author, Publication_Year) " +
                "VALUES("+ISBN+",'"+name+"',"+cid+",'"+author+"','"+year+"')";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            reader.Close();

            for (int i = 1; i <= copies; i++)
            {
                query = "INSERT INTO [Book_Copy] (ISBN, Copy_Number, Available) " +
                "VALUES(" + ISBN + "," + i + ",'True')";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Close();
            }
            MessageBox.Show("Added book successfully!");
            mainForm.openChildForm(new BrowseForm(mainForm));            
            connection.Close();
        }
    }
}
