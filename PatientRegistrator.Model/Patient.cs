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
        public string MainSymptom { get; set; }
        public string OnsetTime { get; set; }
        public string CourseOfDisease { get; set; }

        public bool HasHeadache { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 抽搐.
        /// </summary>
        public bool HasConvulsion { get; set; }

        public bool HasConsciousnessDisorder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 偏瘫.
        /// </summary>
        public bool HasHemiplegia { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 失禁.
        /// </summary>
        public bool HasIncontinence { get; set; }
        public bool HasVisionIssue { get; set; }
        public bool HasDiabetes { get; set; }
        public bool HasHypertension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 痛风.
        /// </summary>
        public bool HasGout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 癫痫.
        /// </summary>
        public bool HasEpilepsy { get; set; } 

        public string OtherAssociatedDisease { get; set; }

        public string HeadacheDesc { get; set; }
        public string ConvulsionDesc { get; set; }
        public string ConsciousnessDisorderDesc { get; set; }

        /// <summary>
        /// Gets or sets the 偏瘫.
        /// </summary>
        public string HemiplegiaDesc { get; set; }
        public string IncontinenceDesc { get; set; }

        /// <summary>
        /// Gets or sets the 白细胞.
        /// </summary>
        public int Leukocyte { get; set; }

        public int DDimer { get; set; }

        /// <summary>
        /// Gets or sets the 白蛋白.
        /// </summary>
        public int Albumin { get; set; }

        /// <summary>
        /// Gets or sets the 降钙素原.
        /// </summary>
        public double Procalcitonin { get; set; }

        /// <summary>
        /// Gets or sets the 血沉.
        /// </summary>
        public int ESR { get; set; }

        public int CRP { get; set; }

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
