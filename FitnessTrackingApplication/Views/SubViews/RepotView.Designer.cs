namespace FitnessTrackingApplication.Views.SubViews
{
    partial class RepotView
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
            dataGridViewWorkout = new DataGridView();
            button1 = new Button();
            comboBoxWokout = new ComboBox();
            buttonGenerateWokout = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridViewMeals = new DataGridView();
            comboBoxMeal = new ComboBox();
            buttonMeleasGenerate = new Button();
            buttonMealPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMeals).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWorkout
            // 
            dataGridViewWorkout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkout.Location = new Point(26, 58);
            dataGridViewWorkout.Name = "dataGridViewWorkout";
            dataGridViewWorkout.RowTemplate.Height = 25;
            dataGridViewWorkout.Size = new Size(403, 209);
            dataGridViewWorkout.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(329, 273);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxWokout
            // 
            comboBoxWokout.FormattingEnabled = true;
            comboBoxWokout.Items.AddRange(new object[] { "All Data", "Last Week", "Last Month" });
            comboBoxWokout.Location = new Point(26, 274);
            comboBoxWokout.Name = "comboBoxWokout";
            comboBoxWokout.Size = new Size(89, 23);
            comboBoxWokout.TabIndex = 3;
            // 
            // buttonGenerateWokout
            // 
            buttonGenerateWokout.Location = new Point(121, 274);
            buttonGenerateWokout.Name = "buttonGenerateWokout";
            buttonGenerateWokout.Size = new Size(75, 23);
            buttonGenerateWokout.TabIndex = 4;
            buttonGenerateWokout.Text = "Generate";
            buttonGenerateWokout.UseVisualStyleBackColor = true;
            buttonGenerateWokout.Click += buttonGenerateWokout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 5;
            label1.Text = "Workout Repot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(525, 30);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 6;
            label2.Text = "Meal Report";
            // 
            // dataGridViewMeals
            // 
            dataGridViewMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMeals.Location = new Point(525, 58);
            dataGridViewMeals.Name = "dataGridViewMeals";
            dataGridViewMeals.RowTemplate.Height = 25;
            dataGridViewMeals.Size = new Size(389, 209);
            dataGridViewMeals.TabIndex = 7;
            // 
            // comboBoxMeal
            // 
            comboBoxMeal.FormattingEnabled = true;
            comboBoxMeal.Items.AddRange(new object[] { "Get All", "Last Week", "Last Month" });
            comboBoxMeal.Location = new Point(525, 273);
            comboBoxMeal.Name = "comboBoxMeal";
            comboBoxMeal.Size = new Size(121, 23);
            comboBoxMeal.TabIndex = 8;
            // 
            // buttonMeleasGenerate
            // 
            buttonMeleasGenerate.Location = new Point(652, 274);
            buttonMeleasGenerate.Name = "buttonMeleasGenerate";
            buttonMeleasGenerate.Size = new Size(75, 23);
            buttonMeleasGenerate.TabIndex = 9;
            buttonMeleasGenerate.Text = "Generate";
            buttonMeleasGenerate.UseVisualStyleBackColor = true;
            buttonMeleasGenerate.Click += buttonMeleasGenerate_Click;
            // 
            // buttonMealPrint
            // 
            buttonMealPrint.Location = new Point(839, 274);
            buttonMealPrint.Name = "buttonMealPrint";
            buttonMealPrint.Size = new Size(75, 23);
            buttonMealPrint.TabIndex = 10;
            buttonMealPrint.Text = "Print";
            buttonMealPrint.UseVisualStyleBackColor = true;
            buttonMealPrint.Click += buttonMealPrint_Click;
            // 
            // RepotView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(buttonMealPrint);
            Controls.Add(buttonMeleasGenerate);
            Controls.Add(comboBoxMeal);
            Controls.Add(dataGridViewMeals);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGenerateWokout);
            Controls.Add(comboBoxWokout);
            Controls.Add(button1);
            Controls.Add(dataGridViewWorkout);
            Name = "RepotView";
            Text = "RepotView";
            Load += RepotView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkout).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMeals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewWorkout;
        private Button button1;
        private ComboBox comboBoxWokout;
        private Button buttonGenerateWokout;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewMeals;
        private ComboBox comboBoxMeal;
        private Button buttonMeleasGenerate;
        private Button buttonMealPrint;
    }
}