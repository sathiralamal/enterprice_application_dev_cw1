using FitnessTrackingApplication.Controller;
using FitnessTrackingApplication.Models;
using Microsoft.Data.SqlClient;
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
        MealController mealController;

        List<Food> foods;
        bool isEdit = false;
        List<Meal> Meals;

        public MealView()
        {
            InitializeComponent();
            mealController = new MealController();
            foodController = new FoodController();
            this.LoadAllMealWithFood();
        }



        public void LoadAllMealWithFood()
        {

            this.Meals = this.mealController.GetAllMealWithFood();


            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Foods");
            dt.Columns.Add("Meal");
            dt.Columns.Add("Total Catories");
            dt.Columns.Add("Date Time");
            dt.Columns.Add("Recursive");


            if (this.Meals.Count > 0)
            {
                for (int i = 0; i < this.Meals.Count; i++)
                {
                    Dictionary<string, Object> Pairs = new Dictionary<string, Object>();
                    Meal temp = this.Meals.ElementAt(i);

                    string foodnamelist = "";
                    temp.Foods.ForEach(f =>
                    {
                        foodnamelist += f.Name + " ,";
                    });
                    dt.Rows.Add(temp.Id, foodnamelist, temp.Name, temp.TotalCatories, temp.dateTime, temp.IsRecursive ? "Recursive" : "");
                }
            }

            // dataGridViewMeal.DataSource = Meals;
            dataGridViewMeal.DataSource = dt;



            if (isEdit)
            {
                dataGridViewMeal.RefreshEdit();
            }

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
            if (comboBoxMeal.SelectedItem != null && listBoxFoods.Items.Count > 0)
            {
                Meal meal = new Meal();
                meal.dateTime = dateTimePicker1.Value;
                meal.Name = (string)comboBoxMeal.SelectedItem;
                meal.IsRecursive = checkBoxRecursive.Checked;
                List<Food> selectFoods = new List<Food>();
                int totalCalories = 0;
                foreach (var item in listBoxFoods.Items)
                {
                    Food temfood = (Food)item;
                    selectFoods.Add(temfood);
                    totalCalories = totalCalories + temfood.calories;
                }
                meal.Foods = selectFoods;
                meal.TotalCatories = totalCalories;

                if (!isEdit)
                {
                    this.mealController.CreateMeal(meal);
                }
                this.LoadAllMealWithFood();
                this.ClearTextBox();
            }
            else
            {
                this.ShowMessageBox("Fill the all madatory filds", "Meal Add", MessageBoxIcon.Warning);
            }

        }

        private void ShowMessageBox(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title,
                    MessageBoxButtons.OKCancel,
                    ICON);
        }

        private void ClearTextBox()
        {
            checkBoxRecursive.Checked = false;
            isEdit = false;
            buttonDelete.Visible = false;
            buttonSubmit.Text = "Submit";
            listBoxFoods.ClearSelected();
            listBoxFoods.Items.Clear();
            comboBoxFood.Enabled = true;
            addFoodBtn.Enabled = true;
            textBoxID.Visible = false;
            buttonDelete.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.ClearTextBox();

        }

        private void dataGridViewMeal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("single click table");
            this.ModifyData();
        }

        private void ModifyData()
        {
            int curretRow = dataGridViewMeal.CurrentRow.Index;
            var currentFood = this.Meals.ElementAt(curretRow);
            textBoxID.Text = currentFood.Id.ToString();
            //set item to list box foods
            listBoxFoods.Items.Clear();
            if (currentFood.Foods.Count > 0)
            {
                currentFood.Foods.ForEach(f =>
                {
                    listBoxFoods.Items.Add(f.Name);
                });
            }

            if (currentFood.IsRecursive)
            {
                checkBoxRecursive.Checked = true;
            }
            dateTimePicker1.Value = currentFood.dateTime;
            comboBoxFood.Enabled = false;
            addFoodBtn.Enabled = false;
            comboBoxMeal.SelectedItem = currentFood.Name;
            isEdit = true;
            textBoxID.Visible = true;
            buttonDelete.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                int selectedMealId = int.Parse(textBoxID.Text);
                mealController.Delete(selectedMealId);
            }
            this.ShowMessageBox("Delete the recode", "Meal Add", MessageBoxIcon.Information);
            LoadAllMealWithFood();
            ClearTextBox();
        }
    }
}
