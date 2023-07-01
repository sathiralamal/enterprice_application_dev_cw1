namespace FitnessTrackingApplication.Views.SubViews
{
    partial class ExerciseView
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
            textBoxExeName = new TextBox();
            textBoxExeCalory = new TextBox();
            textBoxExeDiscription = new TextBox();
            buttonSubmit = new Button();
            buttonCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonDelete = new Button();
            dataGridViewExe = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exerciseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exerciseDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caloriesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exerciseBindingSource = new BindingSource(components);
            textBoxSearchBox = new TextBox();
            buttonSearch = new Button();
            label5 = new Label();
            textBoxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exerciseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(515, 63);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Modify Exercise";
            // 
            // textBoxExeName
            // 
            textBoxExeName.Location = new Point(516, 116);
            textBoxExeName.Name = "textBoxExeName";
            textBoxExeName.Size = new Size(165, 23);
            textBoxExeName.TabIndex = 1;
            // 
            // textBoxExeCalory
            // 
            textBoxExeCalory.Location = new Point(516, 160);
            textBoxExeCalory.Name = "textBoxExeCalory";
            textBoxExeCalory.Size = new Size(165, 23);
            textBoxExeCalory.TabIndex = 2;
            // 
            // textBoxExeDiscription
            // 
            textBoxExeDiscription.Location = new Point(516, 204);
            textBoxExeDiscription.Name = "textBoxExeDiscription";
            textBoxExeDiscription.Size = new Size(165, 23);
            textBoxExeDiscription.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(516, 233);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(606, 233);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 93);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Exercis Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 142);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 7;
            label3.Text = "Calories burn for 1 hour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 186);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Discription";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(517, 261);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(164, 23);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewExe
            // 
            dataGridViewExe.AutoGenerateColumns = false;
            dataGridViewExe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExe.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, exerciseNameDataGridViewTextBoxColumn, exerciseDescriptionDataGridViewTextBoxColumn, caloriesDataGridViewTextBoxColumn });
            dataGridViewExe.DataSource = exerciseBindingSource;
            dataGridViewExe.Location = new Point(24, 116);
            dataGridViewExe.Name = "dataGridViewExe";
            dataGridViewExe.ReadOnly = true;
            dataGridViewExe.RowTemplate.Height = 25;
            dataGridViewExe.Size = new Size(433, 168);
            dataGridViewExe.TabIndex = 10;
            dataGridViewExe.CellContentClick += dataGridViewExe_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exerciseNameDataGridViewTextBoxColumn
            // 
            exerciseNameDataGridViewTextBoxColumn.DataPropertyName = "ExerciseName";
            exerciseNameDataGridViewTextBoxColumn.HeaderText = "ExerciseName";
            exerciseNameDataGridViewTextBoxColumn.Name = "exerciseNameDataGridViewTextBoxColumn";
            exerciseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exerciseDescriptionDataGridViewTextBoxColumn
            // 
            exerciseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ExerciseDescription";
            exerciseDescriptionDataGridViewTextBoxColumn.HeaderText = "ExerciseDescription";
            exerciseDescriptionDataGridViewTextBoxColumn.Name = "exerciseDescriptionDataGridViewTextBoxColumn";
            exerciseDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            caloriesDataGridViewTextBoxColumn.HeaderText = "Calories";
            caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            caloriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exerciseBindingSource
            // 
            exerciseBindingSource.DataSource = typeof(Models.Exercise);
            // 
            // textBoxSearchBox
            // 
            textBoxSearchBox.Location = new Point(24, 81);
            textBoxSearchBox.Name = "textBoxSearchBox";
            textBoxSearchBox.Size = new Size(354, 23);
            textBoxSearchBox.TabIndex = 11;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(384, 81);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 35);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 13;
            label5.Text = "Manage Exercise";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(606, 90);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(75, 23);
            textBoxID.TabIndex = 14;
            textBoxID.Visible = false;
            // 
            // ExerciseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearchBox);
            Controls.Add(dataGridViewExe);
            Controls.Add(buttonDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxExeDiscription);
            Controls.Add(textBoxExeCalory);
            Controls.Add(textBoxExeName);
            Controls.Add(label1);
            Name = "ExerciseView";
            Text = "ExerciseView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExe).EndInit();
            ((System.ComponentModel.ISupportInitialize)exerciseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxExeName;
        private TextBox textBoxExeCalory;
        private TextBox textBoxExeDiscription;
        private Button buttonSubmit;
        private Button buttonCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonDelete;
        private DataGridView dataGridViewExe;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exerciseDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private BindingSource exerciseBindingSource;
        private TextBox textBoxSearchBox;
        private Button buttonSearch;
        private Label label5;
        private TextBox textBoxID;
    }
}