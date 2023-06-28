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
            textBoxWeight.Text = "";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;
            string weight = textBoxWeight.Text;

            if (!userName.IsNullOrEmpty() && !password.IsNullOrEmpty() && !email.IsNullOrEmpty() && !weight.IsNullOrEmpty())
            {
                User user = new User();
                user.UserName = userName;
                user.Password = password;
                user.Email = email;
                user.Weight = float.Parse(weight, CultureInfo.InvariantCulture.NumberFormat);
                try
                {
                    userController.CreateUser(user);
                    messageBox.Text = "creating user";
                    messageBox.BackColor = Color.Green;
                    messageBox.Visible = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                messageBox.Text = "Error in creating user";
                messageBox.BackColor = Color.Red;
                messageBox.Visible = true;
            }
        }

      
    }
}
