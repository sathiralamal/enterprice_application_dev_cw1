namespace FitnessTrackingApplication.Views.SubViews
{
    partial class FoodView
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
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            buttonDelete = new Button();
            textBoxFoodID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cancelFoodbtn = new Button();
            submitFoodBtn = new Button();
            textBoxAmount = new TextBox();
            textBoxCalories = new TextBox();
            textBoxFoodName = new TextBox();
            dataGridViewFoods = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(382, 116);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(99, 23);
            buttonSearch.TabIndex = 29;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(37, 116);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(343, 23);
            textBoxSearch.TabIndex = 28;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 192, 192);
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(594, 285);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(216, 33);
            buttonDelete.TabIndex = 27;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxFoodID
            // 
            textBoxFoodID.Location = new Point(707, 106);
            textBoxFoodID.Name = "textBoxFoodID";
            textBoxFoodID.ReadOnly = true;
            textBoxFoodID.Size = new Size(100, 23);
            textBoxFoodID.TabIndex = 26;
            textBoxFoodID.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 80);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 25;
            label5.Text = "Manage Food";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(734, 172);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 24;
            label4.Text = "Amount (g)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 172);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 23;
            label3.Text = "Calories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 22;
            label2.Text = "Food  Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(596, 80);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 21;
            label1.Text = "Modify Food";
            // 
            // cancelFoodbtn
            // 
            cancelFoodbtn.Location = new Point(707, 238);
            cancelFoodbtn.Name = "cancelFoodbtn";
            cancelFoodbtn.Size = new Size(103, 33);
            cancelFoodbtn.TabIndex = 20;
            cancelFoodbtn.Text = "Cancel";
            cancelFoodbtn.UseVisualStyleBackColor = true;
            cancelFoodbtn.Click += cancelFoodbtn_Click_1;
            // 
            // submitFoodBtn
            // 
            submitFoodBtn.Location = new Point(596, 238);
            submitFoodBtn.Name = "submitFoodBtn";
            submitFoodBtn.Size = new Size(105, 33);
            submitFoodBtn.TabIndex = 19;
            submitFoodBtn.Text = "Submit";
            submitFoodBtn.UseVisualStyleBackColor = true;
            submitFoodBtn.Click += submitFoodBtn_Click_1;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(733, 194);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(77, 23);
            textBoxAmount.TabIndex = 18;
            // 
            // textBoxCalories
            // 
            textBoxCalories.Location = new Point(596, 194);
            textBoxCalories.Name = "textBoxCalories";
            textBoxCalories.Size = new Size(119, 23);
            textBoxCalories.TabIndex = 17;
            // 
            // textBoxFoodName
            // 
            textBoxFoodName.Location = new Point(596, 139);
            textBoxFoodName.Name = "textBoxFoodName";
            textBoxFoodName.Size = new Size(214, 23);
            textBoxFoodName.TabIndex = 16;
            // 
            // dataGridViewFoods
            // 
            dataGridViewFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoods.Location = new Point(37, 145);
            dataGridViewFoods.MultiSelect = false;
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewFoods.ReadOnly = true;
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.Size = new Size(444, 173);
            dataGridViewFoods.TabIndex = 15;
            dataGridViewFoods.CellContentClick += dataGridViewFoods_CellContentClick;
            // 
            // FoodView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxFoodID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelFoodbtn);
            Controls.Add(submitFoodBtn);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxCalories);
            Controls.Add(textBoxFoodName);
            Controls.Add(dataGridViewFoods);
            Name = "FoodView";
            Text = "FoodView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Button buttonDelete;
        private TextBox textBoxFoodID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cancelFoodbtn;
        private Button submitFoodBtn;
        private TextBox textBoxAmount;
        private TextBox textBoxCalories;
        private TextBox textBoxFoodName;
        private DataGridView dataGridViewFoods;
    }
}