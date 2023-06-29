using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessTrackingApplication.Views.SubViews
{
    public partial class MealView : Form
    {
        FoodController foodController;
        List<Food> foods;
        List<Food> SelectedFoods;

        public MealView()
        {
            InitializeComponent();
            foodController = new FoodController();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MealView_Load(object sender, EventArgs e)
        {
            this.foods = foodController.GetFoods();
            comboBoxFood.DataSource = this.foods;
            comboBoxFood.ValueMember = "Id";
            comboBoxFood.DisplayMember = "Name";

            SelectedFoods = new List<Food>();

            listBoxFoods.DisplayMember = "Name";

        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxFood.SelectedItem != null)
            {
                // Add the selected item to the listbox
                listBoxFoods.Items.Add(comboBoxFood.SelectedItem);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxMeal.SelectedItem != null&& listBoxFoods.Items.Count>0)
            {
                Meal meal = new Meal();
                meal.dateTime = dateTimePicker1.Value;
                meal.Name = (string)comboBoxMeal.SelectedItem;
                List<Food> selectFoods = new List<Food>(); 
                foreach (var item in listBoxFoods.Items)
                {
                    selectFoods.Add((Food)item); 
                }
                meal.foods = selectFoods;

            }
            else
            {
                this.ShowMessageBox("Select the Meal name", "Meal Add", MessageBoxIcon.Warning);
            }
           
        }

        private void ShowMessageBox(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title,
                    MessageBoxButtons.OKCancel,
                    ICON);
        }

    }
}
