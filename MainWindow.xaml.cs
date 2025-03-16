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

namespace ASM3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Queen queen = new Queen();
        public MainWindow()
        {
            InitializeComponent();

            UpdateStatusDisplay();
            nectarCollector.Text = "Nectar Collector";
        }

        private void nectarCollectorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void WorkNextShift_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void AssignJob_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateStatusDisplay()
        {
            queenReport.Text = queen.StatusReport; // Display the status report in a TextBlock
        }
    }
}
