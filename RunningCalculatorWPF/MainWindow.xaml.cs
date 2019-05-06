using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RunningCalculatorWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RunningTime runningTime = new RunningTime();
                runningTime.Hours = int.Parse(HoursText.Text);
                runningTime.Minutes = int.Parse(MinutesText.Text);
                runningTime.Seconds = int.Parse(SecondsText.Text);

                Pace pace = Calculation.CalculateAveragePace(double.Parse(DistanceTextKM.Text) + double.Parse(DistanceTextM.Text) / 1000, runningTime);

                string fixSeconds="";
                if (pace.Seconds < 10) fixSeconds = "0";

                if (double.Parse(DistanceTextKM.Text) + double.Parse(DistanceTextM.Text) / 1000 == 0) MessageBox.Show("Incorrect Data!");
                else PaceText.Content = pace.Minutes + ":" + pace.Seconds + fixSeconds + " min/km";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data!");
            }
        }

        private void CalculateStepButton_Click(object sender, RoutedEventArgs e)
        {
            // 1000 / ((E3 * B3) + (E3 * C3 / 60))

            try
            {
                int cadence = int.Parse(CadenceTB.Text);
                double StepLength = 1000 / (double.Parse(PaceMinutesTB.Text) * cadence + (double.Parse(PaceSecondsTB.Text) * cadence / 60));

                string stepLengthString= String.Format("{0:n}m", StepLength);

                StepLengthText.Content = stepLengthString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Data!");
            }
        }
    }
}
