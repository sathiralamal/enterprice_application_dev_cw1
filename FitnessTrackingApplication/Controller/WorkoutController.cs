using FitnessTrackingApplication.Models;
using FitnessTrackingApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Controller
{
    public class WorkoutController
    {
        private IWorkoutRepository workoutRepository;
        
        public WorkoutController()
        {
            this.workoutRepository = new WorkoutRepository();
        }

        public List<Workout> GetAllWorkOut()
        {
            List<Workout> allWorkouts = null; ;
            try
            {
                allWorkouts = this.workoutRepository.GetAllWorkOut();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return allWorkouts;
        }

        public bool CreateWorkout(Workout workout)
        {
            bool status = false;
            try
            {
                this.workoutRepository.CreateWorkout(workout);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public bool Update(Workout workout, int id)
        {
            bool status = false;
            try
            {
                this.workoutRepository.UpdateById(workout, id);
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
                this.workoutRepository.DeleteById(id);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);
            }
            return status;
        }

        public List<Workout> GetAllLastWeek()
        {
            List<Workout> allWorkouts = null; ;
            try
            {
                allWorkouts = this.workoutRepository.GetLastWeekWorkout();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return allWorkouts;
        }

        public List<Workout> GetAllLastMonth()
        {
            List<Workout> allWorkouts = null; ;
            try
            {
                allWorkouts = this.workoutRepository.GetLastMonthWorkout();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return allWorkouts;
        }
    }
}
