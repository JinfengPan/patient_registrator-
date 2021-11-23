namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;



    public class NavigationViewModel : INavigationViewModel
    {
        private IPatientDataService _patientDataService;

        public NavigationViewModel(IPatientDataService patientDataService)
        {
            this._patientDataService = patientDataService;

            this.Patients = new ObservableCollection<Patient>();
        }

        public ObservableCollection<Patient> Patients { get; }

        public async Task LoadAsync()
        {
            var all = await this._patientDataService.GetAllAsync();

            this.Patients.Clear();

            foreach (var patient in all)
            {
                this.Patients.Add(patient);
            }
        }
    }
}