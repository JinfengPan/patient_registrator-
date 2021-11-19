namespace PatientRegistrator.UI.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.EntityFrameworkCore;

    using PatientRegistrator.DataAccess;
    using PatientRegistrator.Model;


    public class PatientDataService : IPatientDataService
    {
        private Func<CoreContext> _contextCreator;

        public PatientDataService(Func<CoreContext> contextCreator)
        {
            this._contextCreator = contextCreator;
        }

        public IEnumerable<Patient> GetAll()
        {
            using (var ctx = _contextCreator())
            {
                return ctx.Patients.AsNoTracking().ToList();
            }
        }
    }
}