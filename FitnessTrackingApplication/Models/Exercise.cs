using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string? ExerciseName { get; set;}
        public string? ExerciseDescription { get; set; }
        public float Calories { get; set; }
    }
}
