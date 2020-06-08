using System.Collections.Generic;
using ClinicManagement.Core.Models;

namespace ClinicManagement.Core.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doktor> GetDectors();
        IEnumerable<Doktor> GetAvailableDoctors();
        Doktor GetDoctor(int id);
        Doktor GetProfile(string userId);
        void Add(Doktor doctor);
    }
}