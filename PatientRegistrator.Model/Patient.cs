using System;

namespace PatientRegistrator.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Hometown { get; set; }
        public string OnsetTime { get; set; }
        public string CourseOfDisease { get; set; }

        public bool HasHeadache { get; set; }
        public bool HasConvulsion { get; set; }
        public bool HasConsciousnessDisorder { get; set; }
        public bool HasHemiplegia { get; set; }
        public bool HasIncontinence { get; set; }

        public string HeadacheDesc { get; set; }
        public string ConvulsionDesc { get; set; }
        public string ConsciousnessDisorderDesc { get; set; }
        public string HemiplegiaDesc { get; set; }
        public string IncontinenceDesc { get; set; }

        public bool HasUseDrug { get; set; }
        public string DrugType { get; set; }
        public string SpecificDrug { get; set; }

        public bool HasSurgery { get; set; }
        public string SurgeryMethod { get; set; }

        public bool complicationHeadache { get; set; }
        public bool complicationInfection { get; set; }
        public bool complicationConvulsion { get; set; }
        public bool complicationSecondSurgery { get; set; }

        public string FollowUpTime { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Femail = 2
    }
}
