using FitnessTrackingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private FitnessAppContext context;

        public WorkoutRepository() {
            context = new FitnessAppContext();

        }

        public void CreateWorkout(Workout workout)
        {
            using (var db = new FitnessAppContext())
            {
                workout.Exercises.ForEach(exercise =>
                {
                    db.Exercises.Attach(exercise);
                });

                db.Workouts.Add(workout);
                db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var workout = context.Workouts.Find(id);
            context.Workouts.Remove(workout);
            context.SaveChanges();
        }

        public List<Workout> GetAllWorkOut()
        {
            var workouts = context.Workouts.Include(w => w.Exercises).ToList();
            return workouts;
        }

        public Workout GetById(int id)
        {
            var workout = context.Workouts.Find(id);
            return workout;
        }

        public void UpdateById(Workout workout, int id)
        {
            workout.Id = id;

            using (var db = new FitnessAppContext())
            {
                // var result = db.Workouts.AsNoTracking().SingleOrDefault(b => b.Id == id);
                var result = db.Workouts.SingleOrDefault(b => b.Id == id);
                if (result != null)
                {
                    db.ChangeTracker.Entries<Workout>().Where(e => e.Entity.Id == id).Single().State = EntityState.Detached;
                    
                    result.Id = id;
                    result.Exercises = workout.Exercises;
                    result.TotalCalories = workout.TotalCalories;
                    result.IsRecursive = workout.IsRecursive;
                    db.SaveChanges();
                }
            }
        }
    }
}
