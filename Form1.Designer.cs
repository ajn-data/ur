namespace DigitalUr
{
    partial class Form1
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddhour = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbSeconds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdStart = new System.Windows.Forms.Button();
            this.cdStop = new System.Windows.Forms.Button();
            this.cdDisplay = new System.Windows.Forms.Label();
            this.cdTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(176, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(191, 52);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(500, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.startbtn);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(598, 309);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 40);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.stopbtn);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(696, 309);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.resetbtn);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(553, 242);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(191, 52);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.dt_Tick);
            // 
            // btnAddhour
            // 
            this.btnAddhour.Location = new System.Drawing.Point(544, 355);
            this.btnAddhour.Name = "btnAddhour";
            this.btnAddhour.Size = new System.Drawing.Size(92, 40);
            this.btnAddhour.TabIndex = 10;
            this.btnAddhour.Text = "Add hour";
            this.btnAddhour.UseVisualStyleBackColor = true;
            this.btnAddhour.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 265);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker.TabIndex = 11;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(73, 242);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(0, 17);
            this.lblAlarm.TabIndex = 12;
            this.lblAlarm.Click += new System.EventHandler(this.lblAlarm_Click);
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(12, 326);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(87, 23);
            this.btnSetTime.TabIndex = 13;
            this.btnSetTime.Text = "Set Alarm";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(96, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(50, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alarm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(574, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Stopwatch";
            // 
            // cbMinutes
            // 
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(293, 263);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(63, 24);
            this.cbMinutes.TabIndex = 17;
            // 
            // cbSeconds
            // 
            this.cbSeconds.FormattingEnabled = true;
            this.cbSeconds.Location = new System.Drawing.Point(362, 263);
            this.cbSeconds.Name = "cbSeconds";
            this.cbSeconds.Size = new System.Drawing.Size(63, 24);
            this.cbSeconds.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(286, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Countdown";
            // 
            // cdStart
            // 
            this.cdStart.Location = new System.Drawing.Point(284, 372);
            this.cdStart.Name = "cdStart";
            this.cdStart.Size = new System.Drawing.Size(75, 23);
            this.cdStart.TabIndex = 22;
            this.cdStart.Text = "Start";
            this.cdStart.UseVisualStyleBackColor = true;
            this.cdStart.Click += new System.EventHandler(this.cdStart_Click);
            // 
            // cdStop
            // 
            this.cdStop.Location = new System.Drawing.Point(365, 372);
            this.cdStop.Name = "cdStop";
            this.cdStop.Size = new System.Drawing.Size(75, 23);
            this.cdStop.TabIndex = 23;
            this.cdStop.Text = "Stop";
            this.cdStop.UseVisualStyleBackColor = true;
            this.cdStop.Click += new System.EventHandler(this.cdStop_Click);
            // 
            // cdDisplay
            // 
            this.cdDisplay.AutoSize = true;
            this.cdDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cdDisplay.Location = new System.Drawing.Point(311, 311);
            this.cdDisplay.Name = "cdDisplay";
            this.cdDisplay.Size = new System.Drawing.Size(102, 39);
            this.cdDisplay.TabIndex = 24;
            this.cdDisplay.Text = "00:00";
            // 
            // cdTimer
            // 
            this.cdTimer.Interval = 1000;
            this.cdTimer.Tick += new System.EventHandler(this.cdTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cdDisplay);
            this.Controls.Add(this.cdStop);
            this.Controls.Add(this.cdStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSeconds);
            this.Controls.Add(this.cbMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnAddhour);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddhour;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cdStart;
        private System.Windows.Forms.Button cdStop;
        private System.Windows.Forms.Label cdDisplay;
        private System.Windows.Forms.Timer cdTimer;
    }
}

