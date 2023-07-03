namespace FitnessTrackingApplication.Views
{
    partial class DashbordView
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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            label2 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            labelPrediction = new Label();
            labelPredictionTex = new Label();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(55, 95);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(384, 196);
            cartesianChart1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 40);
            label1.Name = "label1";
            label1.Size = new Size(325, 25);
            label1.TabIndex = 2;
            label1.Text = "Cheat Meal vs Workout (Last month)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(494, 40);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "Workout Details";
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(494, 81);
            pieChart1.MaxAngle = 360D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(281, 235);
            pieChart1.TabIndex = 4;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // labelPrediction
            // 
            labelPrediction.AutoSize = true;
            labelPrediction.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrediction.Location = new Point(78, 318);
            labelPrediction.Name = "labelPrediction";
            labelPrediction.Size = new Size(99, 25);
            labelPrediction.TabIndex = 5;
            labelPrediction.Text = "Prediction";
            // 
            // labelPredictionTex
            // 
            labelPredictionTex.AutoSize = true;
            labelPredictionTex.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPredictionTex.ForeColor = Color.IndianRed;
            labelPredictionTex.Location = new Point(87, 362);
            labelPredictionTex.Name = "labelPredictionTex";
            labelPredictionTex.Size = new Size(55, 21);
            labelPredictionTex.TabIndex = 6;
            labelPredictionTex.Text = "label3";
            labelPredictionTex.Visible = false;
            // 
            // DashbordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 494);
            Controls.Add(labelPredictionTex);
            Controls.Add(labelPrediction);
            Controls.Add(pieChart1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cartesianChart1);
            Name = "DashbordView";
            Text = "Dashbord";
            Load += DashbordView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
        private Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label labelPrediction;
        private Label labelPredictionTex;
    }
}