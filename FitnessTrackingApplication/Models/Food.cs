using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Food
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int calories { get; set; }
        public float amount { get; set; }
        public ICollection<Meal> Meals { get; } 
    }
}
