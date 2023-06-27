using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    internal interface IUserRepository : IDisposable
    {
        User GetUser(string userName ,string password);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
