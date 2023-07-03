namespace FitnessTrackingApplication.Views
{
    partial class CreateUserView
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
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            buttonCreate = new Button();
            buttonCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 35);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Create User";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(259, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(189, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(259, 146);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(189, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(259, 190);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(189, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(261, 233);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(89, 37);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(373, 233);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 37);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 76);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 128);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 172);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // CreateUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "CreateUserView";
            Text = "CreateUserView";
            Load += CreateUserView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}