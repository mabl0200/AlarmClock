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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmHourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmMinuteUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.TimeLbl.Font = new System.Drawing.Font("Digital dream Fat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLbl.Location = new System.Drawing.Point(238, 114);
            this.TimeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(666, 98);
            this.TimeLbl.TabIndex = 2;
            this.TimeLbl.Text = "00:00:00";
            // 
            // SnzBtn
            // 
            this.SnzBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SnzBtn.Location = new System.Drawing.Point(433, 59);
            this.SnzBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SnzBtn.Name = "SnzBtn";
            this.SnzBtn.Size = new System.Drawing.Size(320, 44);
            this.SnzBtn.TabIndex = 5;
            this.SnzBtn.Text = "Snooze";
            this.SnzBtn.UseVisualStyleBackColor = true;
            this.SnzBtn.Click += new System.EventHandler(this.SnzBtn_Click);
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alarm.Location = new System.Drawing.Point(349, 159);
            this.Alarm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(129, 37);
            this.Alarm.TabIndex = 6;
            this.Alarm.Text = "Wake Up";
            // 
            // ShowAlarmTime
            // 
            this.ShowAlarmTime.AutoSize = true;
            this.ShowAlarmTime.Font = new System.Drawing.Font("Digital dream Fat", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowAlarmTime.Location = new System.Drawing.Point(74, 59);
            this.ShowAlarmTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShowAlarmTime.Name = "ShowAlarmTime";
            this.ShowAlarmTime.Size = new System.Drawing.Size(334, 44);
            this.ShowAlarmTime.TabIndex = 8;
            this.ShowAlarmTime.Text = "AlarmTime";
            // 
            // SetAlarm
            // 
            this.SetAlarm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetAlarm.Location = new System.Drawing.Point(711, 272);
            this.SetAlarm.Margin = new System.Windows.Forms.Padding(6);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(273, 110);
            this.SetAlarm.TabIndex = 9;
            this.SetAlarm.Text = "Set Alarm";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // AlarmHourUpDown
            // 
            this.AlarmHourUpDown.BackColor = System.Drawing.Color.RosyBrown;
            this.AlarmHourUpDown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlarmHourUpDown.Location = new System.Drawing.Point(292, 272);
            this.AlarmHourUpDown.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.AlarmHourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.AlarmHourUpDown.Name = "AlarmHourUpDown";
            this.AlarmHourUpDown.Size = new System.Drawing.Size(153, 44);
            this.AlarmHourUpDown.TabIndex = 12;
            this.AlarmHourUpDown.ValueChanged += new System.EventHandler(this.AlarmHourUpDown_ValueChanged);
            // 
            // AlarmMinuteUpDown
            // 
            this.AlarmMinuteUpDown.BackColor = System.Drawing.Color.RosyBrown;
            this.AlarmMinuteUpDown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlarmMinuteUpDown.Location = new System.Drawing.Point(292, 338);
            this.AlarmMinuteUpDown.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.AlarmMinuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.AlarmMinuteUpDown.Name = "AlarmMinuteUpDown";
            this.AlarmMinuteUpDown.Size = new System.Drawing.Size(153, 44);
            this.AlarmMinuteUpDown.TabIndex = 13;
            this.AlarmMinuteUpDown.ValueChanged += new System.EventHandler(this.AlarmMinuteUpDown_ValueChanged);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hours.Location = new System.Drawing.Point(158, 274);
            this.Hours.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(93, 37);
            this.Hours.TabIndex = 14;
            this.Hours.Text = "Hours";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minutes.Location = new System.Drawing.Point(158, 340);
            this.Minutes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(117, 37);
            this.Minutes.TabIndex = 15;
            this.Minutes.Text = "Minutes";
            // 
            // WeekdayChBx
            // 
            this.WeekdayChBx.AutoSize = true;
            this.WeekdayChBx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeekdayChBx.Location = new System.Drawing.Point(496, 272);
            this.WeekdayChBx.Margin = new System.Windows.Forms.Padding(6);
            this.WeekdayChBx.Name = "WeekdayChBx";
            this.WeekdayChBx.Size = new System.Drawing.Size(180, 41);
            this.WeekdayChBx.TabIndex = 17;
            this.WeekdayChBx.Text = "Weekdays";
            this.WeekdayChBx.UseVisualStyleBackColor = true;
            this.WeekdayChBx.CheckedChanged += new System.EventHandler(this.WeekdayChBx_CheckedChanged);
            // 
            // WeekendsChBx
            // 
            this.WeekendsChBx.AutoSize = true;
            this.WeekendsChBx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeekendsChBx.Location = new System.Drawing.Point(494, 340);
            this.WeekendsChBx.Margin = new System.Windows.Forms.Padding(6);
            this.WeekendsChBx.Name = "WeekendsChBx";
            this.WeekendsChBx.Size = new System.Drawing.Size(181, 41);
            this.WeekendsChBx.TabIndex = 18;
            this.WeekendsChBx.Text = "Weekends";
            this.WeekendsChBx.UseVisualStyleBackColor = true;
            this.WeekendsChBx.CheckedChanged += new System.EventHandler(this.WeekendsChBx_CheckedChanged);
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Font = new System.Drawing.Font("Digital dream Fat", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DayOfWeek.Location = new System.Drawing.Point(238, 61);
            this.DayOfWeek.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Size = new System.Drawing.Size(287, 38);
            this.DayOfWeek.TabIndex = 19;
            this.DayOfWeek.Text = "DayOfWeek";
            // 
            // alarmTextBox
            // 
            this.alarmTextBox.BackColor = System.Drawing.Color.RosyBrown;
            this.alarmTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmTextBox.Location = new System.Drawing.Point(316, 432);
            this.alarmTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.alarmTextBox.Multiline = true;
            this.alarmTextBox.Name = "alarmTextBox";
            this.alarmTextBox.Size = new System.Drawing.Size(668, 37);
            this.alarmTextBox.TabIndex = 20;
            this.alarmTextBox.TextChanged += new System.EventHandler(this.alarmTextBox_TextChanged);
            // 
            // AlarmTextLabel
            // 
            this.AlarmTextLabel.AutoSize = true;
            this.AlarmTextLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlarmTextLabel.Location = new System.Drawing.Point(158, 432);
            this.AlarmTextLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AlarmTextLabel.Name = "AlarmTextLabel";
            this.AlarmTextLabel.Size = new System.Drawing.Size(146, 37);
            this.AlarmTextLabel.TabIndex = 21;
            this.AlarmTextLabel.Text = "Alarm text";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alarm);
            this.groupBox1.Controls.Add(this.ShowAlarmTime);
            this.groupBox1.Controls.Add(this.SnzBtn);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(158, 536);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 293);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALARM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1142, 960);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.TimeLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AlarmHourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmMinuteUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
    }
}