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
                                                                    Gender = Gender.Male,
                                                                    Hometown = "南通",
                                                                    MainSymptom = "头痛",
                                                                    CourseOfDisease = "3月",
                                                                    HasHeadache = true,
                                                                    HasConvulsion = true,
                                                                    HasConsciousnessDisorder = false,
                                                                    HasHemiplegia = false,
                                                                    HasIncontinence = true,
                                                                    HasVisionIssue = true,
                                                                    HasDiabetes = false,
                                                                    HasHypertension = true,
                                                                    HasGout = false,
                                                                    HasEpilepsy = true,
                                                                    OtherAssociatedDisease = "脂肪肝",
                                                                    HeadacheDesc = "每天一次",
                                                                    ConvulsionDesc = "一天三次",
                                                                    ConsciousnessDisorderDesc = "昏睡",
                                                                    HemiplegiaDesc = "左侧III级",
                                                                    IncontinenceDesc = "不能控制",
                                                                    Leukocyte = 11,
                                                                    DDimer = 11000,
                                                                    Albumin = 36,
                                                                    Procalcitonin = 0.17,
                                                                    ESR = 56,
                                                                    CRP = 13,

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