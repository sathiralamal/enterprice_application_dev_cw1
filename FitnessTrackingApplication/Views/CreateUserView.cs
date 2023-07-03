using Microsoft.IdentityModel.Tokens;
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
using FitnessTrackingApplication.Models;
using System.Globalization;

namespace FitnessTrackingApplication.Views
{
    public partial class CreateUserView : Form
    {
        UserController userController;

        public CreateUserView(UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.cleaserTextFilds();
        }

        private void cleaserTextFilds()
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;
            string weight = "0";

            if (!userName.IsNullOrEmpty() && !password.IsNullOrEmpty() && !email.IsNullOrEmpty() && !weight.IsNullOrEmpty())
            {
                User user = new User();
                user.UserName = userName;
                user.Password = password;
                user.Email = email;
                user.Weight = 0;
                try
                {
                    userController.CreateUser(user);

                    UserController userControl = new UserController();
                    LoginView loginView = new LoginView(userControl);
                    loginView.Activate();
                    loginView.Show();

                    this.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {

            }
        }

        private void CreateUserView_Load(object sender, EventArgs e)
        {

        }
    }
}
