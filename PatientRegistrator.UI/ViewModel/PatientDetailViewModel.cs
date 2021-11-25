namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;
    using PatientRegistrator.UI.Events;

    using Prism.Commands;
    using Prism.Events;

    public class PatientDetailViewModel : ViewModelBase, IPatientDetailViewModel
    {
        private IPatientDataService _patientDataService;
        private IEventAggregator _eventAggregator;
        private Patient _patient;

        public PatientDetailViewModel(IPatientDataService patientDataService,
                                      IEventAggregator eventEventAggregator)
        {
            this._patientDataService = patientDataService;
            this.IncreaseFormIndexCommand = new DelegateCommand(this.IncreaseFormIndex);
            this.DecreaseFormIndexCommand = new DelegateCommand(this.DecreaseFormIndex);
            this.SavePatientCommand = new DelegateCommand(this.Save);
            this._eventAggregator = eventEventAggregator;
        }

        public async Task Init(int? patientId)
        {
            this.SetFormIndex(0);
            await this.LoadAsync(patientId);
        }

        public ObservableCollection<GenderDropdown> GenderDropdowns { get; set; } = GenderDropdown.GenderDropdowns;

        public ObservableCollection<ShiFouDropdown> ShiFouDropdowns { get; set; } = ShiFouDropdown.ShiFouDropdowns;

        public ICommand IncreaseFormIndexCommand { get; }
        public ICommand DecreaseFormIndexCommand { get; }
        public ICommand SavePatientCommand { get; }

        public Patient Patient
        {
            get => this._patient;

            private set
            {
                this._patient = value;
                this.OnPropertyChanged();
            }
        }

        public async Task LoadAsync(int? patientId)
        {
            this.Patient = patientId.HasValue
                               ? await this._patientDataService.GetByIdAsync(patientId.Value)
                               : CreateNewPatient();
        }

        private Patient CreateNewPatient()
        {
            var patient = new Patient();
            this._patientDataService.Add(patient);
            return patient;
        }

        public async void Save()
        {
            await this._patientDataService.SaveAsync();

            this._eventAggregator.GetEvent<AfterPatientSavedEvent>().Publish(this.Patient);
        }

        #region Form Index
        private int _formIndex;

        public void IncreaseFormIndex()
        {
            this.SetFormIndex(this._formIndex + 1);
        }

        public void DecreaseFormIndex()
        {
            this.SetFormIndex(this._formIndex - 1);
        }

        public void SetFormIndex(int num)
        {
            this._formIndex = num;
            OnPropertyChanged(nameof(IsForm0Visible));
            OnPropertyChanged(nameof(IsForm1Visible));
            OnPropertyChanged(nameof(IsForm2Visible));
            OnPropertyChanged(nameof(IsForm3Visible));
            OnPropertyChanged(nameof(IsForm4Visible));
            OnPropertyChanged(nameof(IsForm5Visible));
        }

        public bool IsForm0Visible => this._formIndex == 0;
        public bool IsForm1Visible => this._formIndex == 1;
        public bool IsForm2Visible => this._formIndex == 2;
        public bool IsForm3Visible => this._formIndex == 3;
        public bool IsForm4Visible => this._formIndex == 4;
        public bool IsForm5Visible => this._formIndex == 5;

        #endregion
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