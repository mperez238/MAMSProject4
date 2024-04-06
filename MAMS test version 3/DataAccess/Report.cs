using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentManagementSystem.DataAccess
{
    public class Report
    {
        // Properties
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string ProviderName { get; set; }
        public DateTime DateTime { get; set; }
        public string ApptNotes { get; set; }
        public bool FollowUp { get; set; }

        // Constructor
        public Report(int patientID, string patientName, string providerName, DateTime dateTime, string apptNotes, bool followUp)
        {
            PatientID = patientID;
            PatientName = patientName;
            ProviderName = providerName;
            DateTime = dateTime;
            ApptNotes = apptNotes;
            FollowUp = followUp;
        }

        // Methods
        public void CompileReport()
        {
            // Logic to compile a report based on the appointment details and notes
        }

        public void SelectTimeRange(DateTime startTime, DateTime endTime)
        {
            // Logic to select reports within a certain date/time range
        }
    }
}
