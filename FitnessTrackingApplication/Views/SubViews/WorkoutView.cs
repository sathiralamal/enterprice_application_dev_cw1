using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FitnessTrackingApplication.Views.SubViews
{
    public partial class WorkoutView : Form
    {
        private ExerciseController exerciseController;
        private WorkoutController workoutController;

        private List<Workout> Workouts;
        private List<Exercise> exercises;
        private List<Exercise> addedExercises;
        private List<int> exersieTime;

        private bool isEdit = false;

        public WorkoutView()
        {
            InitializeComponent();
            this.exerciseController = new ExerciseController();
            this.workoutController = new WorkoutController();

            this.addedExercises = new List<Exercise>();
            this.exersieTime = new List<int>();
        }

        private void labelTotalCalories_Click(object sender, EventArgs e)
        {

        }

        private void WorkoutView_Load(object sender, EventArgs e)
        {
            this.LoadAllWorkouts();

            var exercise = this.exerciseController.GetExersise();
            if (exercise != null && exercise.Count > 0)
            {
                this.exercises = exercise.ToList();
                comboBoxExesice.DataSource = this.exercises;
                comboBoxExesice.ValueMember = "Id";
                comboBoxExesice.DisplayMember = "ExerciseName";
                listBoxExesise.DisplayMember = "ExerciseName";

            }
        }

        private void buttonExeAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxExesice.SelectedItem != null && !textBoxTime.Text.IsNullOrEmpty())
            {
                int hours = int.Parse(textBoxTime.Text.ToString());

                var selectedExesiseId = comboBoxExesice.SelectedItem;
                this.addedExercises.Add((Exercise)selectedExesiseId);
                this.exersieTime.Add(hours);
                listBoxExesise.Items.Add(comboBoxExesice.SelectedItem);
                CountTotalCalories();

            }
            else
            {
                this.ShowMessageBox("Flil the all fileds", "Exesises Add", MessageBoxIcon.Information);

            }
        }

        private void ClearExersise()
        {
            comboBoxExesice.SelectedIndex = 0;
            listBoxExesise.Items.Clear();
            addedExercises.Clear();
            exersieTime.Clear();
            labelTotalCalories.Text = "0";
            checkBoxRecursive.Checked = false;
        }

        private void CountTotalCalories()
        {
            float totalCalories = 0;

            if (this.addedExercises.Count > 0)
            {
                for (int i = 0; i < this.addedExercises.Count; i++)
                {
                    totalCalories = totalCalories + this.addedExercises.ElementAt(i).Calories * exersieTime.ElementAt(i);
                    labelTotalCalories.Text = totalCalories.ToString();
                }
            }
            else
            {
                labelTotalCalories.Text = "0";
            }

            textBoxTime.Text = "";
        }

        private void listViewExesise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxExesise_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedExersis = listBoxExesise.SelectedItem;
            if (selectedExersis != null )
            {
                listBoxExesise.Items.Remove(selectedExersis);
               
            }
        }

        private void ShowMessageBox(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title, MessageBoxButtons.OKCancel, ICON);
        }

        private void buttonAddWokout_Click(object sender, EventArgs e)
        {
            if (listBoxExesise.Items != null && listBoxExesise.Items.Count > 0)
            {
                List<Exercise> userExsersice = new List<Exercise>();
                foreach (var element in listBoxExesise.Items)
                {
                    Exercise exercise = (Exercise)element;
                    userExsersice.Add(exercise);
                }

                Workout workout = new Workout();
                workout.Exercises = userExsersice;
                workout.IsRecursive = checkBoxRecursive.Checked;
                if (!isEdit)
                {
                    workout.TotalCalories = int.Parse(labelTotalCalories.Text.ToString());
                    workoutController.CreateWorkout(workout);
                }
                else
                {
                    workout.TotalCalories = int.Parse(textBoxTotalCal.Text.ToString());
                    int currentID = int.Parse(textBoxID.Text);
                    workoutController.Update(workout, currentID);

                }

                this.LoadAllWorkouts();
            }
        }

        private void LoadAllWorkouts()
        {
            this.Workouts = this.workoutController.GetAllWorkOut();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Exersises");
            dt.Columns.Add("TotalCalories");
            dt.Columns.Add("Frequent");

            if (this.Workouts.Count > 0)
            {
                for (int i = 0; i < this.Workouts.Count; i++)
                {
                    Workout temp_workout = this.Workouts.ElementAt(i);
                    string exerciselist = "";
                    temp_workout.Exercises.ForEach(e =>
                    {
                        exerciselist += e.ExerciseName + " ,";
                    });
                    dt.Rows.Add(temp_workout.Id, exerciselist, temp_workout.TotalCalories, temp_workout.IsRecursive ? "Recursive" : "One-Off");

                }
            }

            dataGridViewWorkouts.DataSource = dt;
            ;
        }

        private void ClearTextField()
        {
            buttonDelete.Visible = false;
            textBoxID.Text = string.Empty;
            textBoxID.Visible = false;
            ClearExersise();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearTextField();
        }

        private void ModifyData()
        {
            int curretRow = dataGridViewWorkouts.CurrentRow.Index;
            var currentWorkout = this.Workouts.ElementAt(curretRow);
            isEdit = true;
            buttonDelete.Visible = true;

            textBoxID.Text = this.Workouts.ElementAt(curretRow).Id.ToString();
            listBoxExesise.Items.Clear();

            if (currentWorkout.Exercises.Count > 0)
            {
               listBoxExesise.DataSource = currentWorkout.Exercises;
            }

            if (currentWorkout.IsRecursive)
            {
                checkBoxRecursive.Checked = true;
            }
            textBoxTotalCal.Visible = true;
            textBoxTotalCal.Text = currentWorkout.TotalCalories.ToString();

            comboBoxExesice.Enabled = false;
            buttonDelete.Visible = false;
            buttonAddWokout.Text = "Update";
            buttonAddWokout.Visible = true;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;

            dataGridViewWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewWorkouts.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue) ||
                        row.Cells[0].Value.ToString().Equals(searchValue) ||
                        row.Cells[2].Value.ToString().Equals(searchValue))

                    {
                        row.Selected = true;
                        textBoxSearch.Text = "";
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridViewWorkouts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyData();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedID = int.Parse(textBoxID.Text);
            this.workoutController.Delete(selectedID);
            LoadAllWorkouts();
        }
    }
}
