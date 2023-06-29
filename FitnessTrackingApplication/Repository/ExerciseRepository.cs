using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Repository
{
    public class ExerciseRepository : IExerciseRepository

    {
        private FitnessAppContext context;


        public ExerciseRepository() {
            this.context = new FitnessAppContext();

        }

        public void CreateExersise(Exercise exercise)
        {
            context.Exercises.Add(exercise);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var exercise = context.Exercises.Find(id);
            context.Exercises.Remove(exercise);
            context.SaveChanges();
        }

        public List<Exercise> GetAll()
        {
            var Exercisers = context.Exercises.ToList();
            return Exercisers;
        }

        public Exercise GetById(int id)
        {
            var exercise = context.Exercises.Find(id);
            return exercise;
        }

        public void UpdateById(Exercise exercise, int id)
        {
            exercise.Id = id;
            
            using (var db = new FitnessAppContext())
            {
                var result = db.Exercises.SingleOrDefault(b => b.Id == id);
                if (result != null)
                {
                    result.Id = id;
                    result.ExerciseName = exercise.ExerciseName;
                    result.Calories = exercise.Calories;
                    result.ExerciseDescription = exercise.ExerciseDescription;
                    db.SaveChanges();
                }
            }
        }
    }
}
