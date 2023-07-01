using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public float TotalCalories { get; set;}
        public List<Exercise> Exercises { get; set; }
        public bool IsRecursive { get; set; }

    }
}
