using HospitalAutomation.Application.Repositories;
using HospitalAutomation.Application.Repositories.DoctorRepo;
using HospitalAutomation.Domain.Entities;
using HospitalAutomation.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Repositories.DoctorRepo
{
    public class DoctorReadRepository : ReadRepository<Doctor>, IDoctorReadRepository
    {
        public DoctorReadRepository(HospitalAutomationDbContext context) : base(context)
        {
        }
    }
}
