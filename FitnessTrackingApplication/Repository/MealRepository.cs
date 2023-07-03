using FitnessTrackingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public class MealRepository : IMealRepository
    {
        private FitnessAppContext context;

        public MealRepository() {
            context = new FitnessAppContext();
        }

        public void CreateMeals(Meal meal)
        {
            using (var db = new FitnessAppContext())
            {
                meal.Foods.ForEach(food =>
            {
                db.Foods.Attach(food);
            });

                db.Meals.Add(meal);
                db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var meal = context.Meals.Find(id);
            context.Meals.Remove(meal);
            context.SaveChanges();
        }

        public List<Meal> GetAll()
        {
            var meals = context.Meals.ToList();
            return meals;
        }

      
        public Meal GetById(int id)
        {
            var meal = context.Meals.Find(id);
            return meal;
        }

        public void UpdateById(Meal meal, int id)
        {
            meal.Id = id;

            using (var db = new FitnessAppContext())
            {
                var result = db.Meals.SingleOrDefault(b => b.Id == id);
                if (result != null)
                {
                    result.Id = id;
                    result.Name = meal.Name;
                    result.dateTime = meal.dateTime;
                    //result.Foods = meal.Foods;
                    result.IsRecursive = meal.IsRecursive;
                    db.SaveChanges();
                }
            }
        }
        public List<Meal>  GetLastWeekMealWithFood()
        {

            DateTime now = DateTime.Now;
            DateTime lastSunday = now.AddDays(-(int)now.DayOfWeek);
            DateTime previousSunday = lastSunday.AddDays(-7);
            using (var context = new FitnessAppContext())
            {
                var meals = context.Meals
                    .Include(w => w.Foods) // Include the Exercises navigation property
                    .Where(w => w.dateTime >= previousSunday && w.dateTime < lastSunday)
                    .ToList();
                // Return the result
                return meals;
            }
        }
        public List<Meal> GetLastMonthMealWithFood()
        {
            // Get the current date and time
            DateTime now = DateTime.Now;
            // Get the first day of the current month
            DateTime firstDay = new DateTime(now.Year, now.Month, 1);
            // Get the first day of the previous month
            DateTime previousFirstDay = firstDay.AddMonths(-1);
            // Create a DbContext instance
            using (var context = new FitnessAppContext())
            {
                // Query the database for workouts between the previous and current first days
                var meals = context.Meals
                    .Include(w => w.Foods) // Include the Exercises navigation property
                    .Where(w => w.dateTime >= previousFirstDay && w.dateTime < firstDay)
                    .ToList();
                // Return the result
                return meals;
            }
        }


    }
}
