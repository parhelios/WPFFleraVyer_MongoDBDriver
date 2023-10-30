using System.Windows;
using WPFFleraVyer.Managers;
using WPFFleraVyer.Models;

namespace WPFFleraVyer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ZeroBtn_OnClick(object sender, RoutedEventArgs e)
        {
            CounterManager.CounterModel.Counter = 0;
            CounterText.Text = CounterManager.CounterModel.Counter.ToString();
        }

        private void IncreaseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            CounterManager.CounterModel.Counter++;
            CounterText.Text = CounterManager.CounterModel.Counter.ToString();
        }
    }
}
