namespace PatientRegistrator.UI.ViewModel
{
    using System.Threading.Tasks;

    public interface IPatientDetailViewModel
    {
        Task Init(int? patientId);
    }
}