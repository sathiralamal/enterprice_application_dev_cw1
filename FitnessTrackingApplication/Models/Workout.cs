using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public List<Exercise> exercises { get; set; } = null;
        public float TotalCalories { get; set;}
    }
}
