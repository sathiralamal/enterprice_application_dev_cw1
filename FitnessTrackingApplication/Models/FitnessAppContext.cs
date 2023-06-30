using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessTrackingApplication.Models
{
    public class FitnessAppContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Food> Foods { get; set; } = null!;
        public DbSet<Exercise> Exercises { get; set; } = null!;
        public DbSet<Meal> Meals { get; set; } = null!;
        public DbSet<Workout> Workouts { get; set; } = null!;


        public FitnessAppContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "fitnessapp1.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Food>()
                .HasMany(x => x.Meals)
                .WithMany(x => x.Foods)
                .UsingEntity(j=>j.ToTable("FoodMeal"));

           modelBuilder.Entity<Exercise>()
               .HasMany(x => x.Workouts)
               .WithMany(x=> x.Exercises)
               .UsingEntity(j => j.ToTable("ExercisesWorkout"));

            //OnModelCreating(modelBuilder);
        }

      //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      // {
      //    optionsBuilder.UseSqlite($"Data Source={DbPath}");
      //  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=tcp:ead-server.database.windows.net,1433;Initial Catalog=EAD_DATABASE_TEST;Persist Security Info=False;User ID=admin_ead;Password=Anterpri_cw2@2023;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

   



    }
}
