namespace nQueens
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.nNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.intervalTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.solutionsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nNumericUpDown
            // 
            this.nNumericUpDown.Location = new System.Drawing.Point(27, 19);
            this.nNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nNumericUpDown.Name = "nNumericUpDown";
            this.nNumericUpDown.Size = new System.Drawing.Size(93, 20);
            this.nNumericUpDown.TabIndex = 1;
            this.nNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nNumericUpDown.ValueChanged += new System.EventHandler(this.nNumericUpDown_ValueChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(27, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(93, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // intervalTrackBar
            // 
            this.intervalTrackBar.Location = new System.Drawing.Point(9, 35);
            this.intervalTrackBar.Maximum = 20;
            this.intervalTrackBar.Minimum = 1;
            this.intervalTrackBar.Name = "intervalTrackBar";
            this.intervalTrackBar.Size = new System.Drawing.Size(128, 45);
            this.intervalTrackBar.TabIndex = 3;
            this.intervalTrackBar.Value = 2;
            this.intervalTrackBar.ValueChanged += new System.EventHandler(this.intervalTrackBar_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number Of Queens";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StartButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(23, 19);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(47, 13);
            this.intervalLabel.TabIndex = 4;
            this.intervalLabel.Text = "1000 ms";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.solutionsList);
            this.groupBox3.Location = new System.Drawing.Point(13, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 197);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solutions";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.intervalTrackBar);
            this.groupBox4.Controls.Add(this.intervalLabel);
            this.groupBox4.Location = new System.Drawing.Point(13, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 86);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interval";
            // 
            // solutionsList
            // 
            this.solutionsList.FormattingEnabled = true;
            this.solutionsList.Location = new System.Drawing.Point(9, 19);
            this.solutionsList.Name = "solutionsList";
            this.solutionsList.Size = new System.Drawing.Size(128, 160);
            this.solutionsList.TabIndex = 0;
            this.solutionsList.SelectedIndexChanged += new System.EventHandler(this.solutionsList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "nQueens";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nNumericUpDown;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TrackBar intervalTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox solutionsList;





    }
}

