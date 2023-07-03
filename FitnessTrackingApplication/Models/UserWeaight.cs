using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackingApplication.Models
{
    public class UserWeaight
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public double Weight { get; set; }
        public DateTime dateTime { get; set; }
    }
}
