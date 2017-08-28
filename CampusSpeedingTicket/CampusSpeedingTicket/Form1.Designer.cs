namespace CampusSpeedingTicket
{
    partial class speedingTicket
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
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.TimeOfDaygroupBox = new System.Windows.Forms.GroupBox();
            this.nightRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sophTextBox = new System.Windows.Forms.TextBox();
            this.studentsGroupBox = new System.Windows.Forms.GroupBox();
            this.sophmoreRadioButton = new System.Windows.Forms.RadioButton();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.freshTextBox = new System.Windows.Forms.TextBox();
            this.visitorRadioButton = new System.Windows.Forms.RadioButton();
            this.staffRadioButton = new System.Windows.Forms.RadioButton();
            this.visitorStaffGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this.ticketTotal = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeOfDaygroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.studentsGroupBox.SuspendLayout();
            this.visitorStaffGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(123, 18);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(44, 17);
            this.dayRadioButton.TabIndex = 0;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Day";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // TimeOfDaygroupBox
            // 
            this.TimeOfDaygroupBox.Controls.Add(this.nightRadioButton);
            this.TimeOfDaygroupBox.Controls.Add(this.dayRadioButton);
            this.TimeOfDaygroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfDaygroupBox.Location = new System.Drawing.Point(9, 120);
            this.TimeOfDaygroupBox.Name = "TimeOfDaygroupBox";
            this.TimeOfDaygroupBox.Size = new System.Drawing.Size(485, 41);
            this.TimeOfDaygroupBox.TabIndex = 1;
            this.TimeOfDaygroupBox.TabStop = false;
            this.TimeOfDaygroupBox.Text = "Time of Day";
            // 
            // nightRadioButton
            // 
            this.nightRadioButton.AutoSize = true;
            this.nightRadioButton.Location = new System.Drawing.Point(317, 18);
            this.nightRadioButton.Name = "nightRadioButton";
            this.nightRadioButton.Size = new System.Drawing.Size(50, 17);
            this.nightRadioButton.TabIndex = 1;
            this.nightRadioButton.TabStop = true;
            this.nightRadioButton.Text = "Night";
            this.nightRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visitorStaffGroupBox);
            this.groupBox1.Controls.Add(this.TimeOfDaygroupBox);
            this.groupBox1.Controls.Add(this.studentsGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles over speed limit";
            // 
            // sophTextBox
            // 
            this.sophTextBox.Location = new System.Drawing.Point(133, 69);
            this.sophTextBox.Name = "sophTextBox";
            this.sophTextBox.Size = new System.Drawing.Size(104, 20);
            this.sophTextBox.TabIndex = 4;
            this.sophTextBox.TextChanged += new System.EventHandler(this.sophTextBox_TextChanged);
            // 
            // studentsGroupBox
            // 
            this.studentsGroupBox.Controls.Add(this.freshTextBox);
            this.studentsGroupBox.Controls.Add(this.label3);
            this.studentsGroupBox.Controls.Add(this.freshmanRadioButton);
            this.studentsGroupBox.Controls.Add(this.sophmoreRadioButton);
            this.studentsGroupBox.Controls.Add(this.label2);
            this.studentsGroupBox.Controls.Add(this.sophTextBox);
            this.studentsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.studentsGroupBox.Name = "studentsGroupBox";
            this.studentsGroupBox.Size = new System.Drawing.Size(247, 100);
            this.studentsGroupBox.TabIndex = 3;
            this.studentsGroupBox.TabStop = false;
            this.studentsGroupBox.Text = "Students";
            // 
            // sophmoreRadioButton
            // 
            this.sophmoreRadioButton.AutoSize = true;
            this.sophmoreRadioButton.Location = new System.Drawing.Point(143, 23);
            this.sophmoreRadioButton.Name = "sophmoreRadioButton";
            this.sophmoreRadioButton.Size = new System.Drawing.Size(73, 17);
            this.sophmoreRadioButton.TabIndex = 5;
            this.sophmoreRadioButton.TabStop = true;
            this.sophmoreRadioButton.Text = "Sophmore";
            this.sophmoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(23, 25);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadioButton.TabIndex = 6;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            this.freshmanRadioButton.CheckedChanged += new System.EventHandler(this.freshmanRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miles over speed limit";
            // 
            // freshTextBox
            // 
            this.freshTextBox.Location = new System.Drawing.Point(9, 68);
            this.freshTextBox.Name = "freshTextBox";
            this.freshTextBox.Size = new System.Drawing.Size(100, 20);
            this.freshTextBox.TabIndex = 8;
            this.freshTextBox.TextChanged += new System.EventHandler(this.freshTextBox_TextChanged);
            // 
            // visitorRadioButton
            // 
            this.visitorRadioButton.AutoSize = true;
            this.visitorRadioButton.Location = new System.Drawing.Point(15, 25);
            this.visitorRadioButton.Name = "visitorRadioButton";
            this.visitorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.visitorRadioButton.TabIndex = 4;
            this.visitorRadioButton.TabStop = true;
            this.visitorRadioButton.Text = "Visitor";
            this.visitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // staffRadioButton
            // 
            this.staffRadioButton.AutoSize = true;
            this.staffRadioButton.Location = new System.Drawing.Point(98, 25);
            this.staffRadioButton.Name = "staffRadioButton";
            this.staffRadioButton.Size = new System.Drawing.Size(86, 17);
            this.staffRadioButton.TabIndex = 5;
            this.staffRadioButton.TabStop = true;
            this.staffRadioButton.Text = "Staff/Faculty";
            this.staffRadioButton.UseVisualStyleBackColor = true;
            // 
            // visitorStaffGroupBox
            // 
            this.visitorStaffGroupBox.Controls.Add(this.staffRadioButton);
            this.visitorStaffGroupBox.Controls.Add(this.visitorRadioButton);
            this.visitorStaffGroupBox.Location = new System.Drawing.Point(288, 14);
            this.visitorStaffGroupBox.Name = "visitorStaffGroupBox";
            this.visitorStaffGroupBox.Size = new System.Drawing.Size(206, 100);
            this.visitorStaffGroupBox.TabIndex = 3;
            this.visitorStaffGroupBox.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(21, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 28);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Ticket";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.Location = new System.Drawing.Point(303, 14);
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(161, 20);
            this.ticketPriceTextBox.TabIndex = 4;
            this.ticketPriceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ticketTotal
            // 
            this.ticketTotal.AutoSize = true;
            this.ticketTotal.Location = new System.Drawing.Point(215, 16);
            this.ticketTotal.Name = "ticketTotal";
            this.ticketTotal.Size = new System.Drawing.Size(82, 13);
            this.ticketTotal.TabIndex = 5;
            this.ticketTotal.Text = "Pay this amount";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(448, 235);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(83, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calculateButton);
            this.groupBox2.Controls.Add(this.ticketTotal);
            this.groupBox2.Controls.Add(this.ticketPriceTextBox);
            this.groupBox2.Location = new System.Drawing.Point(24, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // speedingTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "speedingTicket";
            this.Text = "PSTCC Speeding Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TimeOfDaygroupBox.ResumeLayout(false);
            this.TimeOfDaygroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.studentsGroupBox.ResumeLayout(false);
            this.studentsGroupBox.PerformLayout();
            this.visitorStaffGroupBox.ResumeLayout(false);
            this.visitorStaffGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.GroupBox TimeOfDaygroupBox;
        private System.Windows.Forms.RadioButton nightRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox visitorStaffGroupBox;
        private System.Windows.Forms.RadioButton staffRadioButton;
        private System.Windows.Forms.RadioButton visitorRadioButton;
        private System.Windows.Forms.GroupBox studentsGroupBox;
        private System.Windows.Forms.TextBox freshTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.RadioButton sophmoreRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sophTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox ticketPriceTextBox;
        private System.Windows.Forms.Label ticketTotal;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

