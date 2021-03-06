namespace PatientRegistrator.UI.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;

    public interface IPatientDataService
    {
        Task<List<Patient>> GetAllAsync();

        Task<Patient> GetByIdAsync(int patientId);

        Task SaveAsync();

        void Add(Patient patient);

        void Remove(Patient patient);

        Task Export(string fileName);
    }
}