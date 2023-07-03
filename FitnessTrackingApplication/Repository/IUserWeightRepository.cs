using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public interface IUserWeightRepository
    {
        void Create(UserWeaight userWeaight);
        void Delete(int id);

        void Update(UserWeaight userWeaight ,int id);

        List<UserWeaight> GetAll();
        
    }
}
