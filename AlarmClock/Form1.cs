namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Alarm.Text = "";
            Alarm.Visible = false;
            SnzBtn.Visible = false;
            timer1.Start();
        }
        Time time = new Time();

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.ClockTime = DateTime.Now;
            DayOfWeek.Text = time.ClockTime.DayOfWeek.ToString();
            ShowClockTIme.Text = time.ClockTime.ToString("HH:mm");
            ShowAlarmTime.Text = time.AlarmTime.ToString("HH:mm");
            TimeLbl.Text = time.ClockTime.ToString("HH:mm:ss");
            time.ClockTime.DayOfWeek.ToString();
            bool TurnOnAlarm = time.CheckTime(time);

            if (TurnOnAlarm)
            {
                Alarm.Text = time.StartTheAlarm(time);
                Alarm.Visible=true;
                SnzBtn.Visible=true;
            }
            
        }

        //Kan nog tas bort så kör vi på DateTime.Now
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
        //Kan nog tas bort så kör vi på DateTime.Now
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
        //Kan nog tas bort så kör vi på DateTime.Now
        private void SetClock_Click(object sender, EventArgs e)
        {
            DateTime clock = new DateTime(2022, 09, 29, (int)ClockHourUpDown.Value, (int)ClockMinuteUpDown1.Value, 0);
            time.SetClock(clock);
            timer1.Start();
            timer1.Enabled = true;
        }
        //Ta in input från användaren, Alarmtid Hour
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
        //Ta in input från användaren, Alarmtid Minute
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
        //Sätter Alarmtid med värden från användaren, kallar på metod i Time-klassen
        private void SetAlarm_Click(object sender, EventArgs e)
        {
            DateTime alarm = new DateTime(2022, 09, 29, (int)AlarmHourUpDown.Value, (int)AlarmMinuteUpDown.Value, 0);
            time.SetAlarm(alarm);
        }

        //Sätter en ny Alarmtid, kallar på metod i Time-klassen
        private void SnzBtn_Click(object sender, EventArgs e)
        {
            Alarm.Visible = false;
            time.Snooze(time.ClockTime);
            SnzBtn.Visible = false;
        }

        private void WeekdayChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (WeekdayChBx.Checked == true)
            {
                WeekendsChBx.Enabled = false;
            }
            if (WeekdayChBx.Checked == false)
            {
                WeekendsChBx.Enabled = true;
            }
            
            time.Weekdays = true;
            time.SetDays(time);
        }

        private void WeekendsChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (WeekendsChBx.Checked == true)
            {
                WeekdayChBx.Enabled = false;
                time.Weekends = true;
                time.SetDays(time);
            }
            if (WeekendsChBx.Checked == false)
            {
                WeekdayChBx.Enabled = true;
                time.Weekends = false;
                time.SetDays(time);
            }
            //time.Weekends = true;
            //time.SetDays(time);
        }
    }
}