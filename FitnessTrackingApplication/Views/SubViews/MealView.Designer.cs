namespace FitnessTrackingApplication.Views.SubViews
{
    partial class MealView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mealBindingSource2 = new BindingSource(components);
            mealBindingSource = new BindingSource(components);
            mealBindingSource1 = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            comboBoxMeal = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxFood = new ComboBox();
            listBoxFoods = new ListBox();
            addFoodBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            buttonSubmit = new Button();
            buttonCancel = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mealBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mealBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mealBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "Manage Meals";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateTimeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mealBindingSource2;
            dataGridView1.Location = new Point(22, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(346, 225);
            dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            dateTimeDataGridViewTextBoxColumn.DataPropertyName = "dateTime";
            dateTimeDataGridViewTextBoxColumn.HeaderText = "dateTime";
            dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mealBindingSource2
            // 
            mealBindingSource2.DataSource = typeof(Models.Meal);
            // 
            // mealBindingSource
            // 
            mealBindingSource.DataSource = typeof(Models.Meal);
            // 
            // mealBindingSource1
            // 
            mealBindingSource1.DataSource = typeof(Models.Meal);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(559, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxMeal
            // 
            comboBoxMeal.FormattingEnabled = true;
            comboBoxMeal.Items.AddRange(new object[] { "Brackfast", "Lunch", "Dinner", "Snack" });
            comboBoxMeal.Location = new Point(559, 136);
            comboBoxMeal.Name = "comboBoxMeal";
            comboBoxMeal.Size = new Size(121, 23);
            comboBoxMeal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 139);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Meal";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 173);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Food";
            // 
            // comboBoxFood
            // 
            comboBoxFood.FormattingEnabled = true;
            comboBoxFood.Location = new Point(559, 170);
            comboBoxFood.Name = "comboBoxFood";
            comboBoxFood.Size = new Size(121, 23);
            comboBoxFood.TabIndex = 6;
            // 
            // listBoxFoods
            // 
            listBoxFoods.FormattingEnabled = true;
            listBoxFoods.ItemHeight = 15;
            listBoxFoods.Location = new Point(559, 199);
            listBoxFoods.Name = "listBoxFoods";
            listBoxFoods.Size = new Size(213, 64);
            listBoxFoods.TabIndex = 7;
            // 
            // addFoodBtn
            // 
            addFoodBtn.Location = new Point(686, 170);
            addFoodBtn.Name = "addFoodBtn";
            addFoodBtn.Size = new Size(86, 23);
            addFoodBtn.TabIndex = 8;
            addFoodBtn.Text = "Add Food";
            addFoodBtn.UseVisualStyleBackColor = true;
            addFoodBtn.Click += addFoodBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 199);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Food List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 113);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "Date";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(559, 280);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(97, 23);
            buttonSubmit.TabIndex = 11;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(678, 280);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(559, 309);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(213, 23);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // MealView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 465);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(addFoodBtn);
            Controls.Add(listBoxFoods);
            Controls.Add(comboBoxFood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMeal);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "MealView";
            Text = "MealView";
            Load += MealView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mealBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mealBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)mealBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource mealBindingSource;
        private BindingSource mealBindingSource2;
        private BindingSource mealBindingSource1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxMeal;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxFood;
        private ListBox listBoxFoods;
        private Button addFoodBtn;
        private Label label4;
        private Label label5;
        private Button buttonSubmit;
        private Button buttonCancel;
        private Button buttonDelete;
    }
}