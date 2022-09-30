using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class Time
    {
        public DateTime ClockTime { get; set; }
        public DateTime AlarmTime { get; set; }
        public Time()
        {

        }
        public Time(DateTime clock, DateTime alarm)
        {
            ClockTime = clock;
            AlarmTime = alarm;
        }
        public string StartTheAlarm()
        {
            return "Wake up";
        }
        public void Snooze(DateTime snz)
        {
            SetAlarm(snz.AddMinutes(1));
        }
        public void SetAlarm(DateTime alarm)
        {
            AlarmTime = alarm;
        }
        public void SetClock(DateTime clock)
        {
            ClockTime = clock;
        }
    }
}
