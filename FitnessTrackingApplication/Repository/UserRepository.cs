using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    internal class UserRepository : IUserRepository, IDisposable
    {
        private FitnessAppContext context;

        public UserRepository(FitnessAppContext context)
        {
            this.context = context;
        }

        public void CreateUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            context.Users.Remove(user);
        }

        public User GetUser(string userName, string password)
        {
            var user = context.Users.FirstOrDefault(x => x.UserName == userName&&x.Password==password);
            User existingUser = new User();
            if(user != null)
            {
                existingUser.Id = user.Id;
                existingUser.UserName = user.UserName;
                existingUser.Password = user.Password;
                existingUser.Email = user.Email;
                existingUser.Weight = user.Weight;
            }
            
            return existingUser;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
