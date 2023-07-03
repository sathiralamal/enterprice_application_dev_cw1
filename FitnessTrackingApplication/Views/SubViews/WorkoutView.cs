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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessTrackingApplication.Views.SubViews
{
    public partial class WorkoutView : Form
    {
        private ExerciseController exerciseController;
        private WorkoutController workoutController;

        private List<Workout> Workouts;
        private List<Exercise> exercises;
        private List<Exercise> selectedExercises;
        private List<int> exersieTime;
        private Workout currentSelectedWorkout;

        private List<Exercise> currentExercises;


        private bool isEdit = false;

        public WorkoutView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.exerciseController = new ExerciseController();
            this.workoutController = new WorkoutController();

            this.selectedExercises = new List<Exercise>();
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
            if (comboBoxExesice.SelectedItem != null)
            {

                var selectedExesise = comboBoxExesice.SelectedItem;

                if (listBoxExesise.Items.Count > 0 && isEdit)
                {   //Edite existing workout
                    currentExercises.Add((Exercise)selectedExesise);
                    listBoxExesise.DataSource = null;
                    listBoxExesise.DataSource = currentExercises;
                    listBoxExesise.DisplayMember = "ExerciseName";

                }
                else
                {
                    //Add new workout
                    listBoxExesise.Items.Add(comboBoxExesice.SelectedItem);
                    selectedExercises.Add((Exercise)comboBoxExesice.SelectedItem);
                }

                CountTotalCalories();

            }
            else
            {
                this.ShowMessageBox("Flil the all fileds", "Exesises Add", MessageBoxIcon.Information);

            }
        }

        private void ClearExersise()
        {
            isEdit = false;
            comboBoxExesice.SelectedIndex = 0;
            listBoxExesise.DataSource = null;
            listBoxExesise.Items.Clear();
            selectedExercises.Clear();
            exersieTime.Clear();
            labelTotalCalories.Text = "0";
            checkBoxRecursive.Checked = false;


        }

        private void CountTotalCalories()
        {
            float totalCalories = 0;
            if (!isEdit)
            {
                if (this.selectedExercises.Count > 0)
                {
                    for (int i = 0; i < this.selectedExercises.Count; i++)
                    {

                        totalCalories = totalCalories + this.selectedExercises.ElementAt(i).Calories;
                        labelTotalCalories.Text = totalCalories.ToString();

                    }
                }
                else
                {
                    labelTotalCalories.Text = totalCalories.ToString();
                }
            }
            else
            {
                if (this.currentExercises.Count > 0)
                {
                    for (int i = 0; i < this.currentExercises.Count; i++)
                    {


                        totalCalories = totalCalories + this.currentExercises.ElementAt(i).Calories;
                        labelTotalCalories.Text = totalCalories.ToString();


                    }
                }
                else
                {
                    labelTotalCalories.Text = totalCalories.ToString();
                }
            }


        }

        private void listViewExesise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxExesise_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedExersis = listBoxExesise.SelectedItem;
            // if (selectedExersis != null)
            // {
            //     listBoxExesise.Items.Remove(selectedExersis);

            // }
        }

        private void listBoxExesise_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxExesise.SelectedIndex != -1)
            {
                listBoxExesise.Items.RemoveAt(listBoxExesise.SelectedIndex);
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
                workout.dateTime = dateTimePicker1.Value;
                workout.TotalCalories = int.Parse(labelTotalCalories.Text.ToString());

                if (!isEdit)
                {
                    workoutController.CreateWorkout(workout);
                }
                else
                {
                    int currentID = int.Parse(textBoxID.Text);
                    workoutController.Update(workout, currentID);

                }

                this.LoadAllWorkouts();
                ClearTextField();
            }
        }

        private void LoadAllWorkouts()
        {
            this.Workouts = this.workoutController.GetAllWorkOut();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Exersises");
            dt.Columns.Add("TotalCalories");
            dt.Columns.Add("dateTime");
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
                    dt.Rows.Add(temp_workout.Id, exerciselist, temp_workout.TotalCalories, temp_workout.dateTime, temp_workout.IsRecursive ? "Recursive" : "One-Off");

                }
            }

            dataGridViewWorkouts.DataSource = dt;

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
            isEdit = true;

            int curretRow = dataGridViewWorkouts.CurrentRow.Index;
            currentSelectedWorkout = this.Workouts.ElementAt(curretRow);

            textBoxID.Text = this.Workouts.ElementAt(curretRow).Id.ToString();
            textBoxID.Visible = true;
            listBoxExesise.DataSource = null;

            if (currentSelectedWorkout.Exercises.Count > 0)
            {
                if (currentExercises != null)
                {
                    currentExercises.Clear();

                }
                currentExercises = currentSelectedWorkout.Exercises;
                listBoxExesise.DataSource = currentExercises;
                // currentExercises.ForEach(w =>
                // {
                //     listBoxExesise.Items.Add(w);
                // });
                listBoxExesise.DisplayMember = "ExerciseName";
            }

            if (currentSelectedWorkout.IsRecursive)
            {
                checkBoxRecursive.Checked = true;
            }
            if (currentSelectedWorkout.dateTime != null)
            {
                dateTimePicker1.Value = (DateTime)currentSelectedWorkout.dateTime;

            }


            comboBoxExesice.Enabled = true;
            buttonDelete.Visible = true;
            // buttonAddWokout.Text = "Update";

            //can't update recode
            buttonAddWokout.Visible = false;

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
            ClearTextField();
        }
    }
}
