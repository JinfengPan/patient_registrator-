namespace PatientRegistrator.UI.Data
{
    using System.Collections.Generic;

    using PatientRegistrator.Model;

    public interface IPatientDataService
    {
        IEnumerable<Patient> GetAll();
    }
}