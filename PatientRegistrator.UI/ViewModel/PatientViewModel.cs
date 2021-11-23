namespace PatientRegistrator.UI.ViewModel
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

        public Patient Patient { get; set; }

        public PatientViewModel(Patient patient, IPatientDataService patientDataService)
        {
            this.Patient = patient;
            this._patientDataService = patientDataService;
        }

        public void Save()
        {
            this._patientDataService.Save(this.Patient);
        }
    }
}