using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningCalculatorWPF
{
    public static class Calculation
    {
        public static int ConvertTimetoSeconds(int hour, int minutes, int seconds)
        {
            return (hour * 3600) + (minutes * 60) + seconds;
        }

        public static double PacetoKMH(Pace pace)
        {



            return 0;
        }


        public static Pace CalculateAveragePace(double Distance, RunningTime runningTime)
        {
            Pace pace = new Pace();

            double timeInSeconds = (runningTime.Hours * 3600) + (runningTime.Minutes * 60) + runningTime.Seconds;

            double paceSeconds = timeInSeconds / Distance;

            pace.Minutes = (int)paceSeconds / 60;
            pace.Seconds = (int)paceSeconds % 60;

            return pace;
        }


    }
}
