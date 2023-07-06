using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTrackingApplication.Models;
namespace FitnessTrackingApplication.Utils
{
    public class DbInitialiser
    {
        private readonly FitnessAppContext _context;

        public DbInitialiser(FitnessAppContext context)
        {
            _context = context;
        }

        public void Run()
        {
            // TODO: Add initialisation logic.
           // builder.Services.AddTransient<DbInitialiser>();

        }
    }
}
