namespace FitnessTrackingApplication.Views
{
    partial class ApplicationView
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageDashbord = new TabPage();
            tabPageMeal = new TabPage();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caloriesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodBindingSource1 = new BindingSource(components);
            tabPageWorkOut = new TabPage();
            tabPageRepots = new TabPage();
            foodBindingSource = new BindingSource(components);
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            tabControl1.SuspendLayout();
            tabPageMeal.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 59);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDashbord);
            tabControl1.Controls.Add(tabPageMeal);
            tabControl1.Controls.Add(tabPageWorkOut);
            tabControl1.Controls.Add(tabPageRepots);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 503);
            tabControl1.TabIndex = 1;
            // 
            // tabPageDashbord
            // 
            tabPageDashbord.Location = new Point(4, 24);
            tabPageDashbord.Name = "tabPageDashbord";
            tabPageDashbord.Padding = new Padding(3);
            tabPageDashbord.Size = new Size(1033, 475);
            tabPageDashbord.TabIndex = 0;
            tabPageDashbord.Text = "Dashbord";
            tabPageDashbord.UseVisualStyleBackColor = true;
            // 
            // tabPageMeal
            // 
            tabPageMeal.Controls.Add(tabControl2);
            tabPageMeal.Location = new Point(4, 24);
            tabPageMeal.Name = "tabPageMeal";
            tabPageMeal.Padding = new Padding(3);
            tabPageMeal.Size = new Size(1033, 475);
            tabPageMeal.TabIndex = 1;
            tabPageMeal.Text = "Meals";
            tabPageMeal.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1027, 469);
            tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1019, 441);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "WorkOut";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonSearch);
            tabPage2.Controls.Add(textBoxSearch);
            tabPage2.Controls.Add(buttonDelete);
            tabPage2.Controls.Add(textBoxFoodID);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cancelFoodbtn);
            tabPage2.Controls.Add(submitFoodBtn);
            tabPage2.Controls.Add(textBoxAmount);
            tabPage2.Controls.Add(textBoxCalories);
            tabPage2.Controls.Add(textBoxFoodName);
            tabPage2.Controls.Add(dataGridViewFoods);
            tabPage2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1019, 441);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Food";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 192, 192);
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(600, 234);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(216, 33);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxFoodID
            // 
            textBoxFoodID.Location = new Point(713, 55);
            textBoxFoodID.Name = "textBoxFoodID";
            textBoxFoodID.ReadOnly = true;
            textBoxFoodID.Size = new Size(100, 27);
            textBoxFoodID.TabIndex = 11;
            textBoxFoodID.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 29);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 10;
            label5.Text = "Food Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(740, 121);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 9;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 121);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Calories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 65);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(602, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 6;
            label1.Text = "Create Food";
            // 
            // cancelFoodbtn
            // 
            cancelFoodbtn.Location = new Point(713, 187);
            cancelFoodbtn.Name = "cancelFoodbtn";
            cancelFoodbtn.Size = new Size(103, 33);
            cancelFoodbtn.TabIndex = 5;
            cancelFoodbtn.Text = "Cancel";
            cancelFoodbtn.UseVisualStyleBackColor = true;
            cancelFoodbtn.Click += cancelFoodbtn_Click;
            // 
            // submitFoodBtn
            // 
            submitFoodBtn.Location = new Point(602, 187);
            submitFoodBtn.Name = "submitFoodBtn";
            submitFoodBtn.Size = new Size(105, 33);
            submitFoodBtn.TabIndex = 4;
            submitFoodBtn.Text = "Submit";
            submitFoodBtn.UseVisualStyleBackColor = true;
            submitFoodBtn.Click += submitFoodBtn_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(739, 143);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(77, 27);
            textBoxAmount.TabIndex = 3;
            // 
            // textBoxCalories
            // 
            textBoxCalories.Location = new Point(602, 143);
            textBoxCalories.Name = "textBoxCalories";
            textBoxCalories.Size = new Size(119, 27);
            textBoxCalories.TabIndex = 2;
            // 
            // textBoxFoodName
            // 
            textBoxFoodName.Location = new Point(602, 88);
            textBoxFoodName.Name = "textBoxFoodName";
            textBoxFoodName.Size = new Size(214, 27);
            textBoxFoodName.TabIndex = 1;
            // 
            // dataGridViewFoods
            // 
            dataGridViewFoods.AutoGenerateColumns = false;
            dataGridViewFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoods.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, caloriesDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            dataGridViewFoods.DataSource = foodBindingSource1;
            dataGridViewFoods.Location = new Point(16, 102);
            dataGridViewFoods.MultiSelect = false;
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewFoods.ReadOnly = true;
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.Size = new Size(444, 155);
            dataGridViewFoods.TabIndex = 0;
            dataGridViewFoods.CellContentClick += dataGridViewFoods_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            caloriesDataGridViewTextBoxColumn.DataPropertyName = "calories";
            caloriesDataGridViewTextBoxColumn.HeaderText = "calories";
            caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            caloriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            amountDataGridViewTextBoxColumn.HeaderText = "amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodBindingSource1
            // 
            foodBindingSource1.DataSource = typeof(Models.Food);
            // 
            // tabPageWorkOut
            // 
            tabPageWorkOut.Location = new Point(4, 24);
            tabPageWorkOut.Name = "tabPageWorkOut";
            tabPageWorkOut.Size = new Size(1033, 475);
            tabPageWorkOut.TabIndex = 2;
            tabPageWorkOut.Text = "Workout";
            tabPageWorkOut.UseVisualStyleBackColor = true;
            // 
            // tabPageRepots
            // 
            tabPageRepots.Location = new Point(4, 24);
            tabPageRepots.Name = "tabPageRepots";
            tabPageRepots.Size = new Size(1033, 475);
            tabPageRepots.TabIndex = 3;
            tabPageRepots.Text = "Repots";
            tabPageRepots.UseVisualStyleBackColor = true;
            // 
            // foodBindingSource
            // 
            foodBindingSource.DataSource = typeof(Models.Food);
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(16, 62);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(343, 27);
            textBoxSearch.TabIndex = 13;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(365, 62);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(99, 30);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // ApplicationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 570);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ApplicationView";
            Text = "ApplicationView";
            tabControl1.ResumeLayout(false);
            tabPageMeal.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageDashbord;
        private TabPage tabPageMeal;
        private TabPage tabPageWorkOut;
        private TabPage tabPageRepots;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private BindingSource foodBindingSource;
        private DataGridView dataGridViewFoods;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private BindingSource foodBindingSource1;
        private TextBox textBoxAmount;
        private TextBox textBoxCalories;
        private TextBox textBoxFoodName;
        private Label label1;
        private Button cancelFoodbtn;
        private Button submitFoodBtn;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBoxFoodID;
        private Button buttonDelete;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}