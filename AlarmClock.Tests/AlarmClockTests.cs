using NUnit.Framework;
using AlarmClock;
using System;

namespace AlarmClock.Tests
{
    [TestFixture]
    public class Tests
    {
        private Time _time;
        private PopUpText _pop;

        [SetUp]
        public void Setup()
        {
            DateTime clock = new DateTime(2022, 09, 29, 12, 40, 0);
            DateTime alarm = new DateTime(2022, 09, 29, 12, 45, 0);
            _time = new Time(clock, alarm);
            _pop = new PopUpText("Test");
        }

        [Test]
        public void PopUpTest()
        {
            string test = "Test";
            Assert.That(_pop.message, Is.EqualTo(test));

        }
        [Test]
        public void WhenAlarmTimeSameAsClockTimeYouCanSnooze()
        {
            _time.Snooze(_time.AlarmTime);
            DateTime snzTime = new DateTime(2022, 09, 29, 12, 46, 0);
            Assert.That(_time.AlarmTime, Is.EqualTo(snzTime));
        }

        [Test]
        public void CheckSchedueldAlarmOnWeekdays()
        {
            _time.ClockTime = new DateTime(2022, 10, 03, 07, 0, 0);
            _time.AlarmTime = new DateTime(2022, 10, 03, 07, 0, 0);
            _time.Weekdays = true;
            _time.Weekends = false;
            bool startAlarm = _time.CheckTime(_time);
            Assert.That(startAlarm, Is.True);
        }
        [Test]
        public void CheckSchedueldAlarmOnWeekends()
        {
            _time.ClockTime = new DateTime(2022, 10, 01, 08, 0, 0);
            _time.AlarmTime = new DateTime(2022, 10, 01, 08, 0, 0);
            _time.Weekdays = false;
            _time.Weekends = true;
            bool startAlarm = _time.CheckTime(_time);
            Assert.That(startAlarm, Is.True);
        }

    }
}