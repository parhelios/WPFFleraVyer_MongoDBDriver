using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPFFleraVyer.Models;

namespace WPFFleraVyer.Views
{
    /// <summary>
    /// Interaction logic for PeopleView.xaml
    /// </summary>
    public partial class PeopleView : UserControl
    {
        public ObservableCollection<PersonModel> PeopleList { get; set; } = new ();

        public PersonModel? SelectedPerson { get; set; } = new ();

        public string EditFirstName { get; set; } = string.Empty;

        public string EditLastName { get; set; } = string.Empty;

        public PeopleView()
        {
            InitializeComponent();

            DataContext = this;

            PeopleList.Add(new PersonModel() { FirstName = "Niklas", LastName = "Hjelm" });
            PeopleList.Add(new PersonModel() { FirstName = "Vidar", LastName = "Hjelm" });
        }

        private void UpdateBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (SelectedPerson is null)
            {
                return;
            }

            SelectedPerson.FirstName = EditFirstName;
            SelectedPerson.LastName = EditLastName;
        }
    }
}
