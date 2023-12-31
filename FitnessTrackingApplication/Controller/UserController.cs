﻿using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTrackingApplication.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FitnessTrackingApplication.Views;

namespace FitnessTrackingApplication.Controller
{
    public class UserController
    {
        private IUserRepository userRepository;
        private static UserController instance;

        public UserController()
        {
            this.userRepository = new UserRepository(new FitnessAppContext());
        }

        public string LoginUser(string username, string password)
        {
            string login = "";

            User user = this.userRepository.GetUser(username, password);
            if (user.UserName!= null)
            {
                login = user.UserName;
            }
            return login;
        }

        public bool CreateUser(User user) {
            bool isSuccss = false;
            User newUser = new User()
            {
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                Weight = user.Weight
            };

            try
            {
                this.userRepository.CreateUser(user);
                


            }catch (Exception ex)
            {   
                isSuccss = false;
                Console.WriteLine(ex.Message);
            }
            return isSuccss;
        }

        public static UserController GetInstance()
        {
            if(instance == null)
            {
                instance = new UserController();
            }
            return instance;
        }
    }
}
