using FitnessTrackingApplication.Models;
using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Controller
{
    public class UserWeightController
    {
        private IUserWeightRepository userWeightRepository;

        public UserWeightController()
        {
            this.userWeightRepository = new UserWeightRepositiry();
        }

        public List<UserWeaight> GetUserWeight()
        {
            return this.userWeightRepository.GetAll();
        }

        public bool Create(UserWeaight userWeaight)
        {
            bool status = false;
            try
            {
                this.userWeightRepository.Create(userWeaight);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Update(UserWeaight userWeaight,int id)
        {
            bool status = false;
            try
            {
                this.userWeightRepository.Update(userWeaight,id);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            try
            {
                this.userWeightRepository.Delete(id);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
