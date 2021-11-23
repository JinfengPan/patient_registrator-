﻿namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;
    using PatientRegistrator.UI.Events;

    using Prism.Events;

    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private IPatientDataService _patientDataService;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(IPatientDataService patientDataService, IEventAggregator eventEventAggregator)
        {
            this._eventAggregator = eventEventAggregator;
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