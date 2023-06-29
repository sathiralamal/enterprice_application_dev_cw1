using FitnessTrackingApplication.Models;
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

        public void CreateExersise(Meal meal)
        {
            context.Meals.Add(meal);
            context.SaveChanges();
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
                    result.foods = meal.foods;
                    db.SaveChanges();
                }
            }
        }
    }
}
