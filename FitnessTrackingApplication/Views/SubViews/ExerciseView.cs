using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackingApplication.Views.SubViews
{
    public partial class ExerciseView : Form
    {
        private ExerciseController exerciseController;
        private List<Exercise> Exercises;
        private bool isEdit = false;
        private bool operationStatus = false;

        public ExerciseView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            exerciseController = new ExerciseController();
            this.LoadAllExersises();

        }

        public void LoadAllExersises()
        {
            Exercises = exerciseController.GetExersise();
            dataGridViewExe.DataSource = Exercises;
            if (isEdit)
            {
                dataGridViewExe.RefreshEdit();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.ClearTextBox();
        }

        private void ClearTextBox()
        {
            textBoxID.Text = "";
            textBoxExeName.Text = "";
            textBoxExeCalory.Text = "";
            textBoxExeDiscription.Text = "";
            textBoxID.Visible = false;
            isEdit = false;
            buttonDelete.Visible = false;
            buttonSubmit.Text = "Submit";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearchBox.Text;

            dataGridViewExe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewExe.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue) || row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int curretRow = dataGridViewExe.CurrentRow.Index;
            var currentExersice = Exercises.ElementAt(curretRow);
            exerciseController.Delete(currentExersice.Id);
            this.LoadAllExersises();
            this.ClearTextBox();
        }

        private void ShowMessageBox(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title,
                    MessageBoxButtons.OKCancel,
                    ICON);
        }

        private void dataGridViewExe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ModifyData();
        }

        private void ModifyData()
        {
            int curretRow = dataGridViewExe.CurrentRow.Index;
            var currentExersise = Exercises.ElementAt(curretRow);
            textBoxID.Text = currentExersise.Id.ToString();
            textBoxExeName.Text = currentExersise.ExerciseName;
            textBoxExeCalory.Text = currentExersise.Calories.ToString();
            textBoxExeDiscription.Text = currentExersise.ExerciseDescription;
            isEdit = true;
            textBoxID.Visible = true;
            buttonDelete.Visible = true;
            buttonSubmit.Text = "Update";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!textBoxExeName.Text.IsNullOrEmpty() && !textBoxExeDiscription.Text.IsNullOrEmpty() && !textBoxExeCalory.Text.IsNullOrEmpty())
            {
                Exercise exercise = new Exercise();
                exercise.ExerciseName = textBoxExeName.Text;
                exercise.ExerciseDescription = textBoxExeDiscription.Text;
                exercise.Calories = Int32.Parse(textBoxExeCalory.Text);
                if (isEdit)
                {
                    int id = Int32.Parse(textBoxID.Text);
                    exercise.Id = id;
                    operationStatus = this.exerciseController.Update(exercise, id);
                    dataGridViewExe.RefreshEdit();
                    this.LoadAllExersises();
                }
                else
                {
                    operationStatus = this.exerciseController.Create(exercise);
                    this.LoadAllExersises();

                }
                this.ShowMessageBox("Operation Succsfull", "Exersice modify", MessageBoxIcon.Information);
                this.ClearTextBox();
            }
            else
            {
                this.ShowMessageBox("Fill the all mandetory filed", "Exersice modify", MessageBoxIcon.Warning);
            }
        }
    }
}
