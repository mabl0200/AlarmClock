namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Alarm.Visible = false;
            SnzBtn.Visible = false;

            timer1.Start();
        }
        Time time = new Time();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time.ClockTime = DateTime.Now;
            ShowClockTIme.Text = time.ClockTime.ToString("HH:mm");
            ShowAlarmTime.Text = time.AlarmTime.ToString("HH:mm");
            TimeLbl.Text = time.ClockTime.ToString("HH:mm:ss");
            if (time.ClockTime.Hour == time.AlarmTime.Hour && time.ClockTime.Minute == time.AlarmTime.Minute && time.ClockTime.Second == time.AlarmTime.Second)
            {
                Alarm.Text = time.StartTheAlarm();
                Alarm.Visible=true;
                SnzBtn.Visible=true;
            }
        }

        private void SnzBtn_Click(object sender, EventArgs e)
        {
            Alarm.Visible = false;
            time.Snooze(time.ClockTime);
            SnzBtn.Visible = false;
        }

        private void SetAlarm_Click(object sender, EventArgs e)
        {
            DateTime alarm = new DateTime(2022, 09, 29, (int)AlarmHourUpDown.Value, (int)AlarmMinuteUpDown.Value, 0);
            time.SetAlarm(alarm);
        }

        private void ClockHourUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var timeInput = ClockHourUpDown.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClockMinuteUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var timeInput = ClockMinuteUpDown1.Value;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void AlarmHourUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var timeInput = AlarmHourUpDown.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AlarmMinuteUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var timeInput = AlarmMinuteUpDown.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetClock_Click(object sender, EventArgs e)
        {
            DateTime clock = new DateTime(2022, 09, 29, (int)ClockHourUpDown.Value, (int)ClockMinuteUpDown1.Value, 0);
            time.SetClock(clock);
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}