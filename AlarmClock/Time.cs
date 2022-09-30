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
        public bool Weekdays { get; set; }
        public bool Weekends { get; set; }

        public Time()
        {

        }
        public Time(DateTime clock, DateTime alarm)
        {
            ClockTime = clock;
            AlarmTime = alarm;
        }
        public string StartTheAlarm(Time time)
        {
            if (time.Weekdays == false && time.Weekends == false)
            {
                return "";
            }
            else if (time.Weekdays == true || time.Weekends == true)
            {
                return $"Wake up it is {time.ClockTime.DayOfWeek}"; 
            }
            else
            {
                return "Wake up";
            }

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
        public void SetDays(Time days)
        {
            if (days.Weekdays == true)
            {
                days.Weekends = false;
            }
            if (days.Weekends == true)
            {
                days.Weekdays = false;
            }
        }
        
    }
}
