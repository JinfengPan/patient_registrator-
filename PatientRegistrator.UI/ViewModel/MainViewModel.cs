namespace PatientRegistrator.UI.ViewModel
{
    using System.Threading.Tasks;

    public class MainViewModel : ViewModelBase
    {
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