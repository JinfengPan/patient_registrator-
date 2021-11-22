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
        private IPatientDataService _patientDataService;

        private Patient _selectedPatient;

        public MainViewModel(IPatientDataService patientDataService)
        {
            Patients = new ObservableCollection<Patient>();
            this._patientDataService = patientDataService;
        }

        public ObservableCollection<Patient> Patients { get; set; }

        public ObservableCollection<GenderDropdown> GenderDropdowns { get; set; } = GenderDropdown.GenderDropdowns;

        public ObservableCollection<ShiFouDropdown> ShiFouDropdowns { get; set; } = ShiFouDropdown.ShiFouDropdowns;

        public async Task LoadAsync()
        {

            var patients = await this._patientDataService.GetAllAsync();

            Patients.Clear();

            foreach (var patient in patients)
            {
                Patients.Add(patient);
            }
        }

        public Patient SelectedPatient
        {
            get
            {
                return this._selectedPatient;
            }

            set
            {
                this._selectedPatient = value;
                this.OnPropertyChanged();
            }
        }

    }

    public class GenderDropdown
    {
        public Gender Gender { get; set; }
        public string GenderDisplay { get; set; }

        public static ObservableCollection<GenderDropdown> GenderDropdowns = 
            new ObservableCollection<GenderDropdown>
             {
                new GenderDropdown
                    {
                        Gender = Gender.Male,
                        GenderDisplay = "男"
                    },
                new GenderDropdown
                    {
                        Gender = Gender.Femail,
                        GenderDisplay = "女"
                    },
             };
    }

    public class ShiFouDropdown
    {
        public bool Value { get; set; }
        public string Display { get; set; }

        public static ObservableCollection<ShiFouDropdown> ShiFouDropdowns =
            new ObservableCollection<ShiFouDropdown>
                {
                    new ShiFouDropdown
                        {
                           Value = true,
                           Display = "是"
                        },
                    new ShiFouDropdown
                        {
                            Value = false,
                            Display = "否"
                        },
                };
    }
}