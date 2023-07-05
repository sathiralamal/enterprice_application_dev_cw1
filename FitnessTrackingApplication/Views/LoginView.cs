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
using FitnessTrackingApplication.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string login = "";
            login = this.UserControl.LoginUser(textBox1.Text, textBox2.Text);
            if (login.Length > 0)
            {
                LoginInfor.UserID = login;

                var app = new MainView();
                app.Show();
                app.Activate();
                this.Visible = false;

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

            this.Visible = false;
            this.Hide();

        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            messagelable.Text = "";
            messagelable.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
