using Library_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{


    public partial class Form1 : Form
    {

        private Form activeForm = null;
        public User currentUser = null;
        public Form1()
        {
            InitializeComponent();
            changeDashboard(false);
            openChildForm(new LoginForm(this));
            CenterToScreen();
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        public void changeDashboard(bool loggedIn)
        {
            loginBtnDashboard.Visible = !loggedIn;
            registerBtnDashboard.Visible = !loggedIn;
            logoutBtnDashboard.Visible = loggedIn;
            if (currentUser != null && currentUser.role == "Admin")
                reportButton.Visible = loggedIn;
            else reportButton.Visible = false;
            profileBtnDashboard.Visible = loggedIn;
            borrowalsBtnDashboard.Visible = loggedIn;
            browseBtnDashboard.Visible = loggedIn;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            openChildForm(new LoginForm(this));
        }

        private void Register_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm(this));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtnDashboard_Click(object sender, EventArgs e)
        {
            currentUser = null;
            changeDashboard(false);
            openChildForm(new LoginForm(this));
        }

        private void profileBtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(this));
        }

        private void browseBtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new BrowseForm(this));
        }

        private void borrowalsBtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new BorrowalsForm(this));
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ReportForm(this));
        }
    }
    public class User
    {
        public int id;
        public string fName, lName, role;
        public string email, password;
        public string phoneNumber;

        public User(int id, string fName, string lName, string role, string email, string password, string phoneNumber)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.role = role;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
    }
}
