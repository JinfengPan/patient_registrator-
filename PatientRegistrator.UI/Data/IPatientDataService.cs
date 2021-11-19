namespace PatientRegistrator.UI.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;

    public interface IPatientDataService
    {
        Task<List<Patient>> GetAllAsync();
    }
}