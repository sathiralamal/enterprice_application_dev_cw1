using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTrackingApplication.Controller;

namespace FitnessTrackingApplication.Views
{
    public partial class LoginView : Form
    {
        private UserController UserControl;
        public LoginView(UserController userControl)
        {
            InitializeComponent();
            this.UserControl = userControl;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            login = this.UserControl.LoginUser(textBox1.Text, textBox2.Text);
            if (login)
            {
                var app = new ApplicationView();
                app.Show();
                this.Close();
            }
            else
            {
                messagelable.Text = "Invalid users try again";
                messagelable.BackColor = Color.Red;
                messagelable.Visible = true;
            }
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            CreateUserView createUserView = new CreateUserView(UserController.GetInstance());
            createUserView.Activate();
            createUserView.Show();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            messagelable.Text = "";
            messagelable.Visible = false;
        }
    }
}
