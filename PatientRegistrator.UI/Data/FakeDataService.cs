namespace PatientRegistrator.UI.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PatientRegistrator.Model;


    public class FakeDataService : IPatientDataService
    {
        public Task<List<Patient>> GetAllAsync()
        {
            return Task.FromResult(this._allPatients);
        }

        private List<Patient> _allPatients = new List<Patient>
                                                        {
                                                            new Patient
                                                                {
                                                                    Name = "张某某",
                                                                    Age = 37,
                                                                    Gender = Gender.Male
                                                                },
                                                            new Patient
                                                                {
                                                                    Name = "王某",
                                                                    Age = 19,
                                                                    Gender = Gender.Femail
                                                                }
                                                        };


    }
}