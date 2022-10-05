using System.Media;

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
            stopBtn.Visible = false;
            timer1.Start();

        }
        Time time = new Time();
        PopUpText pop = new PopUpText("");
        private bool run = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.ClockTime = DateTime.Now;
            DayOfWeek.Text = time.ClockTime.DayOfWeek.ToString();
            ShowAlarmTime.Text = time.AlarmTime.ToString("HH:mm");
            TimeLbl.Text = time.ClockTime.ToString("HH:mm:ss");
            time.ClockTime.DayOfWeek.ToString();
            bool TurnOnAlarm = time.CheckTime(time);


            if (TurnOnAlarm)
            {
                
                Alarm.Text = pop.message;
              //  Alarm.Text = time.StartTheAlarm(time);
                Alarm.Visible=true;
                SnzBtn.Visible=true;
                stopBtn.Visible = true;
                CheckIfAlarmGoesOf(time);

            }
            
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
            run = false;
        }
        private void stopBtn_Click(object sender, EventArgs e)
        {
            Alarm.Visible = false;
            SnzBtn.Visible = false;
            stopBtn.Visible = false;
            run = false;
        }

        private void WeekdayChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (WeekdayChBx.Checked == true)
            {
                WeekendsChBx.Enabled = false;
                time.Weekdays = true;
                time.SetDays(time);
            }
            if (WeekdayChBx.Checked == false)
            {
                WeekendsChBx.Enabled = true;
                time.Weekdays = false;
                time.SetDays(time);
            }

            //time.Weekdays = true;
            //time.SetDays(time);
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

        private void alarmTextBox_TextChanged(object sender, EventArgs e)
        {
            pop.PopUp(alarmTextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool CheckIfAlarmGoesOf(Time _time)
        {
            bool TurnOnAlarm = time.CheckTime(_time);
            if (TurnOnAlarm)
            {
                ThreadPool.QueueUserWorkItem(AlarmGoesOf);
                return true;
            }

            return false;
        }

        public void AlarmGoesOf(object stateInfo)
        {
            SoundPlayer soundAlarm = new(soundLocation:"alarmsound.wav");
            run = true;
            while (run)
            {
                GbAlarm.Invoke((MethodInvoker) (() => 
                    GbAlarm.BackColor = Color.LightPink));
                Thread.Sleep(250);
                GbAlarm.Invoke((MethodInvoker)(() =>
                    GbAlarm.BackColor = Color.RosyBrown));
                Thread.Sleep(250);

                if (AlarmSound.Checked == true)
                {
                    soundAlarm.Play();
                }
            }
            soundAlarm.Stop();
        }

        private void PresetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (PresetAlarm.Checked == true)
            {
                DateTime changeTime = DateTime.Now;
                changeTime = changeTime.AddDays(1);
                DateTime alarm = new DateTime(2022, 10, changeTime.Day, 9, 14, 0);
                time.SetAlarm(alarm);
                ShowAlarmTime.Visible = true;
            }
            if (PresetAlarm.Checked == false)
            {
                ShowAlarmTime.Visible = false;
                DateTime alarm = new DateTime(2022, 10, 04, 9, 14, 0);
                time.SetAlarm(alarm);
            }
        }
    }
}