using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public class UserWeightRepositiry : IUserWeightRepository
    {
        FitnessAppContext context;
        public UserWeightRepositiry()
        {
            context = new FitnessAppContext();
        }

        public void Create(UserWeaight userWeaight)
        {
            context.UserWeaights.Add(userWeaight);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var userWeaight = context.UserWeaights.Find(id);
            context.UserWeaights.Remove(userWeaight);
            context.SaveChanges();
        }

        public List<UserWeaight> GetAll()
        {
            var userWeaights = context.UserWeaights.ToList();
            return userWeaights;
        }

        public void Update(UserWeaight userWeaight ,int id)
        {
            userWeaight.Id = id;
            using (var db = new FitnessAppContext())
            {
                var result = db.UserWeaights.SingleOrDefault(b => b.Id == id);
                if (result != null)
                {
                    result.Id = id;
                    result.Weight = userWeaight.Weight;
                    result.dateTime = userWeaight.dateTime;
                    result.UserName = userWeaight.UserName;

                    db.SaveChanges();
                }
            }
        }
    }
}
