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
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkout).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWorkout
            // 
            dataGridViewWorkout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkout.Location = new Point(26, 58);
            dataGridViewWorkout.Name = "dataGridViewWorkout";
            dataGridViewWorkout.RowTemplate.Height = 25;
            dataGridViewWorkout.Size = new Size(364, 209);
            dataGridViewWorkout.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(26, 284);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "print workout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RepotView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewWorkout);
            Name = "RepotView";
            Text = "RepotView";
            Load += RepotView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewWorkout;
        private Button button1;
    }
}