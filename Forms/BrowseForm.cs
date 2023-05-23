using Library_Management_System.Forms;
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

namespace Library_Management_System
{
    public partial class BrowseForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm;
        private string currentFilter = "B.ISBN";

        public BrowseForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            isbnButton.Checked = true;
            if (mainForm.currentUser.role != "Admin")
            {
                updateButton.Visible = false;
                addBookButton.Visible = false;
            }
            refreshTable("");
        }

        private void refreshTable(string filter)
        {
            string query = "SELECT B.ISBN, B.Name as Name, B.Author, B.Publication_Year as Published, C.Name as Category, Count(*) as Copies " +
                    "FROM Book as B, Category as C, Book_Copy as BC " +
                    "WHERE B.CID = C.CID AND B.ISBN = BC.ISBN AND BC.Available = 'True' AND " +
                    currentFilter + " LIKE '" + filter + "%' " +
                    "GROUP BY B.ISBN, B.Name, B.Author, B.Publication_Year, C.Name";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            string ISBN = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            int userId = mainForm.currentUser.id;
            connection.Open();
            string query = "SELECT TOP 1 Copy_Number FROM Book_Copy " +
                           "WHERE ISBN = " + ISBN + " and Available = 'True'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string copyNumber = reader["Copy_Number"].ToString();
            
            reader.Close();
            query = "Update Book_Copy " +
                    "Set Available = 'False' " +
                    "Where Copy_Number = " + copyNumber + " AND ISBN = " + ISBN;
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();


            string borrowDate = DateTime.Today.ToString("yyyy-MM-dd");
            string returnDate = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");
            query = "Insert Into Borrows (Borrow_Date, Return_Date, User_ID, ISBN, Copy_Number) " +
                    "Values('" + borrowDate + "', '" + returnDate + "', " + userId + ", " + ISBN + ", " + copyNumber + ")";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Borrowed " + name + " successfully, please return it by " + returnDate + ".");
            refreshTable("");
            connection.Close();
        }

        private void isbnButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFilter = "B.ISBN";
        }

        private void nameButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFilter = "B.Name";
        }

        private void authorButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFilter = "B.Author";
        }

        private void categoryButton_CheckedChanged(object sender, EventArgs e)
        {
            currentFilter = "C.Name";
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            refreshTable(filterText.Text);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ISBN = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string copies = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            mainForm.openChildForm(new UpdateBookForm(mainForm, ISBN, copies));
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new AddBookForm(mainForm));
        }
    }
}
