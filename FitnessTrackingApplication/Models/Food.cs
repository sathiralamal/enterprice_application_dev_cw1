using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public int calories { get; set; }
        public float amount { get; set; }
    }
}
