using FitnessTrackingApplication.Models;
using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Controller
{
    public class FoodController
    {
        private IFoodRepository foodRepository;

        public FoodController()
        {
            this.foodRepository = new FoodRepository();
        }

        public List<Food> GetFoods()
        {
            return this.foodRepository.GetAll();
        }

        public bool Create(Food food)
        {
            bool status = false;
            try
            {
                this.foodRepository.CreateFood(food);
                status = true;
            }catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Update(Food food ,int id)
        {
            bool status = false;
            try
            {
                this.foodRepository.UpdateById(food,id);
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
                this.foodRepository.DeleteById(id);
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
