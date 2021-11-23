namespace PatientRegistrator.UI.ViewModel
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
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
        }

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
    }
}