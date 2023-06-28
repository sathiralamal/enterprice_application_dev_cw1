namespace FitnessTrackingApplication.Views
{
    partial class LoginView
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonLogin = new Button();
            buttonCancel = new Button();
            messagelable = new Label();
            createUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(320, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Fitness Application";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(248, 236);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(264, 23);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(248, 265);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(264, 23);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // messagelable
            // 
            messagelable.AutoSize = true;
            messagelable.Location = new Point(351, 93);
            messagelable.Name = "messagelable";
            messagelable.Size = new Size(0, 15);
            messagelable.TabIndex = 5;
            // 
            // createUser
            // 
            createUser.Location = new Point(308, 346);
            createUser.Name = "createUser";
            createUser.Size = new Size(140, 23);
            createUser.TabIndex = 6;
            createUser.Text = "Sign In";
            createUser.UseVisualStyleBackColor = true;
            createUser.Click += createUser_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(createUser);
            Controls.Add(messagelable);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LoginView";
            Text = "LoginView";
            Load += LoginView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonLogin;
        private Button buttonCancel;
        private Label messagelable;
        private Button createUser;
    }
}