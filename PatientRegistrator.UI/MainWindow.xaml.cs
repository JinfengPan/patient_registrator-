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

namespace PatientRegistrator.UI
{
    using PatientRegistrator.DataAccess;
    using PatientRegistrator.UI.ViewModel;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        private Func<CoreContext> _contextCreator;

        public MainWindow(MainViewModel viewModel, Func<CoreContext> contextCreator)
        {
            this._contextCreator = contextCreator;

            InitializeComponent();
            this._viewModel = viewModel;
            DataContext = this._viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using(var ctx = this._contextCreator())
            {
                ctx.Database.EnsureCreated();
            }
            await this._viewModel.LoadAsync();
        }
    }
}
