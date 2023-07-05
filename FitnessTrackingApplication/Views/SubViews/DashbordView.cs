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
        UserWeightController weightController;
        User user;

        List<Meal> LastWeekMeal;
        List<Meal> LastMonthMeal;

        List<Workout> LastWeekWorkout;
        List<Workout> LastMonthkWorkout;

        List<Meal> AllMeal;
        List<Workout> AllWorkout;

        List<UserWeaight> UserWeaights;



        double TotalBurnCalories = 0;
        double TotalEatCalories = 0;

        public DashbordView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            workoutController = new WorkoutController();
            mealController = new MealController();
            userControl = new UserController();
            weightController = new UserWeightController();

            LastMonthMeal = mealController.GetLastMonthMealWithFood();
            LastWeekMeal = mealController.GetLastWeekMealWithFood();

            LastWeekWorkout = workoutController.GetAllLastWeek();
            LastMonthkWorkout = workoutController.GetAllLastMonth();

            AllMeal = mealController.GetAll();
            AllWorkout = workoutController.GetAllWorkOut();

            UserWeaights = weightController.GetUserWeight();


        }

        private void GenerateWeightPrediction()
        {
            if (UserWeaights.Count > 0)
            {
                List<double> actualWeight = new List<double>();
                List<double> PredictionWeight = new List<double>();

                UserWeaights.ForEach(w =>
                {
                    actualWeight.Add(w.Weight);
                });

                int time_duration = 7;

                double ration = (TotalEatCalories - TotalBurnCalories) / (time_duration * 15);
                UserWeaight latest = UserWeaights.OrderByDescending(u => u.dateTime).First();
                double latestWeight = latest.Weight;


                for (int i = 0; i < 7; i++)
                {
                    latestWeight = latestWeight + ration;
                    PredictionWeight.Add(latestWeight);
                }

                cartesianChartpred.Series = new ISeries[]
          {
                new LineSeries<double>
                {
                    Values = PredictionWeight.ToArray(),
                    Stroke = new SolidColorPaint(SKColors.OrangeRed) { StrokeThickness = 2 },
                    Fill = null,
                    Name = "Prediction Weight for next week",

                },

          };
            }
        }

        private void ShowPrediction()
        {
            AllMeal.ForEach(m =>
            {
                TotalEatCalories = TotalEatCalories + m.TotalCatories;
            });

            AllWorkout.ForEach(w =>
            {
                TotalBurnCalories = TotalBurnCalories + w.TotalCalories;
            });

            if (TotalBurnCalories > TotalEatCalories)
            {
                labelPredictionTex.Text = "You have burn more calories , than calories gain yor weight loose";
            }

            if (TotalBurnCalories < TotalEatCalories)
            {
                labelPredictionTex.Text = "Your weight goes up when you consume more calories than you use";
            }
            if (TotalEatCalories == TotalBurnCalories)
            {
                labelPredictionTex.Text = "Your maintain current weight";
            }
            labelPredictionTex.Visible = true;
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
            double[] dataMeal1 = getMealTotalCaloryList(AllMeal);
            double[] dataWorkouts = getWorkoutTotalCaloryList(AllWorkout);

            ShowLineChart1(dataMeal1, dataWorkouts);
            this.ShowPiChart1(LastMonthMeal, LastMonthkWorkout);
            this.ShowPiChart2(AllMeal, AllWorkout);

            ShowPrediction();

            GenerateWeightPrediction();

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
            double TotalEatCaloriesMonth = 0;
            double TotalBurnCaloriesMonth = 0;
            meatData.ForEach(m =>
            {
                TotalEatCaloriesMonth = TotalEatCaloriesMonth + m.TotalCatories;
            });

            workoutsData.ForEach(m =>
            {
                TotalBurnCaloriesMonth = TotalBurnCaloriesMonth + m.TotalCalories;
            });


            pieChart1.Series = new List<ISeries>
             {

                new PieSeries<double> {
                    Values = new List<double> { TotalEatCaloriesMonth },
                    Name ="Total Calories Burn"

                },
                new PieSeries<double> {
                    Values = new List<double> { TotalBurnCaloriesMonth } ,
                    Name ="Total Calories Gain"
                }

               };
        }

        private void ShowPiChart2(List<Meal> meatData, List<Workout> workoutsData)
        {
            double TotalEatCaloriestemp = 0;
            double TotalBurnCaloriestemp = 0;
            meatData.ForEach(m =>
            {
                TotalEatCaloriestemp = TotalEatCaloriestemp + m.TotalCatories;
            });

            workoutsData.ForEach(m =>
            {
                TotalBurnCaloriestemp = TotalBurnCaloriestemp + m.TotalCalories;
            });


            pieChart1.Series = new List<ISeries>
             {

                new PieSeries<double> {
                    Values = new List<double> { TotalBurnCaloriestemp },
                    Name ="Total Calories Burn"

                },
                new PieSeries<double> {
                    Values = new List<double> { TotalEatCaloriestemp } ,
                    Name ="Total Calories Gain"
                }

               };
        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
