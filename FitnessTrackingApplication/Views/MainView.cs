using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTrackingApplication.Views;
using FitnessTrackingApplication.Views.SubViews;

namespace FitnessTrackingApplication.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            ShowForm("Dashbord");
        }

        public void ShowForm(string name)
        {
            if (name == "Dashbord")
            {
                mainPanal.Controls.Clear();
                mainPanal.AutoScroll = true;
                mainPanal.Visible = true;
                DashbordView dashbordForm = new DashbordView();
                dashbordForm.TopLevel = false;
                dashbordForm.Show();
                mainPanal.Controls.Add(dashbordForm);
            }
            else if (name == "Meal")
            {
                mainPanal.Controls.Clear();
                mainPanal.Visible = true;
                MealView mealForm = new MealView();
                mealForm.TopLevel = false;
                mealForm.Show();
                mainPanal.Controls.Add(mealForm);
            }
            else if (name == "Food")
            {
                mainPanal.Controls.Clear();
                mainPanal.Visible = true;
                FoodView foodForm = new FoodView();
                foodForm.TopLevel = false;
                foodForm.Show();
                mainPanal.Controls.Add(foodForm);
            }
            else if (name == "Workout")
            {
                mainPanal.Controls.Clear();
                mainPanal.Visible = true;
                WorkoutView workoutForm = new WorkoutView();
                workoutForm.TopLevel = false;
                workoutForm.Show();
                mainPanal.Controls.Add(workoutForm);
            }
            else if (name == "Exersice")
            {
                mainPanal.Controls.Clear();
                mainPanal.Visible = true;
                ExerciseView exerciseForm = new ExerciseView();
                exerciseForm.TopLevel = false;
                exerciseForm.Show();
                mainPanal.Controls.Add(exerciseForm);
            }
            else if (name == "Repots")
            {
                mainPanal.Controls.Clear();
                mainPanal.Visible = true;
                RepotView repotsForm = new RepotView();
                repotsForm.TopLevel = false;
                repotsForm.Show();
                mainPanal.Controls.Add(repotsForm);
            }
            else if (name == "User_logs")
            {
                mainPanal.Controls.Clear();
                mainPanal.Visible = true;
                UserView userForm = new UserView();
                userForm.TopLevel = false;
                userForm.Show();
                mainPanal.Controls.Add(userForm);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowForm("Dashbord");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowForm("Meal");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ShowForm("Food");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ShowForm("Exersice");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ShowForm("Workout");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ShowForm("Repots");

        }

        private void buttonUserWeight_Click(object sender, EventArgs e)
        {
            this.ShowForm("User_logs");
        }
    }
}
