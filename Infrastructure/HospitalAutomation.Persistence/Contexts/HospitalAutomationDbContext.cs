using HospitalAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Persistence.Contexts
{
    public class HospitalAutomationDbContext : DbContext
    {
        public HospitalAutomationDbContext(DbContextOptions options ) : base (options)
        {
            
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
