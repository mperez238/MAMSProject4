using MedicalAppointmentManagementSystem.MAMS1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentManagementSystem.BusinessLogic
{
    public class Appointment
    {
        // Properties
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int ProviderID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        // Constructor
        public Appointment(int patientID, int providerID, DateTime appointmentDate, string appointmentTime, string reason, string status, string notes)
        {
            PatientID = patientID;
            ProviderID = providerID;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
            Reason = reason;
            Status = status;
            Notes = notes;
        }

        // Methods
        public void Schedule()
        {

            try
            {
                var appointmentsTableAdapter = new AppointmentTableAdapter();
                appointmentsTableAdapter.Insert(
                    ProviderID,
                    AppointmentDate,
                    AppointmentTime,
                    Reason,
                    Status,
                    Notes,
                    PatientID
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to schedule appointment. Error: " + ex.Message);
            }


        }

        public void Cancel()
        {
            // Logic to cancel the appointment
        }

        public void Reschedule()
        {
            // Logic to reschedule the appointment
            
        }
    }
}
