namespace AlarmClock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SnzBtn = new System.Windows.Forms.Button();
            this.Alarm = new System.Windows.Forms.Label();
            this.ShowClockTIme = new System.Windows.Forms.Label();
            this.ShowAlarmTime = new System.Windows.Forms.Label();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.ClockHourUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClockMinuteUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AlarmHourUpDown = new System.Windows.Forms.NumericUpDown();
            this.AlarmMinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.SetClock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClockHourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockMinuteUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmHourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmMinuteUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLbl.Location = new System.Drawing.Point(272, 145);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(142, 65);
            this.TimeLbl.TabIndex = 2;
            this.TimeLbl.Text = "00:00";
            // 
            // SnzBtn
            // 
            this.SnzBtn.Location = new System.Drawing.Point(303, 300);
            this.SnzBtn.Name = "SnzBtn";
            this.SnzBtn.Size = new System.Drawing.Size(75, 23);
            this.SnzBtn.TabIndex = 5;
            this.SnzBtn.Text = "Snooze";
            this.SnzBtn.UseVisualStyleBackColor = true;
            this.SnzBtn.Click += new System.EventHandler(this.SnzBtn_Click);
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(312, 246);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(54, 15);
            this.Alarm.TabIndex = 6;
            this.Alarm.Text = "Wake Up";
            // 
            // ShowClockTIme
            // 
            this.ShowClockTIme.AutoSize = true;
            this.ShowClockTIme.Location = new System.Drawing.Point(29, 38);
            this.ShowClockTIme.Name = "ShowClockTIme";
            this.ShowClockTIme.Size = new System.Drawing.Size(63, 15);
            this.ShowClockTIme.TabIndex = 7;
            this.ShowClockTIme.Text = "ClockTime";
            // 
            // ShowAlarmTime
            // 
            this.ShowAlarmTime.AutoSize = true;
            this.ShowAlarmTime.Location = new System.Drawing.Point(29, 71);
            this.ShowAlarmTime.Name = "ShowAlarmTime";
            this.ShowAlarmTime.Size = new System.Drawing.Size(65, 15);
            this.ShowAlarmTime.TabIndex = 8;
            this.ShowAlarmTime.Text = "AlarmTime";
            // 
            // SetAlarm
            // 
            this.SetAlarm.Location = new System.Drawing.Point(536, 86);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(75, 23);
            this.SetAlarm.TabIndex = 9;
            this.SetAlarm.Text = "Set Alarm";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // ClockHourUpDown
            // 
            this.ClockHourUpDown.Location = new System.Drawing.Point(232, 38);
            this.ClockHourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.ClockHourUpDown.Name = "ClockHourUpDown";
            this.ClockHourUpDown.Size = new System.Drawing.Size(120, 23);
            this.ClockHourUpDown.TabIndex = 10;
            this.ClockHourUpDown.ValueChanged += new System.EventHandler(this.ClockHourUpDown_ValueChanged);
            // 
            // ClockMinuteUpDown1
            // 
            this.ClockMinuteUpDown1.Location = new System.Drawing.Point(378, 36);
            this.ClockMinuteUpDown1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ClockMinuteUpDown1.Name = "ClockMinuteUpDown1";
            this.ClockMinuteUpDown1.Size = new System.Drawing.Size(120, 23);
            this.ClockMinuteUpDown1.TabIndex = 11;
            this.ClockMinuteUpDown1.ValueChanged += new System.EventHandler(this.ClockMinuteUpDown1_ValueChanged);
            // 
            // AlarmHourUpDown
            // 
            this.AlarmHourUpDown.Location = new System.Drawing.Point(232, 86);
            this.AlarmHourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.AlarmHourUpDown.Name = "AlarmHourUpDown";
            this.AlarmHourUpDown.Size = new System.Drawing.Size(120, 23);
            this.AlarmHourUpDown.TabIndex = 12;
            this.AlarmHourUpDown.ValueChanged += new System.EventHandler(this.AlarmHourUpDown_ValueChanged);
            // 
            // AlarmMinuteUpDown
            // 
            this.AlarmMinuteUpDown.Location = new System.Drawing.Point(378, 86);
            this.AlarmMinuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.AlarmMinuteUpDown.Name = "AlarmMinuteUpDown";
            this.AlarmMinuteUpDown.Size = new System.Drawing.Size(120, 23);
            this.AlarmMinuteUpDown.TabIndex = 13;
            this.AlarmMinuteUpDown.ValueChanged += new System.EventHandler(this.AlarmMinuteUpDown_ValueChanged);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(231, 12);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(39, 15);
            this.Hours.TabIndex = 14;
            this.Hours.Text = "Hours";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(377, 11);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(50, 15);
            this.Minutes.TabIndex = 15;
            this.Minutes.Text = "Minutes";
            // 
            // SetClock
            // 
            this.SetClock.Location = new System.Drawing.Point(535, 38);
            this.SetClock.Name = "SetClock";
            this.SetClock.Size = new System.Drawing.Size(75, 23);
            this.SetClock.TabIndex = 16;
            this.SetClock.Text = "Set Clock";
            this.SetClock.UseVisualStyleBackColor = true;
            this.SetClock.Click += new System.EventHandler(this.SetClock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetClock);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.AlarmMinuteUpDown);
            this.Controls.Add(this.AlarmHourUpDown);
            this.Controls.Add(this.ClockMinuteUpDown1);
            this.Controls.Add(this.ClockHourUpDown);
            this.Controls.Add(this.SetAlarm);
            this.Controls.Add(this.ShowAlarmTime);
            this.Controls.Add(this.ShowClockTIme);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.SnzBtn);
            this.Controls.Add(this.TimeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClockHourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockMinuteUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmHourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmMinuteUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label TimeLbl;
        private Button SnzBtn;
        private Label Alarm;
        private Label ShowClockTIme;
        private Label ShowAlarmTime;
        private Button SetAlarm;
        private NumericUpDown ClockHourUpDown;
        private NumericUpDown ClockMinuteUpDown1;
        private NumericUpDown AlarmHourUpDown;
        private NumericUpDown AlarmMinuteUpDown;
        private Label Hours;
        private Label Minutes;
        private Button SetClock;
    }
}