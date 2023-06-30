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
            label1 = new Label();
            dataGridViewMeal = new DataGridView();
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
            checkBoxRecursive = new CheckBox();
            textBoxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMeal).BeginInit();
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
            // dataGridViewMeal
            // 
            dataGridViewMeal.AllowUserToAddRows = false;
            dataGridViewMeal.AllowUserToDeleteRows = false;
            dataGridViewMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMeal.Location = new Point(22, 107);
            dataGridViewMeal.Name = "dataGridViewMeal";
            dataGridViewMeal.ReadOnly = true;
            dataGridViewMeal.RowTemplate.Height = 25;
            dataGridViewMeal.Size = new Size(568, 225);
            dataGridViewMeal.TabIndex = 1;
            dataGridViewMeal.CellContentClick += dataGridViewMeal_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(657, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxMeal
            // 
            comboBoxMeal.FormattingEnabled = true;
            comboBoxMeal.Items.AddRange(new object[] { "Brackfast", "Lunch", "Dinner", "Snack" });
            comboBoxMeal.Location = new Point(657, 138);
            comboBoxMeal.Name = "comboBoxMeal";
            comboBoxMeal.Size = new Size(121, 23);
            comboBoxMeal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(618, 141);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Meal";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 175);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Food";
            // 
            // comboBoxFood
            // 
            comboBoxFood.FormattingEnabled = true;
            comboBoxFood.Location = new Point(657, 172);
            comboBoxFood.Name = "comboBoxFood";
            comboBoxFood.Size = new Size(121, 23);
            comboBoxFood.TabIndex = 6;
            // 
            // listBoxFoods
            // 
            listBoxFoods.FormattingEnabled = true;
            listBoxFoods.ItemHeight = 15;
            listBoxFoods.Location = new Point(657, 201);
            listBoxFoods.Name = "listBoxFoods";
            listBoxFoods.Size = new Size(213, 64);
            listBoxFoods.TabIndex = 7;
            // 
            // addFoodBtn
            // 
            addFoodBtn.Location = new Point(784, 172);
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
            label4.Location = new Point(596, 201);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Food List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 115);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "Date";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(657, 282);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(97, 23);
            buttonSubmit.TabIndex = 11;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(776, 282);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(657, 311);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(213, 23);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // checkBoxRecursive
            // 
            checkBoxRecursive.AutoSize = true;
            checkBoxRecursive.Location = new Point(787, 140);
            checkBoxRecursive.Name = "checkBoxRecursive";
            checkBoxRecursive.Size = new Size(76, 19);
            checkBoxRecursive.TabIndex = 14;
            checkBoxRecursive.Text = "Recursive";
            checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(657, 80);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 15;
            textBoxID.Visible = false;
            // 
            // MealView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 465);
            Controls.Add(textBoxID);
            Controls.Add(checkBoxRecursive);
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
            Controls.Add(dataGridViewMeal);
            Controls.Add(label1);
            Name = "MealView";
            Text = "MealView";
            Load += MealView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMeal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewMeal;
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
        private CheckBox checkBoxRecursive;
        private TextBox textBoxID;
    }
}