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
                                                                    OtherLaboratoryExam1 = "检验1",
                                                                    OtherLaboratoryExam2 = "检验2",
                                                                    OtherLaboratoryExam3 = "检验3",
                                                                    Vision = "有影响，0.4",
                                                                    CT = "脑出血",
                                                                    MRI = "脑出血",
                                                                    OtherSpecialCheck1 = "检查1",
                                                                    OtherSpecialCheck2 = "检查2",
                                                                    OtherSpecialCheck3 = "检查3",
                                                                    HasUseDrug = true,
                                                                    DrugType = "非甾体",
                                                                    DrugName = "对乙酰氨基酚",
                                                                    HasSurgery = true,
                                                                    SurgeryMethod = "开颅",
                                                                    ComplicationHeadache = true,
                                                                    ComplicationInfection = false,
                                                                    ComplicationConvulsion = true,
                                                                    ComplicationSecondSurgery = false,
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