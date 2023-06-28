using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private FitnessAppContext context;

       public FoodRepository()
        {
            this.context = new FitnessAppContext();
        }

        public List<Food> GetAll()
        {
            var Foods = context.Foods.ToList();
            return Foods;
        }

        public Food GetById(int id)
        {
            var Food = context.Foods.Find(id);
            return Food;
        }
        public void CreateFood(Food food)
        {
            context.Foods.Add(food);
            context.SaveChanges();

        }

    
        public void DeleteById(int id)
        {
            var food = context.Foods.Find(id);
            context.Foods.Remove(food);
            context.SaveChanges();
        }

        public void UpdateById(Food food, int id)
        {
            food.Id= id;
            //context.Foods.Update(food);
            //context.SaveChanges();

            using (var db = new FitnessAppContext())
            {
                var result = db.Foods.SingleOrDefault(b => b.Id == id);
                if (result != null)
                {
                    result.Id = id;
                    result.Name = food.Name;
                    result.calories = food.calories;
                    result.amount = food.amount;
                    db.SaveChanges();
                }
            }
        }
    }
}
