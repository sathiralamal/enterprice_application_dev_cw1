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
        List<Meals> GetAll();
        Meal GetById(int id);
        void CreateExersise(Meal meal);
        void DeleteById(int id);
        void UpdateById(Meal meal, int id);
    }
}
