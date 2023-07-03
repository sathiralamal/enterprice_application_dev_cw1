using LiveCharts.WinForms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;

namespace FitnessTrackingApplication.Views

{
    public partial class DashbordView : Form
    {
        WorkoutController workoutController;
        MealController mealController;
        UserController userControl;
        User user;

        List<Meal> LastWeekMeal;
        List<Meal> LastMonthMeal;

        List<Workout> LastWeekWorkout;
        List<Workout> LastMonthkWorkout;

        double TotalBurnCalories = 0;
        double TotalEatCalories = 0;

        public DashbordView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            workoutController = new WorkoutController();
            mealController = new MealController();
            userControl = new UserController();

            LastMonthMeal = mealController.GetLastMonthMealWithFood();
            LastWeekMeal = mealController.GetLastWeekMealWithFood();

            LastWeekWorkout = workoutController.GetAllLastWeek();
            LastMonthkWorkout = workoutController.GetAllLastMonth();

            


        }

        private double[] getMealTotalCaloryList(List<Meal> meals)
        {
            List<double> caloryList = new List<double>();
            meals.ForEach(m =>
            {
                caloryList.Add(m.TotalCatories);
            });
            return caloryList.ToArray();
        }

        private double[] getWorkoutTotalCaloryList(List<Workout> meals)
        {
            List<double> caloryList = new List<double>();
            meals.ForEach(m =>
            {
                caloryList.Add(m.TotalCalories);
            });
            return caloryList.ToArray();
        }


        private void DashbordView_Load(object sender, EventArgs e)
        {
            double[] dataMeal1 = getMealTotalCaloryList(LastMonthMeal);
            double[] dataWorkouts = getWorkoutTotalCaloryList(LastMonthkWorkout);

            ShowLineChart1(dataMeal1, dataWorkouts);
            ShowPiChart1(LastMonthMeal, LastMonthkWorkout);
        }



        private void ShowLineChart1(double[] data1, double[] data2)
        {
            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = data1,
                    Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 2 },
                    Fill = null,
                    Name = "Meal Total calories",

                },
                 new LineSeries<double>
                {
                    Values = data2,
                    Stroke = new SolidColorPaint(SKColors.IndianRed) { StrokeThickness = 2 },
                    Fill = null,
                    Name = "Workout Burn calories",


                }
            };
        }


        private void ShowPiChart1(List<Meal> meatData, List<Workout> workoutsData)
        {
            meatData.ForEach(m =>
            {
                TotalEatCalories = TotalEatCalories + m.TotalCatories;
            });

            workoutsData.ForEach(m =>
            {
                TotalBurnCalories = TotalBurnCalories + m.TotalCalories;
            });


            pieChart1.Series = new List<ISeries>
             {
                 new PieSeries<double>
                  {
                       Values = new List<double> { 2 },
                       Pushout = 8,
                       Stroke = new SolidColorPaint(SKColors.Red)
                    },
                new PieSeries<double> { Values = new List<double> { TotalBurnCalories } },
                new PieSeries<double> { Values = new List<double> { TotalEatCalories } }

               };
        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }
    }
}
