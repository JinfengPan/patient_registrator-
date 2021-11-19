namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;

    public class MainViewModel
    {
        private IPatientDataService _patientDataService;

        public MainViewModel(IPatientDataService patientDataService)
        {
            this._patientDataService = patientDataService;
            Patients = new ObservableCollection<Patient>();
        }

        public ObservableCollection<Patient> Patients { get; set; }

        public async Task LoadAsync()
        {
            var patients = await this._patientDataService.GetAllAsync();

            Patients.Clear();

            foreach (var patient in patients)
            {
                Patients.Add(patient);
            }
        }
    }
}