namespace InteriorRoomPaintEstimator
{
    partial class InteriorPaintRoomEstimatorForm
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
            this.roomSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.roomLengthBox = new System.Windows.Forms.GroupBox();
            this.lengthInchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthInchTextBox = new System.Windows.Forms.TextBox();
            this.lengthFeetTextBox = new System.Windows.Forms.TextBox();
            this.widthRoomBox = new System.Windows.Forms.GroupBox();
            this.widthInchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.widthInchTextBox = new System.Windows.Forms.TextBox();
            this.widthFeetTextBox = new System.Windows.Forms.TextBox();
            this.roomHeightBox = new System.Windows.Forms.GroupBox();
            this.inchHeightLabel = new System.Windows.Forms.Label();
            this.heightFeetLabel = new System.Windows.Forms.Label();
            this.heightInchTextBox = new System.Windows.Forms.TextBox();
            this.heightFeetTextBox = new System.Windows.Forms.TextBox();
            this.doorsWindowsGroupBox = new System.Windows.Forms.GroupBox();
            this.numDoorsBox = new System.Windows.Forms.GroupBox();
            this.numOfDoorsTextBox = new System.Windows.Forms.TextBox();
            this.numWindowsBox = new System.Windows.Forms.GroupBox();
            this.numOfWindowsTextBox = new System.Windows.Forms.TextBox();
            this.numOfCoatsBox = new System.Windows.Forms.GroupBox();
            this.numOfCoatsGroupBox = new System.Windows.Forms.GroupBox();
            this.numOfCoatsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.estimateResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.numOfQuartsTextBox = new System.Windows.Forms.TextBox();
            this.numOfGallonsTextBox = new System.Windows.Forms.TextBox();
            this.numOfQuartsLabel = new System.Windows.Forms.Label();
            this.numOfGallonsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.createdSummer2017ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomSizeGroupBox.SuspendLayout();
            this.roomLengthBox.SuspendLayout();
            this.widthRoomBox.SuspendLayout();
            this.roomHeightBox.SuspendLayout();
            this.doorsWindowsGroupBox.SuspendLayout();
            this.numDoorsBox.SuspendLayout();
            this.numWindowsBox.SuspendLayout();
            this.numOfCoatsBox.SuspendLayout();
            this.numOfCoatsGroupBox.SuspendLayout();
            this.estimateResultsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomSizeGroupBox
            // 
            this.roomSizeGroupBox.Controls.Add(this.roomLengthBox);
            this.roomSizeGroupBox.Controls.Add(this.widthRoomBox);
            this.roomSizeGroupBox.Controls.Add(this.roomHeightBox);
            this.roomSizeGroupBox.Location = new System.Drawing.Point(12, 40);
            this.roomSizeGroupBox.Name = "roomSizeGroupBox";
            this.roomSizeGroupBox.Size = new System.Drawing.Size(401, 100);
            this.roomSizeGroupBox.TabIndex = 0;
            this.roomSizeGroupBox.TabStop = false;
            this.roomSizeGroupBox.Text = "Room Dimensions";
            // 
            // roomLengthBox
            // 
            this.roomLengthBox.Controls.Add(this.lengthInchLabel);
            this.roomLengthBox.Controls.Add(this.label2);
            this.roomLengthBox.Controls.Add(this.lengthInchTextBox);
            this.roomLengthBox.Controls.Add(this.lengthFeetTextBox);
            this.roomLengthBox.Location = new System.Drawing.Point(274, 19);
            this.roomLengthBox.Name = "roomLengthBox";
            this.roomLengthBox.Size = new System.Drawing.Size(112, 75);
            this.roomLengthBox.TabIndex = 3;
            this.roomLengthBox.TabStop = false;
            this.roomLengthBox.Text = "Room Length";
            // 
            // lengthInchLabel
            // 
            this.lengthInchLabel.AutoSize = true;
            this.lengthInchLabel.Location = new System.Drawing.Point(64, 22);
            this.lengthInchLabel.Name = "lengthInchLabel";
            this.lengthInchLabel.Size = new System.Drawing.Size(39, 13);
            this.lengthInchLabel.TabIndex = 5;
            this.lengthInchLabel.Text = "Inches";
            this.lengthInchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthInchTextBox
            // 
            this.lengthInchTextBox.Location = new System.Drawing.Point(58, 38);
            this.lengthInchTextBox.Name = "lengthInchTextBox";
            this.lengthInchTextBox.Size = new System.Drawing.Size(45, 20);
            this.lengthInchTextBox.TabIndex = 1;
            this.lengthInchTextBox.TextChanged += new System.EventHandler(this.lengthInchTextBox_TextChanged);
            // 
            // lengthFeetTextBox
            // 
            this.lengthFeetTextBox.Location = new System.Drawing.Point(7, 38);
            this.lengthFeetTextBox.Name = "lengthFeetTextBox";
            this.lengthFeetTextBox.Size = new System.Drawing.Size(46, 20);
            this.lengthFeetTextBox.TabIndex = 0;
            this.lengthFeetTextBox.TextChanged += new System.EventHandler(this.lengthFeetTextBox_TextChanged);
            // 
            // widthRoomBox
            // 
            this.widthRoomBox.Controls.Add(this.widthInchLabel);
            this.widthRoomBox.Controls.Add(this.label1);
            this.widthRoomBox.Controls.Add(this.widthInchTextBox);
            this.widthRoomBox.Controls.Add(this.widthFeetTextBox);
            this.widthRoomBox.Location = new System.Drawing.Point(147, 19);
            this.widthRoomBox.Name = "widthRoomBox";
            this.widthRoomBox.Size = new System.Drawing.Size(114, 75);
            this.widthRoomBox.TabIndex = 2;
            this.widthRoomBox.TabStop = false;
            this.widthRoomBox.Text = "Room Width";
            this.widthRoomBox.Enter += new System.EventHandler(this.widthRoomBox_Enter);
            // 
            // widthInchLabel
            // 
            this.widthInchLabel.AutoSize = true;
            this.widthInchLabel.Location = new System.Drawing.Point(66, 22);
            this.widthInchLabel.Name = "widthInchLabel";
            this.widthInchLabel.Size = new System.Drawing.Size(39, 13);
            this.widthInchLabel.TabIndex = 4;
            this.widthInchLabel.Text = "Inches";
            this.widthInchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthInchTextBox
            // 
            this.widthInchTextBox.Location = new System.Drawing.Point(60, 38);
            this.widthInchTextBox.Name = "widthInchTextBox";
            this.widthInchTextBox.Size = new System.Drawing.Size(45, 20);
            this.widthInchTextBox.TabIndex = 1;
            this.widthInchTextBox.TextChanged += new System.EventHandler(this.widthInchTextBox_TextChanged);
            // 
            // widthFeetTextBox
            // 
            this.widthFeetTextBox.Location = new System.Drawing.Point(8, 38);
            this.widthFeetTextBox.Name = "widthFeetTextBox";
            this.widthFeetTextBox.Size = new System.Drawing.Size(46, 20);
            this.widthFeetTextBox.TabIndex = 0;
            this.widthFeetTextBox.TextChanged += new System.EventHandler(this.widthFeetTextBox_TextChanged);
            // 
            // roomHeightBox
            // 
            this.roomHeightBox.Controls.Add(this.inchHeightLabel);
            this.roomHeightBox.Controls.Add(this.heightFeetLabel);
            this.roomHeightBox.Controls.Add(this.heightInchTextBox);
            this.roomHeightBox.Controls.Add(this.heightFeetTextBox);
            this.roomHeightBox.Location = new System.Drawing.Point(15, 19);
            this.roomHeightBox.Name = "roomHeightBox";
            this.roomHeightBox.Size = new System.Drawing.Size(112, 75);
            this.roomHeightBox.TabIndex = 1;
            this.roomHeightBox.TabStop = false;
            this.roomHeightBox.Text = "Room Height";
            // 
            // inchHeightLabel
            // 
            this.inchHeightLabel.AutoSize = true;
            this.inchHeightLabel.Location = new System.Drawing.Point(64, 22);
            this.inchHeightLabel.Name = "inchHeightLabel";
            this.inchHeightLabel.Size = new System.Drawing.Size(39, 13);
            this.inchHeightLabel.TabIndex = 3;
            this.inchHeightLabel.Text = "Inches";
            this.inchHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightFeetLabel
            // 
            this.heightFeetLabel.AutoSize = true;
            this.heightFeetLabel.Location = new System.Drawing.Point(15, 23);
            this.heightFeetLabel.Name = "heightFeetLabel";
            this.heightFeetLabel.Size = new System.Drawing.Size(28, 13);
            this.heightFeetLabel.TabIndex = 2;
            this.heightFeetLabel.Text = "Feet";
            this.heightFeetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightInchTextBox
            // 
            this.heightInchTextBox.Location = new System.Drawing.Point(58, 39);
            this.heightInchTextBox.Name = "heightInchTextBox";
            this.heightInchTextBox.Size = new System.Drawing.Size(45, 20);
            this.heightInchTextBox.TabIndex = 1;
            this.heightInchTextBox.TextChanged += new System.EventHandler(this.heightInchTextBox_TextChanged);
            // 
            // heightFeetTextBox
            // 
            this.heightFeetTextBox.Location = new System.Drawing.Point(6, 39);
            this.heightFeetTextBox.Name = "heightFeetTextBox";
            this.heightFeetTextBox.Size = new System.Drawing.Size(46, 20);
            this.heightFeetTextBox.TabIndex = 0;
            this.heightFeetTextBox.TextChanged += new System.EventHandler(this.heightFeetTextBox_TextChanged);
            // 
            // doorsWindowsGroupBox
            // 
            this.doorsWindowsGroupBox.Controls.Add(this.numDoorsBox);
            this.doorsWindowsGroupBox.Controls.Add(this.numWindowsBox);
            this.doorsWindowsGroupBox.Location = new System.Drawing.Point(152, 146);
            this.doorsWindowsGroupBox.Name = "doorsWindowsGroupBox";
            this.doorsWindowsGroupBox.Size = new System.Drawing.Size(261, 75);
            this.doorsWindowsGroupBox.TabIndex = 1;
            this.doorsWindowsGroupBox.TabStop = false;
            this.doorsWindowsGroupBox.Text = "Doors/Windows";
            // 
            // numDoorsBox
            // 
            this.numDoorsBox.Controls.Add(this.numOfDoorsTextBox);
            this.numDoorsBox.Location = new System.Drawing.Point(15, 19);
            this.numDoorsBox.Name = "numDoorsBox";
            this.numDoorsBox.Size = new System.Drawing.Size(104, 49);
            this.numDoorsBox.TabIndex = 1;
            this.numDoorsBox.TabStop = false;
            this.numDoorsBox.Text = "# of Doors";
            // 
            // numOfDoorsTextBox
            // 
            this.numOfDoorsTextBox.Location = new System.Drawing.Point(7, 20);
            this.numOfDoorsTextBox.Name = "numOfDoorsTextBox";
            this.numOfDoorsTextBox.Size = new System.Drawing.Size(90, 20);
            this.numOfDoorsTextBox.TabIndex = 0;
            this.numOfDoorsTextBox.TextChanged += new System.EventHandler(this.numOfDoorsTextBox_TextChanged);
            // 
            // numWindowsBox
            // 
            this.numWindowsBox.Controls.Add(this.numOfWindowsTextBox);
            this.numWindowsBox.Location = new System.Drawing.Point(141, 19);
            this.numWindowsBox.Name = "numWindowsBox";
            this.numWindowsBox.Size = new System.Drawing.Size(103, 49);
            this.numWindowsBox.TabIndex = 0;
            this.numWindowsBox.TabStop = false;
            this.numWindowsBox.Text = "# of Windows";
            // 
            // numOfWindowsTextBox
            // 
            this.numOfWindowsTextBox.Location = new System.Drawing.Point(7, 20);
            this.numOfWindowsTextBox.Name = "numOfWindowsTextBox";
            this.numOfWindowsTextBox.Size = new System.Drawing.Size(90, 20);
            this.numOfWindowsTextBox.TabIndex = 0;
            this.numOfWindowsTextBox.TextChanged += new System.EventHandler(this.numOfWindowsTextBox_TextChanged);
            // 
            // numOfCoatsBox
            // 
            this.numOfCoatsBox.Controls.Add(this.numOfCoatsGroupBox);
            this.numOfCoatsBox.Location = new System.Drawing.Point(13, 147);
            this.numOfCoatsBox.Name = "numOfCoatsBox";
            this.numOfCoatsBox.Size = new System.Drawing.Size(134, 74);
            this.numOfCoatsBox.TabIndex = 2;
            this.numOfCoatsBox.TabStop = false;
            this.numOfCoatsBox.Text = "Number of Coats";
            // 
            // numOfCoatsGroupBox
            // 
            this.numOfCoatsGroupBox.Controls.Add(this.numOfCoatsTextBox);
            this.numOfCoatsGroupBox.Location = new System.Drawing.Point(15, 20);
            this.numOfCoatsGroupBox.Name = "numOfCoatsGroupBox";
            this.numOfCoatsGroupBox.Size = new System.Drawing.Size(103, 47);
            this.numOfCoatsGroupBox.TabIndex = 0;
            this.numOfCoatsGroupBox.TabStop = false;
            this.numOfCoatsGroupBox.Text = "# of Paint Coats";
            // 
            // numOfCoatsTextBox
            // 
            this.numOfCoatsTextBox.Location = new System.Drawing.Point(7, 18);
            this.numOfCoatsTextBox.Name = "numOfCoatsTextBox";
            this.numOfCoatsTextBox.Size = new System.Drawing.Size(90, 20);
            this.numOfCoatsTextBox.TabIndex = 0;
            this.numOfCoatsTextBox.TextChanged += new System.EventHandler(this.numOfCoatsTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(27, 291);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 33);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(173, 291);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 33);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(311, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // estimateResultsGroupBox
            // 
            this.estimateResultsGroupBox.Controls.Add(this.numOfQuartsTextBox);
            this.estimateResultsGroupBox.Controls.Add(this.numOfGallonsTextBox);
            this.estimateResultsGroupBox.Controls.Add(this.numOfQuartsLabel);
            this.estimateResultsGroupBox.Controls.Add(this.numOfGallonsLabel);
            this.estimateResultsGroupBox.Location = new System.Drawing.Point(13, 227);
            this.estimateResultsGroupBox.Name = "estimateResultsGroupBox";
            this.estimateResultsGroupBox.Size = new System.Drawing.Size(400, 49);
            this.estimateResultsGroupBox.TabIndex = 6;
            this.estimateResultsGroupBox.TabStop = false;
            this.estimateResultsGroupBox.Text = "Paint Estimate Results";
            // 
            // numOfQuartsTextBox
            // 
            this.numOfQuartsTextBox.Location = new System.Drawing.Point(310, 19);
            this.numOfQuartsTextBox.Name = "numOfQuartsTextBox";
            this.numOfQuartsTextBox.Size = new System.Drawing.Size(54, 20);
            this.numOfQuartsTextBox.TabIndex = 3;
            // 
            // numOfGallonsTextBox
            // 
            this.numOfGallonsTextBox.Location = new System.Drawing.Point(123, 19);
            this.numOfGallonsTextBox.Name = "numOfGallonsTextBox";
            this.numOfGallonsTextBox.Size = new System.Drawing.Size(56, 20);
            this.numOfGallonsTextBox.TabIndex = 2;
            // 
            // numOfQuartsLabel
            // 
            this.numOfQuartsLabel.AutoSize = true;
            this.numOfQuartsLabel.Location = new System.Drawing.Point(193, 26);
            this.numOfQuartsLabel.Name = "numOfQuartsLabel";
            this.numOfQuartsLabel.Size = new System.Drawing.Size(111, 13);
            this.numOfQuartsLabel.TabIndex = 1;
            this.numOfQuartsLabel.Text = "and Number of Quarts";
            // 
            // numOfGallonsLabel
            // 
            this.numOfGallonsLabel.AutoSize = true;
            this.numOfGallonsLabel.Location = new System.Drawing.Point(23, 26);
            this.numOfGallonsLabel.Name = "numOfGallonsLabel";
            this.numOfGallonsLabel.Size = new System.Drawing.Size(94, 13);
            this.numOfGallonsLabel.TabIndex = 0;
            this.numOfGallonsLabel.Text = "Number of Gallons";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.createdSummer2017ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Author: Lokey, F.M.";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // createdSummer2017ToolStripMenuItem
            // 
            this.createdSummer2017ToolStripMenuItem.Name = "createdSummer2017ToolStripMenuItem";
            this.createdSummer2017ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createdSummer2017ToolStripMenuItem.Text = "Created:Summer 2017";
            // 
            // InteriorPaintRoomEstimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 334);
            this.Controls.Add(this.estimateResultsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numOfCoatsBox);
            this.Controls.Add(this.doorsWindowsGroupBox);
            this.Controls.Add(this.roomSizeGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InteriorPaintRoomEstimatorForm";
            this.Text = "Interior Room Paint Estimator";
            this.roomSizeGroupBox.ResumeLayout(false);
            this.roomLengthBox.ResumeLayout(false);
            this.roomLengthBox.PerformLayout();
            this.widthRoomBox.ResumeLayout(false);
            this.widthRoomBox.PerformLayout();
            this.roomHeightBox.ResumeLayout(false);
            this.roomHeightBox.PerformLayout();
            this.doorsWindowsGroupBox.ResumeLayout(false);
            this.numDoorsBox.ResumeLayout(false);
            this.numDoorsBox.PerformLayout();
            this.numWindowsBox.ResumeLayout(false);
            this.numWindowsBox.PerformLayout();
            this.numOfCoatsBox.ResumeLayout(false);
            this.numOfCoatsGroupBox.ResumeLayout(false);
            this.numOfCoatsGroupBox.PerformLayout();
            this.estimateResultsGroupBox.ResumeLayout(false);
            this.estimateResultsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox roomSizeGroupBox;
        private System.Windows.Forms.GroupBox roomLengthBox;
        private System.Windows.Forms.GroupBox widthRoomBox;
        private System.Windows.Forms.GroupBox roomHeightBox;
        private System.Windows.Forms.TextBox heightFeetTextBox;
        private System.Windows.Forms.GroupBox doorsWindowsGroupBox;
        private System.Windows.Forms.GroupBox numDoorsBox;
        private System.Windows.Forms.TextBox numOfDoorsTextBox;
        private System.Windows.Forms.GroupBox numWindowsBox;
        private System.Windows.Forms.TextBox numOfWindowsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengthInchTextBox;
        private System.Windows.Forms.TextBox lengthFeetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthInchTextBox;
        private System.Windows.Forms.TextBox widthFeetTextBox;
        private System.Windows.Forms.Label heightFeetLabel;
        private System.Windows.Forms.TextBox heightInchTextBox;
        private System.Windows.Forms.Label lengthInchLabel;
        private System.Windows.Forms.Label widthInchLabel;
        private System.Windows.Forms.Label inchHeightLabel;
        private System.Windows.Forms.GroupBox numOfCoatsBox;
        private System.Windows.Forms.GroupBox numOfCoatsGroupBox;
        private System.Windows.Forms.TextBox numOfCoatsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox estimateResultsGroupBox;
        private System.Windows.Forms.TextBox numOfQuartsTextBox;
        private System.Windows.Forms.TextBox numOfGallonsTextBox;
        private System.Windows.Forms.Label numOfQuartsLabel;
        private System.Windows.Forms.Label numOfGallonsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem createdSummer2017ToolStripMenuItem;
    }
}

