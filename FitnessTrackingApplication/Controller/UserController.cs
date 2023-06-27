using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTrackingApplication.Models;

namespace FitnessTrackingApplication.Controller
{
    public class UserController
    {
        private IUserRepository userRepository;

        public UserController()
        {
            this.userRepository = new UserRepository(new FitnessAppContext());
        }

        public bool LoginUser(string username, string password)
        {
            bool login = true;

            User user = this.userRepository.GetUser(username, password);
            if (user == null)
            {
                login = false;
            }
            return true;
        }
    }
}
