namespace PatientRegistrator.UI.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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

        public async Task<List<Patient>> GetAllAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Patients.AsNoTracking().ToListAsync();
            }
        }

        public async Task<Patient> GetByIdAsync(int patientId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Patients.AsNoTracking().SingleAsync(p => p.Id == patientId);
            }
        }

        public async Task SaveAsync(Patient patient)
        {
            using (var ctx = this._contextCreator())
            {
                ctx.Patients.Attach(patient);
                ctx.Entry(patient).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }

        }
    }
}