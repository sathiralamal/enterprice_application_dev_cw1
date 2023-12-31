﻿using FitnessTrackingApplication.Controller;
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
    public partial class FoodView : Form
    {
        private FoodController foodController;
        private List<Food> Foods;
        private bool isEdit = false;
        private bool operationStatus = false;

        public FoodView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            foodController = new FoodController();
            this.LoadAllFoods();
        }

        public void LoadAllFoods()
        {
            Foods = foodController.GetFoods();
            dataGridViewFoods.DataSource = Foods;
        }


        private void cancelFoodbtn_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void submitFoodBtn_Click_1(object sender, EventArgs e)
        {

            if (!textBoxFoodName.Text.IsNullOrEmpty() && !textBoxCalories.Text.IsNullOrEmpty() && !textBoxAmount.Text.IsNullOrEmpty())
            {
                Food newFood = new Food();
                newFood.Name = textBoxFoodName.Text;
                newFood.amount = float.Parse(textBoxAmount.Text, CultureInfo.InvariantCulture.NumberFormat);
                newFood.calories = Int32.Parse(textBoxCalories.Text);
                if (isEdit)
                {
                    int id = Int32.Parse(textBoxFoodID.Text);
                    newFood.Id = id;
                    operationStatus = this.foodController.Update(newFood, id);
                    dataGridViewFoods.RefreshEdit();
                    this.LoadAllFoods();
                }
                else
                {
                    operationStatus = this.foodController.Create(newFood);
                    this.LoadAllFoods();

                }
                this.ShowMessageBox("Operation Succsfull", "Food modify", MessageBoxIcon.Information);
                this.ClearTextBox();
            }
            else
            {
                this.ShowMessageBox("Fill the all mandetory filed", "Food modify", MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("single click table");
            this.ModifyData();
        }

        private void dataGridViewFoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("single click table");
            this.ModifyData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int curretRow = dataGridViewFoods.CurrentRow.Index;
            var currentFood = Foods.ElementAt(curretRow);
            foodController.Delete(currentFood.Id);
            this.LoadAllFoods();
            this.ClearTextBox();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;

            dataGridViewFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewFoods.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue) || row.Cells[0].Value.ToString().Equals(searchValue))
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

        private void ModifyData()
        {
            int curretRow = dataGridViewFoods.CurrentRow.Index;
            var currentFood = Foods.ElementAt(curretRow);
            textBoxFoodID.Text = currentFood.Id.ToString();
            textBoxFoodName.Text = currentFood.Name;
            textBoxCalories.Text = currentFood.calories.ToString();
            textBoxAmount.Text = currentFood.amount.ToString();
            isEdit = true;
            textBoxFoodID.Visible = true;
            buttonDelete.Visible = true;
        }

        private void ClearTextBox()
        {
            textBoxFoodName.Text = "";
            textBoxCalories.Text = "";
            textBoxAmount.Text = "";
            textBoxFoodID.Text = "";
            textBoxFoodID.Visible = false;
            this.isEdit = false;
            buttonDelete.Visible = false;
        }

        private void ShowMessageBox(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title,
                    MessageBoxButtons.OKCancel,
                    ICON);
        }

    }
}
