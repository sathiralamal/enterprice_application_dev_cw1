using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public List<Food> foods { get; set; } = null;
        public DateTime dateTime { get; set; }
        public string Name { get; set; } = null;
    }
}
