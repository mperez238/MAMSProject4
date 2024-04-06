using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentManagementSystem.BusinessLogic
{
    public class Provider
    {
        public int ProviderID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        // Constructor
        public Provider(int providerId, string firstName, string lastName)
        {
            ProviderID = providerId;
            FirstName = firstName;
            LastName = lastName;
        }

        // Methods
        public void UpdatePatientDetails()
        {
            // Logic to update patient details
        }

        public void SendApptReminder()
        {
            // Logic to send an appointment reminder
        }
    }
}

