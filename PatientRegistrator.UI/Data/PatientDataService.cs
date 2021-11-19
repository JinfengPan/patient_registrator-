namespace PatientRegistrator.UI.Data
{
    using System.Collections;
    using System.Collections.Generic;

    using PatientRegistrator.Model;


    public class PatientDataService : IPatientDataService
    {
        public IEnumerable<Patient> GetAll()
        {
            return this._allPatients;
        }

        private IEnumerable<Patient> _allPatients = new List<Patient>
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