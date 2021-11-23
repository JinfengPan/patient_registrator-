namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;

    public class PatientDetailViewModel : ViewModelBase, IPatientDetailViewModel
    {
        private IPatientDataService _patientDataService;

        private Patient _patient;

        public PatientDetailViewModel(IPatientDataService patientDataService)
        {
            this._patientDataService = patientDataService;
            this.IncreaseFormIndexCommand = new DelegateCommand(this.IncreaseFormIndex);
            this.DecreaseFormIndexCommand = new DelegateCommand(this.DecreaseFormIndex);
            this.SavePatientCommand = new DelegateCommand(this.Save);
        }

        public ObservableCollection<GenderDropdown> GenderDropdowns { get; set; } = GenderDropdown.GenderDropdowns;

        public ObservableCollection<ShiFouDropdown> ShiFouDropdowns { get; set; } = ShiFouDropdown.ShiFouDropdowns;

        public DelegateCommand IncreaseFormIndexCommand { get; }
        public DelegateCommand DecreaseFormIndexCommand { get; }
        public DelegateCommand SavePatientCommand { get; }

        public Patient Patient
        {
            get => this._patient;

            private set
            {
                this._patient = value;
                this.OnPropertyChanged();
            }
        }

        public async Task LoadAsync(int patientId)
        {
            this.Patient = await this._patientDataService.GetByIdAsync(patientId);
        }

        public void Save()
        {
            this._patientDataService.Save(this.Patient);
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