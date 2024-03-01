using HospitalAutomation.Application.Repositories.PatientRepo;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories.PatientRepo
{
    public class PatientReadRepository : ReadRepository<Patient>, IPatientReadRepository
    {
        public PatientReadRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
