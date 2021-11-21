﻿namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;

    public class PatientViewModel : ViewModelBase
    {
        private IPatientDataService _patientDataService;

        private Patient _selectedPatient;

        public PatientViewModel(IPatientDataService patientDataService)
        {
            Patients = new ObservableCollection<Patient>();
            this._patientDataService = patientDataService;
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
}