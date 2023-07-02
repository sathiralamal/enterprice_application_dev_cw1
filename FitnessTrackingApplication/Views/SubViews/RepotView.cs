using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
        private ExerciseController exerciseController;
        private WorkoutController workoutController;

        private List<Workout> Workouts;
        private List<Exercise> Exercises;

        public RepotView()
        {
            InitializeComponent();
            exerciseController = new ExerciseController();
            workoutController = new WorkoutController();
        }

        private void RepotView_Load(object sender, EventArgs e)
        {
            Workouts = workoutController.GetAllWorkOut();
            Exercises = exerciseController.GetExersise();

            dataGridViewWorkout.DataSource = Workouts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

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

                                        pTable.AddCell(dcell.Value.ToString());

                                    }

                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();

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
