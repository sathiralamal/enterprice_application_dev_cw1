using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;
using FitnessTrackingApplication.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackingApplication.Views.SubViews
{
    public partial class RepotView : Form
    {
        private MealController mealController;
        private WorkoutController workoutController;

        private List<Workout> Workouts;
        private List<Meal> Meals;

        public RepotView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            mealController = new MealController();
            workoutController = new WorkoutController();
        }

        private void RepotView_Load(object sender, EventArgs e)
        {
            Workouts = workoutController.GetAllWorkOut();
            ShowWorkOuts(Workouts);


            Meals = mealController.GetAllMealWithFood();
            ShowMeals(Meals);

            comboBoxMeal.SelectedIndex = 1;
            comboBoxWokout.SelectedIndex = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxWokout.SelectedItem == null)
            {
                MessageBox.Show("Select Report mode to generate repot");
                return;

            }

            Thread t = new Thread((ThreadStart)(() => {

                if (dataGridViewWorkout.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to wride data in disk" + ex.Message);
                            }

                        }

                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dataGridViewWorkout.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in dataGridViewWorkout.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in dataGridViewWorkout.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());

                                        }

                                    }

                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                    PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    Paragraph paragraph = new Paragraph("Workout Repot");
                                    paragraph.SetLeading(15, 1.5f);
                                    document.Add(paragraph);
                                    pTable.SpacingBefore = 20;
                                    pTable.SpacingAfter = 20;
                                    document.Add(pTable);
                                    document.Close();

                                    fileStream.Close();

                                }

                                MessageBox.Show("Data Export Successfully", "info");

                            }

                            catch (Exception ex)

                            {

                                MessageBox.Show("Error while exporting Data" + ex.Message);

                            }

                        }

                    }

                }

                else

                {

                    MessageBox.Show("No Record Found", "Info");

                }


            }));

            // Run your code from a thread that joins the STA Thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

        }

       

        private void buttonGenerateWokout_Click(object sender, EventArgs e)
        {
            if (comboBoxWokout.SelectedItem == null)
            {
                MessageBox.Show("Select Report mode to generate repot");
                return;

            }

            string mode = comboBoxWokout.SelectedItem.ToString();

            if (mode == "All Data")
            {
                Workouts = workoutController.GetAllWorkOut();
                dataGridViewWorkout.DataSource = null;
                ShowWorkOuts(Workouts);
            }
            else if (mode == "Last Week")
            {
                Workouts = workoutController.GetAllLastWeek();
                dataGridViewWorkout.DataSource = null;
                ShowWorkOuts(Workouts);

            }
            else if (mode == "Last Month")
            {
                Workouts = workoutController.GetAllLastMonth();
                dataGridViewWorkout.DataSource = null;
                ShowWorkOuts(Workouts);
            }

        }

        private void ShowWorkOuts(List<Workout> data)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Exersises");
            dt.Columns.Add("TotalCalories");
            dt.Columns.Add("dateTime");
            dt.Columns.Add("Frequent");

            if (data.Count > 0)
            {
                for (int i = 0; i < data.Count; i++)
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
            if (dataGridViewWorkout.DataSource != null)
            {
                dataGridViewWorkout.DataSource = null;
            }

            dataGridViewWorkout.DataSource = dt;

        }

        private void buttonMeleasGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxMeal.SelectedItem == null)
            {
                MessageBox.Show("Select mode in dropdown");
                return;
            }

            string mode = comboBoxMeal.SelectedItem.ToString();

            if (mode == "All Data")
            {
                Meals = mealController.GetAllMealWithFood();
                ShowMeals(Meals);
            }
            else if (mode == "Last Week")
            {
                Meals = mealController.GetLastWeekMealWithFood();
                ShowMeals(Meals);

            }
            else if (mode == "Last Month")
            {
                Meals = mealController.GetLastMonthMealWithFood();
                ShowMeals(Meals);
            }
        }

        private void ShowMeals(List<Meal> meals)
        {



            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Foods");
            dt.Columns.Add("Meal");
            dt.Columns.Add("Total Catories");
            dt.Columns.Add("Date Time");
            dt.Columns.Add("Recursive");


            if (meals.Count > 0)
            {
                for (int i = 0; i < meals.Count; i++)
                {
                    Dictionary<string, Object> Pairs = new Dictionary<string, Object>();
                    Meal temp = meals.ElementAt(i);

                    string foodnamelist = "";
                    temp.Foods.ForEach(f =>
                    {
                        foodnamelist += f.Name + " ,";
                    });
                    dt.Rows.Add(temp.Id, foodnamelist, temp.Name, temp.TotalCatories, temp.dateTime, temp.IsRecursive ? "Recursive" : "");
                }
            }

            // dataGridViewMeal.DataSource = Meals;
            if (dataGridViewMeals.DataSource != null)
            {
                dataGridViewMeals.DataSource = null;
            }
            dataGridViewMeals.DataSource = dt;

        }

        private void buttonMealPrint_Click(object sender, EventArgs e)
        {
            if (comboBoxMeal.SelectedItem == null)
            {
                MessageBox.Show("Select Report mode to generate repot");
                return;

            }
            Thread t = new Thread((ThreadStart)(() => {
                if (dataGridViewMeals.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    bool ErrorMessage = false;
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                ErrorMessage = true;
                                MessageBox.Show("Unable to wride data in disk" + ex.Message);
                            }
                        }
                        if (!ErrorMessage)
                        {
                            try
                            {

                                PdfPTable pTable = new PdfPTable(dataGridViewMeals.Columns.Count);
                                
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn col in dataGridViewMeals.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }
                                foreach (DataGridViewRow viewRow in dataGridViewMeals.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());

                                        }
                                    }
                                }
                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    Paragraph paragraph = new Paragraph("Meal Repot");
                                    paragraph.SetLeading(15, 1.5f);
                                    document.Add(paragraph);
                                    pTable.SpacingBefore = 20;
                                    pTable.SpacingAfter = 20;
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("Data Export Successfully", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting Data" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "Info");
                }

            }));
            // Run your code from a thread that joins the STA Thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

         
         }

        
    }
}

