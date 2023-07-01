namespace FitnessTrackingApplication.Views.SubViews
{
    partial class WorkoutView
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
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridViewWorkouts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            comboBoxExesice = new ComboBox();
            textBoxTime = new TextBox();
            buttonExeAdd = new Button();
            labelTotalCalories = new Label();
            label3 = new Label();
            buttonAddWokout = new Button();
            buttonCancel = new Button();
            buttonDelete = new Button();
            listBoxExesise = new ListBox();
            textBoxID = new TextBox();
            checkBoxRecursive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkouts).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(55, 70);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(321, 23);
            textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(393, 70);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewWorkouts
            // 
            dataGridViewWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkouts.Enabled = false;
            dataGridViewWorkouts.Location = new Point(57, 109);
            dataGridViewWorkouts.Name = "dataGridViewWorkouts";
            dataGridViewWorkouts.RowTemplate.Height = 25;
            dataGridViewWorkouts.Size = new Size(411, 256);
            dataGridViewWorkouts.TabIndex = 2;
            dataGridViewWorkouts.CellContentClick += dataGridViewWorkouts_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 3;
            label1.Text = "Manage Workout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 70);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 4;
            label2.Text = "Mofiy Wokouts";
            // 
            // comboBoxExesice
            // 
            comboBoxExesice.FormattingEnabled = true;
            comboBoxExesice.Location = new Point(522, 125);
            comboBoxExesice.Name = "comboBoxExesice";
            comboBoxExesice.Size = new Size(128, 23);
            comboBoxExesice.TabIndex = 5;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(656, 125);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(70, 23);
            textBoxTime.TabIndex = 6;
            // 
            // buttonExeAdd
            // 
            buttonExeAdd.Location = new Point(522, 163);
            buttonExeAdd.Name = "buttonExeAdd";
            buttonExeAdd.Size = new Size(105, 23);
            buttonExeAdd.TabIndex = 7;
            buttonExeAdd.Text = "Add Exersise";
            buttonExeAdd.UseVisualStyleBackColor = true;
            buttonExeAdd.Click += buttonExeAdd_Click;
            // 
            // labelTotalCalories
            // 
            labelTotalCalories.AutoSize = true;
            labelTotalCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalCalories.Location = new Point(629, 293);
            labelTotalCalories.Name = "labelTotalCalories";
            labelTotalCalories.Size = new Size(21, 19);
            labelTotalCalories.TabIndex = 9;
            labelTotalCalories.Text = "0 ";
            labelTotalCalories.Click += labelTotalCalories_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(522, 293);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 10;
            label3.Text = "Total Calories";
            // 
            // buttonAddWokout
            // 
            buttonAddWokout.Location = new Point(522, 315);
            buttonAddWokout.Name = "buttonAddWokout";
            buttonAddWokout.Size = new Size(105, 23);
            buttonAddWokout.TabIndex = 11;
            buttonAddWokout.Text = "Log Workout";
            buttonAddWokout.UseVisualStyleBackColor = true;
            buttonAddWokout.Click += buttonAddWokout_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(651, 315);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(522, 346);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(204, 23);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Visible = false;
            // 
            // listBoxExesise
            // 
            listBoxExesise.FormattingEnabled = true;
            listBoxExesise.ItemHeight = 15;
            listBoxExesise.Location = new Point(528, 201);
            listBoxExesise.Name = "listBoxExesise";
            listBoxExesise.Size = new Size(198, 79);
            listBoxExesise.TabIndex = 14;
            listBoxExesise.SelectedIndexChanged += listBoxExesise_SelectedIndexChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(523, 98);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(89, 23);
            textBoxID.TabIndex = 15;
            textBoxID.Visible = false;
            // 
            // checkBoxRecursive
            // 
            checkBoxRecursive.AutoSize = true;
            checkBoxRecursive.Location = new Point(643, 167);
            checkBoxRecursive.Name = "checkBoxRecursive";
            checkBoxRecursive.Size = new Size(76, 19);
            checkBoxRecursive.TabIndex = 16;
            checkBoxRecursive.Text = "Recursive";
            checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // WorkoutView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxRecursive);
            Controls.Add(textBoxID);
            Controls.Add(listBoxExesise);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddWokout);
            Controls.Add(label3);
            Controls.Add(labelTotalCalories);
            Controls.Add(buttonExeAdd);
            Controls.Add(textBoxTime);
            Controls.Add(comboBoxExesice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewWorkouts);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Name = "WorkoutView";
            Text = "Workout";
            Load += WorkoutView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkouts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridView dataGridViewWorkouts;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxExesice;
        private TextBox textBoxTime;
        private Button buttonExeAdd;
        private Label labelTotalCalories;
        private Label label3;
        private Button buttonAddWokout;
        private Button buttonCancel;
        private Button buttonDelete;
        private ListBox listBoxExesise;
        private TextBox textBoxID;
        private CheckBox checkBoxRecursive;
    }
}