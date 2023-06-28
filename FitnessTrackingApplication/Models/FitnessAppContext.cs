using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FitnessTrackingApplication.Models
{
    public class FitnessAppContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get;set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Workout> Workouts { get; set; }


        public FitnessAppContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "fitnessapp.db");
        }

       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
       //     optionsBuilder.UseSqlite($"Data Source={DbPath}");
       // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=tcp:ead-server.database.windows.net,1433;Initial Catalog=EAD_DATABASE_TEST_2023-06-28T07-16Z;Persist Security Info=False;User ID=admin_ead;Password=Anterpri_cw2@2023;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

   



    }
}
