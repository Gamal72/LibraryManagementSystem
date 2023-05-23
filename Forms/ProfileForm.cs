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

namespace Library_Management_System.Forms
{
    public partial class ProfileForm : Form
    {
        private const string SRC = "LAPTOP-R14V0TK1\\RADY";
        SqlConnection connection = new SqlConnection("Data Source=" + SRC + ";Initial Catalog=Library;Integrated Security=True");
        private Form1 mainForm = null;
        //ADD PHONE NUMBER

        public ProfileForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            init();
        }

        private void init()
        {
            idText.Text = "" + mainForm.currentUser.id;
            fNameText.Text = mainForm.currentUser.fName;
            lNameText.Text = mainForm.currentUser.lName;
            emailText.Text = mainForm.currentUser.email;
            passText.Text = mainForm.currentUser.password;
            phoneText.Text = mainForm.currentUser.phoneNumber;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idText.Text);
            string fName = fNameText.Text;
            string lName = lNameText.Text;
            string email = emailText.Text;
            string pass = passText.Text;
            string phone = phoneText.Text;

            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            Regex validatePhoneNumberRegex = new Regex("^\\+?[0-9]{11,14}$");
            if (!validateEmailRegex.IsMatch(emailText.Text))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }
            if (!validatePhoneNumberRegex.IsMatch(phoneText.Text))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            if (connection.State != ConnectionState.Open)
                connection.Open();
            String query = "UPDATE [User] SET First_Name = '" + fName + "'"
                + ", Last_Name = '" + lName + "', Email = '" + email + "', Password = '" + pass + "', Phone_Number = '" + phone + "' WHERE User_ID = " + id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            reader.Close();

            mainForm.currentUser.fName = fName;
            mainForm.currentUser.lName = lName;
            mainForm.currentUser.email = email;
            mainForm.currentUser.password = pass;
            mainForm.currentUser.phoneNumber = phone;
            MessageBox.Show("Saved Successfully.");

            mainForm.openChildForm(new BrowseForm(mainForm));            
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            String query = "Delete From [USER] Where User_ID = " + mainForm.currentUser.id;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();

            MessageBox.Show("Deleted account successfully!");
            mainForm.changeDashboard(false);
            mainForm.openChildForm(new LoginForm(mainForm));
            connection.Close();
        }
    }
}
