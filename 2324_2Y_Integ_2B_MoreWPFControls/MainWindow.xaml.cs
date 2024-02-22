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

namespace _2324_2Y_Integ_2B_MoreWPFControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] margin = { 0, 0 };
        double[] windowSize = {0,0 };

        public MainWindow()
        {
            InitializeComponent();
            lbSliderDisplay.Content = theSlider.Value.ToString();
            margin[0] = bob.Margin.Top;
            margin[1] = bob.Margin.Left;
            bob.FontSize = 32;
            windowSize[0] = myWindow.Width;
            windowSize[1] = myWindow.Height;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bob.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            bob.Visibility = Visibility.Hidden;
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dpCalendar.DisplayDate.ToString());
        }

        private void theSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbSliderDisplay.Content = theSlider.Value.ToString();
            //bob.Margin = new Thickness(margin[0] + theSlider.Value
            //    , margin[1] + theSlider.Value,0,0);
            bob.FontSize = 32 + (theSlider.Value * 5);
            bob.Opacity = theSlider.Value / 10;
            myWindow.Opacity = theSlider.Value / 10;
            if (theSlider.Value > 0)
            {
                myWindow.Width = windowSize[0] * (1 + (theSlider.Value / 10));
                myWindow.Height = windowSize[1] * (1 + (theSlider.Value / 10));
            }

        }

        private void bob_Click(object sender, RoutedEventArgs e)
        {
            myWindow.Background = Brushes.PowderBlue;
        }
    }
}
