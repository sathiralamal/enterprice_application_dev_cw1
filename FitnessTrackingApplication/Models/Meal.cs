using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Meal
    {
        
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public string Name { get; set; } = null!;
        public float TotalCatories { get; set; }
        public bool IsRecursive { get; set; }
        public ICollection<Food> Foods { get; }
    }
}
