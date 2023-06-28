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
            textBoxWeight = new TextBox();
            buttonCreate = new Button();
            buttonCancel = new Button();
            messageBox = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 50);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
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
            textBoxPassword.Location = new Point(259, 135);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(189, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(259, 174);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(189, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(261, 218);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(187, 23);
            textBoxWeight.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(259, 271);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(373, 271);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // messageBox
            // 
            messageBox.AutoSize = true;
            messageBox.Location = new Point(319, 19);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(73, 15);
            messageBox.TabIndex = 7;
            messageBox.Text = "messageBox";
            messageBox.Visible = false;
            // 
            // CreateUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(messageBox);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "CreateUserView";
            Text = "CreateUserView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxWeight;
        private Button buttonCreate;
        private Button buttonCancel;
        private Label messageBox;
    }
}