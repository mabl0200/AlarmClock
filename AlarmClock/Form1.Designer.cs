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
            this.ShowAlarmTime = new System.Windows.Forms.Label();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.AlarmHourUpDown = new System.Windows.Forms.NumericUpDown();
            this.AlarmMinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.WeekdayChBx = new System.Windows.Forms.CheckBox();
            this.WeekendsChBx = new System.Windows.Forms.CheckBox();
            this.DayOfWeek = new System.Windows.Forms.Label();
            this.alarmTextBox = new System.Windows.Forms.TextBox();
            this.AlarmTextLabel = new System.Windows.Forms.Label();
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
            // ShowAlarmTime
            // 
            this.ShowAlarmTime.AutoSize = true;
            this.ShowAlarmTime.Location = new System.Drawing.Point(30, 35);
            this.ShowAlarmTime.Name = "ShowAlarmTime";
            this.ShowAlarmTime.Size = new System.Drawing.Size(65, 15);
            this.ShowAlarmTime.TabIndex = 8;
            this.ShowAlarmTime.Text = "AlarmTime";
            // 
            // SetAlarm
            // 
            this.SetAlarm.Location = new System.Drawing.Point(420, 36);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(75, 23);
            this.SetAlarm.TabIndex = 9;
            this.SetAlarm.Text = "Set Alarm";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // AlarmHourUpDown
            // 
            this.AlarmHourUpDown.Location = new System.Drawing.Point(282, 36);
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
            this.AlarmMinuteUpDown.Location = new System.Drawing.Point(282, 65);
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
            this.Hours.Location = new System.Drawing.Point(226, 36);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(39, 15);
            this.Hours.TabIndex = 14;
            this.Hours.Text = "Hours";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(226, 67);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(50, 15);
            this.Minutes.TabIndex = 15;
            this.Minutes.Text = "Minutes";
            // 
            // WeekdayChBx
            // 
            this.WeekdayChBx.AutoSize = true;
            this.WeekdayChBx.Location = new System.Drawing.Point(511, 35);
            this.WeekdayChBx.Name = "WeekdayChBx";
            this.WeekdayChBx.Size = new System.Drawing.Size(79, 19);
            this.WeekdayChBx.TabIndex = 17;
            this.WeekdayChBx.Text = "Weekdays";
            this.WeekdayChBx.UseVisualStyleBackColor = true;
            this.WeekdayChBx.CheckedChanged += new System.EventHandler(this.WeekdayChBx_CheckedChanged);
            // 
            // WeekendsChBx
            // 
            this.WeekendsChBx.AutoSize = true;
            this.WeekendsChBx.Location = new System.Drawing.Point(510, 67);
            this.WeekendsChBx.Name = "WeekendsChBx";
            this.WeekendsChBx.Size = new System.Drawing.Size(80, 19);
            this.WeekendsChBx.TabIndex = 18;
            this.WeekendsChBx.Text = "Weekends";
            this.WeekendsChBx.UseVisualStyleBackColor = true;
            this.WeekendsChBx.CheckedChanged += new System.EventHandler(this.WeekendsChBx_CheckedChanged);
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Location = new System.Drawing.Point(302, 123);
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Size = new System.Drawing.Size(69, 15);
            this.DayOfWeek.TabIndex = 19;
            this.DayOfWeek.Text = "DayOfWeek";
            // 
            // alarmTextBox
            // 
            this.alarmTextBox.Location = new System.Drawing.Point(33, 183);
            this.alarmTextBox.Multiline = true;
            this.alarmTextBox.Name = "alarmTextBox";
            this.alarmTextBox.Size = new System.Drawing.Size(162, 78);
            this.alarmTextBox.TabIndex = 20;
            this.alarmTextBox.TextChanged += new System.EventHandler(this.alarmTextBox_TextChanged);
            // 
            // AlarmTextLabel
            // 
            this.AlarmTextLabel.AutoSize = true;
            this.AlarmTextLabel.Location = new System.Drawing.Point(33, 145);
            this.AlarmTextLabel.Name = "AlarmTextLabel";
            this.AlarmTextLabel.Size = new System.Drawing.Size(62, 15);
            this.AlarmTextLabel.TabIndex = 21;
            this.AlarmTextLabel.Text = "Alarm text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlarmTextLabel);
            this.Controls.Add(this.alarmTextBox);
            this.Controls.Add(this.DayOfWeek);
            this.Controls.Add(this.WeekendsChBx);
            this.Controls.Add(this.WeekdayChBx);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.AlarmMinuteUpDown);
            this.Controls.Add(this.AlarmHourUpDown);
            this.Controls.Add(this.SetAlarm);
            this.Controls.Add(this.ShowAlarmTime);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.SnzBtn);
            this.Controls.Add(this.TimeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private Label ShowAlarmTime;
        private Button SetAlarm;
        private NumericUpDown AlarmHourUpDown;
        private NumericUpDown AlarmMinuteUpDown;
        private Label Hours;
        private Label Minutes;
        private CheckBox WeekdayChBx;
        private CheckBox WeekendsChBx;
        private Label DayOfWeek;
        private TextBox alarmTextBox;
        private Label AlarmTextLabel;
    }
}