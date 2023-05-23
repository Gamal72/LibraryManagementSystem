using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class RegisterForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm = null;
        //ADD PHONE NUMBER
       
        public RegisterForm(Form1 main)
        {
            InitializeComponent();
            mainForm = main;
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            int id;
            bool valid = int.TryParse(idText.Text, out id);
            string pass = passText.Text;
            String query = "SELECT * FROM [User] WHERE [User_ID] = " + id+ ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            Regex validatePhoneNumberRegex = new Regex("^\\+?[0-9]{11,14}$");
            if (!valid)
            {
                MessageBox.Show("ID has to be an integer.");
            }
            else if (reader.Read())
            {
                MessageBox.Show("User already exists, please try logging in.");
            } else if (!validateEmailRegex.IsMatch(emailText.Text))
            {
                MessageBox.Show("Please enter a valid email.");
            } else if (!validatePhoneNumberRegex.IsMatch(phoneText.Text))
            {
                MessageBox.Show("Please enter a valid phone number.");
            }
            else
            {
                reader.Close();
                string fName = fNameText.Text;
                string lName = lNameText.Text;
                string role = "User";
                string email = emailText.Text;
                string phone = phoneText.Text;

                

                query = "INSERT INTO [User] VALUES (" + id + ",'" + role + "','" + fName + "','" + lName + "','" + email + "','" + pass + "','"+phone+"');";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                MessageBox.Show("Registration Successful. Welcome " + fName + "!");


                mainForm.currentUser = new User(id, fName, lName, role, email, pass, phone);
                mainForm.openChildForm(new BrowseForm(mainForm));
                mainForm.changeDashboard(true);
            }
            connection.Close();
        }
    }
}
