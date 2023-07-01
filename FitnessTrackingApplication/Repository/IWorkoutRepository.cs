using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public interface IWorkoutRepository
    {
        List<Workout> GetAllWorkOut();
        Workout GetById(int id);
        void CreateWorkout(Workout workout);
        void DeleteById(int id);
        void UpdateById(Workout workout, int id);
    }
}
