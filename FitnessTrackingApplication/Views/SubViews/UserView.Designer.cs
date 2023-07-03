namespace FitnessTrackingApplication.Views.SubViews
{
    partial class UserView
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            label2 = new Label();
            textBoxWeight = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonCancel = new Button();
            buttonSubmit = new Button();
            buttonDelete = new Button();
            textBoxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(470, 261);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 35);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 1;
            label1.Text = "User Weight Log Manager ";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(41, 63);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(388, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(448, 62);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(63, 23);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(549, 61);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 4;
            label2.Text = "Create Weight Log";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(549, 117);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(193, 23);
            textBoxWeight.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(549, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(655, 191);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(87, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(549, 191);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(89, 23);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(549, 220);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(193, 23);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(549, 88);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(71, 23);
            textBoxID.TabIndex = 10;
            textBoxID.Visible = false;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxID);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonCancel);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxWeight);
            Controls.Add(label2);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserView";
            Text = "UserView";
            Load += UserView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label label2;
        private TextBox textBoxWeight;
        private DateTimePicker dateTimePicker1;
        private Button buttonCancel;
        private Button buttonSubmit;
        private Button buttonDelete;
        private TextBox textBoxID;
    }
}