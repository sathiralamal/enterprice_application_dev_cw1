using FitnessTrackingApplication.Models;
using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Controller
{
    public class ExerciseController
    {
        private IExerciseRepository exerciseRepository;

        public ExerciseController()
        {
            this.exerciseRepository = new ExerciseRepository();
        }

        public List<Exercise> GetFoods()
        {
            return this.exerciseRepository.GetAll();
        }

        public bool Create(Exercise exercise)
        {
            bool status = false;
            try
            {
                this.exerciseRepository.CreateExersise(exercise);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Update(Exercise food, int id)
        {
            bool status = false;
            try
            {
                this.exerciseRepository.UpdateById(food, id);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            try
            {
                this.exerciseRepository.DeleteById(id);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
