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
using WPFFleraVyer.Models;

namespace WPFFleraVyer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CounterModel CounterModel { get; set; } = new CounterModel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DecreaseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            CounterModel.Counter--;
            CounterText.Text = CounterModel.Counter.ToString();
        }

        private void ZeroBtn_OnClick(object sender, RoutedEventArgs e)
        {
            CounterModel.Counter = 0;
            CounterText.Text = CounterModel.Counter.ToString();
        }

        private void IncreaseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            CounterModel.Counter++;
            CounterText.Text = CounterModel.Counter.ToString();
        }
    }
}
