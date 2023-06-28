using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public interface IFoodRepository
    {
        //this return List of Foods
        List<Food> GetAll();
        Food GetById(int id);
        void CreateFood(Food food);
        void DeleteById(int id);
        void UpdateById(Food food,int id);

    }
}
