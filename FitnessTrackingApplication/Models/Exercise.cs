using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Exercise
    {
      
        public int Id { get; set; }
        public string ExerciseName { get; set; } = null!;
        public string ExerciseDescription { get; set; } = null!;
        public float Calories { get; set; }
    }
}
