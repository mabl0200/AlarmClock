using NUnit.Framework;
using AlarmClock;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AlarmClock.Tests
{
    [TestFixture]
    public class Tests
    {
        private Time _time;
        private PopUpText _pop;
        private Form1 _form1;

        [SetUp]
        public void Setup()
        {
            DateTime clock = new DateTime(2022, 09, 29, 12, 40, 0);
            DateTime alarm = new DateTime(2022, 09, 29, 12, 45, 0);
            _time = new Time(clock, alarm);
            _pop = new PopUpText("Test");
            _form1 = new Form1();
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
        public void CheckPresetAlarm()
        {
            _time.PresetAlarm(_time.AlarmTime);
            DateTime presetTime = _time.AlarmTime;
            Assert.That(_time.AlarmTime, Is.EqualTo(presetTime));
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

        [Test]
        public void CheckSoundWhenAlarmGoesOff()
        {
            var time = new Time
            {
                AlarmTime = new DateTime(2022, 10, 01, 08, 0, 0),
                ClockTime = new DateTime(2022, 10, 01, 08, 0, 0)
            };
            bool check = _form1.CheckIfAlarmGoesOf(time);
            Assert.That(check, Is.True);
        }
    }
}