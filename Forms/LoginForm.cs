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

    public partial class LoginForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source="+SRC+";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm = null;
        public LoginForm(Form1 main)
        {
            InitializeComponent();
            mainForm = main;
            CenterToParent();

        }
        //ADD PHONE NUMBER
        private void loginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            int id;
            bool valid = int.TryParse(usernameText.Text, out id);
            string pass = passwordText.Text;
            String query = "SELECT * FROM [User] WHERE [User_ID] = " + id + " AND [Password]='" + pass + "';";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() && valid)
            {
                string fName = reader["First_Name"].ToString();
                string lName = reader["Last_Name"].ToString();
                string role = reader["Role"].ToString();
                string email = reader["Email"].ToString();
                string phone = reader["Phone_Number"].ToString();

                mainForm.currentUser = new User(id, fName, lName, role, email, pass, phone);
                mainForm.openChildForm(new BrowseForm(mainForm));
                mainForm.changeDashboard(true);
            }
            else
            {
                MessageBox.Show("Try again, wrong credentials.");
            }
            connection.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new RegisterForm(mainForm));
        }

    }
}
