using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PatientRegistrator.UI.View
{
    using PatientRegistrator.Model;
    using PatientRegistrator.UI.ViewModel;

    /// <summary>
    /// Interaction logic for NavigationView.xaml
    /// </summary>
    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
        }

        void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Patient;
            if (item != null)
            {
                var dataContext = this.DataContext as NavigationViewModel;
                dataContext.SelectedPatient = item;
            }
        }
    }
}
