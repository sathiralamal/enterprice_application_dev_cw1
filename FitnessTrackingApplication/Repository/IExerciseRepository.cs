using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public interface IExerciseRepository
    {
        List<Exercise> GetAll();
        Exercise GetById(int id);
        void CreateExersise(Exercise exercise);
        void DeleteById(int id);
        void UpdateById(Exercise exercise, int id);
    }
}
