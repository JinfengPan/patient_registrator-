namespace PatientRegistrator.UI.ViewModel
{
    using System.Threading.Tasks;

    public interface IPatientDetailViewModel
    {
        Task LoadAsync(int patientId);

        Task Init(int patientId);
    }
}