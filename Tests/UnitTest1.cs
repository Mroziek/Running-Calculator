using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunningCalculatorWPF;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAveragePace()
        {
            RunningTime runningTime = new RunningTime();
            runningTime.Hours = 1;
            runningTime.Minutes = 21;
            runningTime.Seconds = 50;

            Pace pace = Calculation.CalculateAveragePace(21.097, runningTime);

            Assert.AreEqual(pace.Minutes,3);
            Assert.AreEqual(pace.Seconds,52);
        }

        public void TestPaceKMH()
        {
            RunningTime runningTime = new RunningTime();
            runningTime.Hours = 1;
            runningTime.Minutes = 21;
            runningTime.Seconds = 50;

            Pace pace = Calculation.CalculateAveragePace(21.097, runningTime);

            Assert.AreEqual(pace.Minutes, 3);
            Assert.AreEqual(pace.Seconds, 52);
        }
    }
}
