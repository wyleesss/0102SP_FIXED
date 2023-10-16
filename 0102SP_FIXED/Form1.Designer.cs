namespace _0102SP_FIXED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            processListView = new ListView();
            label3 = new Label();
            label4 = new Label();
            countLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            stopButton = new Button();
            startButton = new Button();
            label8 = new Label();
            label9 = new Label();
            programmState = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(970, 41);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(98, 26);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "00:00:00";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20000;
            timer.Tick += timerTick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(970, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "data for:";
            // 
            // processListView
            // 
            processListView.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            processListView.Location = new Point(5, 5);
            processListView.Name = "processListView";
            processListView.Size = new Size(949, 463);
            processListView.TabIndex = 5;
            processListView.UseCompatibleStateImageBehavior = false;
            processListView.View = View.Details;
            processListView.Columns.Add("Process Name", 230, HorizontalAlignment.Center);
            processListView.Columns.Add("ID", 100, HorizontalAlignment.Center);
            processListView.Columns.Add("CPU Usage (%)", 150, HorizontalAlignment.Center);
            processListView.Columns.Add("Memory Usage (MB)", 200, HorizontalAlignment.Center);
            processListView.Columns.Add("Start Time", 100, HorizontalAlignment.Center);
            processListView.Columns.Add("Thread Count", 145, HorizontalAlignment.Center);
            processListView.Font = new Font(processListView.Font, FontStyle.Bold);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(970, 84);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "process";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(970, 97);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "count:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            countLabel.Location = new Point(970, 117);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(24, 26);
            countLabel.TabIndex = 8;
            countLabel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(970, 159);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 9;
            label6.Text = "update";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(970, 175);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 10;
            label7.Text = "for:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(975, 196);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(60, 34);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(970, 227);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 12;
            label5.Text = "seconds";
            // 
            // stopButton
            // 
            stopButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stopButton.Location = new Point(975, 353);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(77, 46);
            stopButton.TabIndex = 13;
            stopButton.Text = "STOP";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(975, 405);
            startButton.Name = "startButton";
            startButton.Size = new Size(77, 46);
            startButton.TabIndex = 14;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(970, 270);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 15;
            label8.Text = "programm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(970, 286);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 16;
            label9.Text = "state:";
            // 
            // programmState
            // 
            programmState.AutoSize = true;
            programmState.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            programmState.ForeColor = Color.Blue;
            programmState.Location = new Point(970, 300);
            programmState.Name = "programmState";
            programmState.Size = new Size(79, 25);
            programmState.TabIndex = 17;
            programmState.Text = "running";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 472);
            Controls.Add(label8);
            Controls.Add(startButton);
            Controls.Add(stopButton);
            Controls.Add(numericUpDown1);
            Controls.Add(countLabel);
            Controls.Add(processListView);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(programmState);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systems Programming";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();

            update();
        }

        #endregion
        private Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Label label2;
        private ListView processListView;
        private Label label3;
        private Label label4;
        private Label countLabel;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Button stopButton;
        private Button startButton;
        private Label label8;
        private Label label9;
        private Label programmState;
    }
}