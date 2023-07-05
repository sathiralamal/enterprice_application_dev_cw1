namespace FitnessTrackingApplication.Views
{
    partial class MainView
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
            panel1 = new Panel();
            buttonUserWeight = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            mainPanal = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonUserWeight);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 503);
            panel1.TabIndex = 0;
            // 
            // buttonUserWeight
            // 
            buttonUserWeight.BackColor = Color.Gold;
            buttonUserWeight.Location = new Point(12, 222);
            buttonUserWeight.Name = "buttonUserWeight";
            buttonUserWeight.Size = new Size(128, 29);
            buttonUserWeight.TabIndex = 6;
            buttonUserWeight.Text = "User Log";
            buttonUserWeight.UseVisualStyleBackColor = false;
            buttonUserWeight.Click += buttonUserWeight_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.Location = new Point(12, 188);
            button6.Name = "button6";
            button6.Size = new Size(128, 28);
            button6.TabIndex = 5;
            button6.Text = "Repots";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Location = new Point(12, 154);
            button5.Name = "button5";
            button5.Size = new Size(128, 28);
            button5.TabIndex = 4;
            button5.Text = "WorkOut";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Location = new Point(12, 120);
            button4.Name = "button4";
            button4.Size = new Size(128, 28);
            button4.TabIndex = 3;
            button4.Text = "Exersises";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Location = new Point(12, 86);
            button3.Name = "button3";
            button3.Size = new Size(128, 28);
            button3.TabIndex = 2;
            button3.Text = "Foods";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(12, 51);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 1;
            button2.Text = "Meals";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 33);
            button1.TabIndex = 0;
            button1.Text = "Dashbord";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mainPanal
            // 
            mainPanal.Location = new Point(149, 0);
            mainPanal.Name = "mainPanal";
            mainPanal.Size = new Size(940, 503);
            mainPanal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fitness1;
            pictureBox1.Location = new Point(3, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 503);
            Controls.Add(mainPanal);
            Controls.Add(panel1);
            Name = "MainView";
            Text = "Fitness Application";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel mainPanal;
        private Button button6;
        private Button buttonUserWeight;
        private PictureBox pictureBox1;
    }
}