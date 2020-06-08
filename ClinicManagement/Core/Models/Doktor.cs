using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClinicManagement.Core.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsAvailable { get; set; }
        public string Address { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public string PhysicianId { get; set; }
        public ApplicationUser Physician { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public Doktor()
        {
            Appointments = new Collection<Appointment>();
        }

    }
}