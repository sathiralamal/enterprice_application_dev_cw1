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
            dataGridViewWorkouts = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            textBoxTotalCal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkouts).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(55, 70);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(452, 23);
            textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(513, 74);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(87, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
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
            label2.Location = new Point(638, 76);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 4;
            label2.Text = "Mofiy Wokouts";
            // 
            // comboBoxExesice
            // 
            comboBoxExesice.FormattingEnabled = true;
            comboBoxExesice.Location = new Point(644, 149);
            comboBoxExesice.Name = "comboBoxExesice";
            comboBoxExesice.Size = new Size(128, 23);
            comboBoxExesice.TabIndex = 5;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(778, 149);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(81, 23);
            textBoxTime.TabIndex = 6;
            // 
            // buttonExeAdd
            // 
            buttonExeAdd.Location = new Point(644, 178);
            buttonExeAdd.Name = "buttonExeAdd";
            buttonExeAdd.Size = new Size(128, 23);
            buttonExeAdd.TabIndex = 7;
            buttonExeAdd.Text = "Add Exersise";
            buttonExeAdd.UseVisualStyleBackColor = true;
            buttonExeAdd.Click += buttonExeAdd_Click;
            // 
            // labelTotalCalories
            // 
            labelTotalCalories.AutoSize = true;
            labelTotalCalories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalCalories.Location = new Point(734, 286);
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
            label3.Location = new Point(638, 286);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 10;
            label3.Text = "Total Calories";
            // 
            // buttonAddWokout
            // 
            buttonAddWokout.Location = new Point(638, 321);
            buttonAddWokout.Name = "buttonAddWokout";
            buttonAddWokout.Size = new Size(105, 23);
            buttonAddWokout.TabIndex = 11;
            buttonAddWokout.Text = "Log Workout";
            buttonAddWokout.UseVisualStyleBackColor = true;
            buttonAddWokout.Click += buttonAddWokout_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(767, 321);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(92, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(638, 352);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(221, 23);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxExesise
            // 
            listBoxExesise.FormattingEnabled = true;
            listBoxExesise.ItemHeight = 15;
            listBoxExesise.Location = new Point(644, 207);
            listBoxExesise.Name = "listBoxExesise";
            listBoxExesise.Size = new Size(215, 64);
            listBoxExesise.TabIndex = 14;
            listBoxExesise.SelectedIndexChanged += listBoxExesise_SelectedIndexChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(644, 104);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(89, 23);
            textBoxID.TabIndex = 15;
            textBoxID.Visible = false;
            // 
            // checkBoxRecursive
            // 
            checkBoxRecursive.AutoSize = true;
            checkBoxRecursive.Location = new Point(781, 287);
            checkBoxRecursive.Name = "checkBoxRecursive";
            checkBoxRecursive.Size = new Size(76, 19);
            checkBoxRecursive.TabIndex = 16;
            checkBoxRecursive.Text = "Recursive";
            checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWorkouts
            // 
            dataGridViewWorkouts.AllowUserToAddRows = false;
            dataGridViewWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkouts.Location = new Point(55, 104);
            dataGridViewWorkouts.Name = "dataGridViewWorkouts";
            dataGridViewWorkouts.ReadOnly = true;
            dataGridViewWorkouts.RowTemplate.Height = 25;
            dataGridViewWorkouts.Size = new Size(545, 271);
            dataGridViewWorkouts.TabIndex = 17;
            dataGridViewWorkouts.CellContentDoubleClick += dataGridViewWorkouts_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 130);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 18;
            label4.Text = "Exersise";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(781, 128);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 19;
            label5.Text = "hours";
            // 
            // textBoxTotalCal
            // 
            textBoxTotalCal.Location = new Point(778, 178);
            textBoxTotalCal.Name = "textBoxTotalCal";
            textBoxTotalCal.Size = new Size(81, 23);
            textBoxTotalCal.TabIndex = 20;
            textBoxTotalCal.Visible = false;
            // 
            // WorkoutView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(textBoxTotalCal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridViewWorkouts);
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
        private DataGridView dataGridViewWorkouts;
        private Label label4;
        private Label label5;
        private TextBox textBoxTotalCal;
    }
}