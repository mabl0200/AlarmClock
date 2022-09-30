using NUnit.Framework;
using AlarmClock;
using System;

namespace AlarmClock.Tests
{
    public class Tests
    {
        private Time _time;

        [SetUp]
        public void Setup()
        {
            DateTime clock = new DateTime(2022, 09, 29, 12, 40, 0);
            DateTime alarm = new DateTime(2022, 09, 29, 12, 45, 0);
            _time = new Time(clock, alarm);
        }

        [Test]
        public void WhenAlarmTimeSameAsClockTimeYouCanSnooze()
        {
            _time.Snooze(_time.AlarmTime);
            DateTime snzTime = new DateTime(2022, 09, 29, 12, 46, 0);
            Assert.That(_time.AlarmTime, Is.EqualTo(snzTime));
        }
    }
}