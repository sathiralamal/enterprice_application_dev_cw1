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
            cartesianChartpred = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.WhiteSmoke;
            cartesianChart1.Location = new Point(13, 35);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(373, 188);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 2;
            label1.Text = "Cheat Meal vs Workout";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(512, 280);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 3;
            label2.Text = "Workout / Meal Comparison";
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.WhiteSmoke;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(20, 17);
            pieChart1.MaxAngle = 360D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(136, 137);
            pieChart1.TabIndex = 4;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // labelPrediction
            // 
            labelPrediction.AutoSize = true;
            labelPrediction.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrediction.Location = new Point(43, 280);
            labelPrediction.Name = "labelPrediction";
            labelPrediction.Size = new Size(80, 20);
            labelPrediction.TabIndex = 5;
            labelPrediction.Text = "Prediction";
            // 
            // labelPredictionTex
            // 
            labelPredictionTex.AutoSize = true;
            labelPredictionTex.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPredictionTex.ForeColor = Color.IndianRed;
            labelPredictionTex.Location = new Point(43, 316);
            labelPredictionTex.Name = "labelPredictionTex";
            labelPredictionTex.Size = new Size(48, 19);
            labelPredictionTex.TabIndex = 6;
            labelPredictionTex.Text = "label3";
            labelPredictionTex.Visible = false;
            // 
            // cartesianChartpred
            // 
            cartesianChartpred.BackColor = Color.WhiteSmoke;
            cartesianChartpred.Location = new Point(9, 35);
            cartesianChartpred.Name = "cartesianChartpred";
            cartesianChartpred.Size = new Size(387, 188);
            cartesianChartpred.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 7);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 8;
            label3.Text = "Weight  prediction";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cartesianChart1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 237);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cartesianChartpred);
            panel2.Location = new Point(492, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 237);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pieChart2);
            panel3.Controls.Add(pieChart1);
            panel3.Location = new Point(492, 316);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 170);
            panel3.TabIndex = 11;
            // 
            // pieChart2
            // 
            pieChart2.BackColor = Color.WhiteSmoke;
            pieChart2.InitialRotation = 0D;
            pieChart2.IsClockwise = true;
            pieChart2.Location = new Point(223, 17);
            pieChart2.MaxAngle = 360D;
            pieChart2.Name = "pieChart2";
            pieChart2.Size = new Size(150, 137);
            pieChart2.TabIndex = 5;
            pieChart2.Total = null;
            // 
            // DashbordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 494);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelPredictionTex);
            Controls.Add(labelPrediction);
            Controls.Add(label2);
            Name = "DashbordView";
            Text = "Dashbord";
            Load += DashbordView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
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
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChartpred;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
    }
}