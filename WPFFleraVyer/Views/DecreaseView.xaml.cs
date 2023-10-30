using System.Diagnostics.PerformanceData;
using System.Windows;
using System.Windows.Controls;
using WPFFleraVyer.Managers;
using WPFFleraVyer.Models;

namespace WPFFleraVyer.Views
{
    /// <summary>
    /// Interaction logic for DecreaseView.xaml
    /// </summary>
    public partial class DecreaseView : UserControl
    {
        public DecreaseView()
        {
            InitializeComponent();
        }

        private void DecreaseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            CounterManager.CounterModel.Counter--;
        }

    }
}
