namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;

    public class MainViewModel : ViewModelBase
    {
        private Patient _selectedPatient;

        public MainViewModel(INavigationViewModel navigationViewModel, IPatientDetailViewModel patientDetailViewModel)
        {
            this.NavigationViewModel = navigationViewModel;
            this.PatientDetailViewModel = patientDetailViewModel;
        }

        public INavigationViewModel NavigationViewModel { get; }
        public IPatientDetailViewModel PatientDetailViewModel { get; }

        public async Task LoadAsync()
        {
            await this.NavigationViewModel.LoadAsync();
        }
    }
}