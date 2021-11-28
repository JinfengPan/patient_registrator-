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

        public Task<Patient> GetByIdAsync(int patientId)
        {
            var patient = new Patient
            {
                Id = 1,
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
                Procalcitonin = "0.17",
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
                ComplicationHemorrhage = true,
                ComplicationConvulsion = true,
                ComplicationSecondSurgery = false,
                ComplicationOther1 = "其他并发症1",
                ComplicationOther2 = "其他并发症2",
                Leukocyte2 = 11,
                DDimer2 = 11000,
                Albumin2 = 36,
                Procalcitonin2 = "0.17",
                ESR2 = 56,
                CRP2 = 13,
                OtherLaboratoryExam21 = "检验21",
                OtherLaboratoryExam22 = "检验22",
                OtherLaboratoryExam23 = "检验23",
                Vision2 = "有影响，0.4",
                CT2 = "脑出血",
                MRI2 = "脑出血",
                OtherSpecialCheck21 = "检查21",
                OtherSpecialCheck22 = "检查22",
                OtherSpecialCheck23 = "检查23",
                FollowUpHasHeadache = true,
                FollowUpHasConvulsion = false,
                FollowUpHasHemiplegia = true,
                FollowUpOther1 = "随访其他1",
                FollowUpOther2 = "随访其他2",
                FollowUpOther3 = "随访其他3",
                FollowUpOther4 = "随访其他4",
                SelfCareDegree = "不能",
                FollowUpTime = "7月",
            };
            return Task.FromResult(patient);
        }

        public Task SaveAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Add(Patient patient)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Patient patient)
        {
            throw new System.NotImplementedException();
        }

        public Task Export()
        {
            throw new System.NotImplementedException();
        }

        private List<Patient> _allPatients = new List<Patient>
                                                        {
                                                            new Patient
                                                                {
                                                                    Id = 1,
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
                                                                    Procalcitonin = "0.17",
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
                                                                    ComplicationHemorrhage = true,
                                                                    ComplicationConvulsion = true,
                                                                    ComplicationSecondSurgery = false,
                                                                    ComplicationOther1 = "其他并发症1",
                                                                    ComplicationOther2 = "其他并发症2",
                                                                    Leukocyte2 = 11,
                                                                    DDimer2 = 11000,
                                                                    Albumin2 = 36,
                                                                    Procalcitonin2 = "0.17",
                                                                    ESR2 = 56,
                                                                    CRP2 = 13,
                                                                    OtherLaboratoryExam21 = "检验21",
                                                                    OtherLaboratoryExam22 = "检验22",
                                                                    OtherLaboratoryExam23 = "检验23",
                                                                    Vision2 = "有影响，0.4",
                                                                    CT2 = "脑出血",
                                                                    MRI2 = "脑出血",
                                                                    OtherSpecialCheck21 = "检查21",
                                                                    OtherSpecialCheck22 = "检查22",
                                                                    OtherSpecialCheck23 = "检查23",
                                                                    FollowUpHasHeadache = true,
                                                                    FollowUpHasConvulsion = false,
                                                                    FollowUpHasHemiplegia = true,
                                                                    FollowUpOther1 = "随访其他1",
                                                                    FollowUpOther2 = "随访其他2",
                                                                    FollowUpOther3 = "随访其他3",
                                                                    FollowUpOther4 = "随访其他4",
                                                                    SelfCareDegree = "不能",
                                                                    FollowUpTime = "7月",
                                                                },
                                                            new Patient
                                                                {
                                                                    Id = 2,
                                                                    Name = "王某",
                                                                    Age = 19,
                                                                    Gender = Gender.Femail
                                                                }
                                                        };


    }
}