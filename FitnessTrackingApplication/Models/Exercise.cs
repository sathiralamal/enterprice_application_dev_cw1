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

        [Key]
        public int Id { get; set; }
        public string ExerciseName { get; set; } = null!;
        public string? ExerciseDescription { get; set; }
        public float Calories { get; set; }
        public ICollection<Workout> Workouts { get; set; } 
    }
}
