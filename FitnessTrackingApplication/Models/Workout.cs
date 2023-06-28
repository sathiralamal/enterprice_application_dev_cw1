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
        
        public int Id { get; set; }
       public List<Exercise> exercises { get; set; } = null!;
        public float TotalCalories { get; set;}
    }
}
