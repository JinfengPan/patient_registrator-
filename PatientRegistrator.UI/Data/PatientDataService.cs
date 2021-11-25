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
        private CoreContext _coreContext;

        public PatientDataService(CoreContext context)
        {
            this._coreContext = context;
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await this._coreContext.Patients.AsNoTracking().ToListAsync();
        }

        public async Task<Patient> GetByIdAsync(int patientId)
        {
            return await this._coreContext.Patients.SingleAsync(p => p.Id == patientId);
        }

        public async Task SaveAsync()
        {
            await this._coreContext.SaveChangesAsync();
        }

        public void Add(Patient patient)
        {
            this._coreContext.Add(patient);
        }

        public void Remove(Patient patient)
        {
            this._coreContext.Remove(patient);
        }
    }
}