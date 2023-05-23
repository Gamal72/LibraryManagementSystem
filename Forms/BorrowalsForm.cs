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
    public partial class BorrowalsForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm;

        public BorrowalsForm(Form1 main)
        {
            InitializeComponent();
            this.mainForm = main;
            refreshTable();
        }

        private void refreshTable()
        {
            string query = "SELECT BorrowID, B.Name, Borrow_Date, Return_Date, Copy_Number FROM Borrows as BR, Book as B Where B.ISBN = BR.ISBN AND[User_ID] = " + mainForm.currentUser.id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            borrowalsView.DataSource = dt;
        }
    }
}
