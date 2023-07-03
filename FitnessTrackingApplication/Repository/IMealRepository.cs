using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public interface IMealRepository
    {
        List<Meal> GetAll();
        Meal GetById(int id);
        void CreateMeals(Meal meal);
        void DeleteById(int id);
        void UpdateById(Meal meal, int id);
        List<Meal> GetLastWeekMealWithFood();
        List<Meal> GetLastMonthMealWithFood();
    }
}
