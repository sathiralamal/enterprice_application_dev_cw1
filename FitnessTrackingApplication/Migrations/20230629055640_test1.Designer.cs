﻿// <auto-generated />
using System;
using FitnessTrackingApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessTrackingApplication.Migrations
{
    [DbContext(typeof(FitnessAppContext))]
    [Migration("20230629055640_test1")]
    partial class test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("FitnessTrackingApplication.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Calories")
                        .HasColumnType("REAL");

                    b.Property<string>("ExerciseDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkoutId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MealId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("amount")
                        .HasColumnType("REAL");

                    b.Property<int>("calories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("TotalCalories")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Exercise", b =>
                {
                    b.HasOne("FitnessTrackingApplication.Models.Workout", null)
                        .WithMany("exercises")
                        .HasForeignKey("WorkoutId");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Food", b =>
                {
                    b.HasOne("FitnessTrackingApplication.Models.Meal", null)
                        .WithMany("foods")
                        .HasForeignKey("MealId");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Meal", b =>
                {
                    b.Navigation("foods");
                });

            modelBuilder.Entity("FitnessTrackingApplication.Models.Workout", b =>
                {
                    b.Navigation("exercises");
                });
#pragma warning restore 612, 618
        }
    }
}