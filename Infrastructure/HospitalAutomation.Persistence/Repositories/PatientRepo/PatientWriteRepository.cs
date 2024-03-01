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
    public class PatientWriteRepository : WriteRepository<Patient>, IPatientWriteRepository
    {
        public PatientWriteRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
