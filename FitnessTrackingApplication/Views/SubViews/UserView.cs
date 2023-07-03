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

namespace FitnessTrackingApplication.Views.SubViews
{
    public partial class UserView : Form
    {
        List<UserWeaight> userWeaights;
        UserWeightController UserWeightController;
        bool isEdit = false;

        public UserView()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UserWeightController = new UserWeightController();
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            userWeaights = UserWeightController.GetUserWeight();
            dataGridView1.DataSource = userWeaights;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool Status = false;
            string weight = textBoxWeight.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string userName = "sathira";

            UserWeaight userWeaight = new UserWeaight();
            userWeaight.UserName = userName;
            userWeaight.dateTime = dateTime;
            userWeaight.Weight = Double.Parse(weight);

            if (isEdit)
            {
                int id = int.Parse(textBoxID.Text);
                Status = UserWeightController.Update(userWeaight ,id);
            }
            else
            {
                Status = UserWeightController.Create(userWeaight);

            }


            if (Status)
            {
                MessageBox.Show("Added Data ");
                LoadData();
            }
            LoadData();
            ClarTextFiled();

        }

        private void ClarTextFiled()
        {
            textBoxID.Text = "";
            textBoxSearch.Text = "";
            textBoxWeight.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClarTextFiled();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            UserWeightController.Delete(id);
            this.LoadData();
            this.ClarTextFiled();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curretRow = dataGridView1.CurrentRow.Index;
            var currentUSerWeight = userWeaights.ElementAt(curretRow);
            textBoxID.Text = currentUSerWeight.Id.ToString();
            textBoxWeight.Text = currentUSerWeight.Weight.ToString();
            dateTimePicker1.Value = currentUSerWeight.dateTime;
            isEdit = true;
            buttonSubmit.Text = "Update";
            buttonDelete.Visible = true;
            
        }
    }
}
