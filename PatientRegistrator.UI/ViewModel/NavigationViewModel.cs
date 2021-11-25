namespace PatientRegistrator.UI.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;
    using PatientRegistrator.UI.Events;

    using Prism.Commands;
    using Prism.Events;

    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private IPatientDataService _patientDataService;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(IPatientDataService patientDataService, IEventAggregator eventEventAggregator)
        {
            this._eventAggregator = eventEventAggregator;
            this._eventAggregator.GetEvent<AfterPatientSavedEvent>().Subscribe(AfterPatientSaved);
            this._patientDataService = patientDataService;

            this.Patients = new ObservableCollection<Patient>();
            this.RemoveItem = new DelegateCommand<Patient>(DeleteItem);
        }

        private async void DeleteItem(Patient patient)
        {
            this._patientDataService.Remove(patient);
            await this._patientDataService.SaveAsync();
            this.Patients.Remove(patient);
        }

        private void AfterPatientSaved(Patient obj)
        {
            for (int i = 0; i < this.Patients.Count; i++)
            {
                if (this.Patients[i].Id == obj.Id)
                {
                    this.Patients[i] = obj;
                    return;
                }
            }

            this.Patients.Add(obj);
        }

        public ObservableCollection<Patient> Patients { get; }

        public ICommand RemoveItem { get; }

        public async Task LoadAsync()
        {
            var all = await this._patientDataService.GetAllAsync();

            this.Patients.Clear();

            foreach (var patient in all)
            {
                this.Patients.Add(patient);
            }
        }

        private Patient _selectedPatient;

        public Patient SelectedPatient
        {
            get => this._selectedPatient;

            set
            {
                this._selectedPatient = value;
                this.OnPropertyChanged();
                if (this._selectedPatient != null)
                {
                    this._eventAggregator.GetEvent<OpenPatientDetailViewEvent>()
                        .Publish(this._selectedPatient.Id);
                }
            }
        }
    }
}