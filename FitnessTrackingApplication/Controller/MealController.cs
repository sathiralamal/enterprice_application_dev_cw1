using FitnessTrackingApplication.Models;
using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Controller
{
    public class MealController
    {
        private IMealRepository mealRepository;

        public MealController() {
            this.mealRepository = new MealRepository();
        }

        public List<Meal> GetAll()
        {
            return this.mealRepository.GetAll();
        }

        public List<Meal> GetAllMealWithFood()
        {
            return mealRepository.GetAllMealWithFood();

        }
        public bool CreateMeal(Meal meal)
        {
            bool status = false;
            try
            {
                this.mealRepository.CreateMeals(meal);
              
                
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Update(Meal meal, int id)
        {
            bool status = false;
            try
            {
                this.mealRepository.UpdateById(meal, id);
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
                this.mealRepository.DeleteById(id);
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
