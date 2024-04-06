using MedicalAppointmentManagementSystem.BusinessLogic;
using MedicalAppointmentManagementSystem.MAMS1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentManagementSystem.Presentation
{
    public partial class AppointmentScheduleForm : Form
    {
        private Patient _loggedInPatient;
        public AppointmentScheduleForm()
        {
            InitializeComponent();
            _loggedInPatient = Login.CurrentPatient;
        }

        private void AppointmentScheduleForm_Load(object sender, EventArgs e)
        {
            lblPatientName.Text = $"{_loggedInPatient.FirstName} {_loggedInPatient.LastName}";
            lblPatientID.Text = $"{_loggedInPatient.PatientID}";
            lblProviderID.Text = $"{_loggedInPatient.ProviderID}";
            PopulateAppointmentTimes();
            PopulateAppointmentStatuses();
        }

        private void PopulateAppointmentTimes()
        {
            
            cmbAppTime.Items.Add("09:00 AM");
            cmbAppTime.Items.Add("10:00 AM");
            cmbAppTime.Items.Add("11:00 AM");
            cmbAppTime.Items.Add("12:00 PM");
            cmbAppTime.Items.Add("01:00 PM");
            cmbAppTime.Items.Add("02:00 PM");
            cmbAppTime.Items.Add("03:00 PM");
            cmbAppTime.Items.Add("04:00 PM");
            cmbAppTime.Items.Add("05:00 PM");
        }

        private void PopulateAppointmentStatuses()
        {
            
            cmbStatus.Items.Add("Scheduled");
            
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            int providerId = _loggedInPatient.ProviderID;
            int patientId = _loggedInPatient.PatientID;

            
            DateTime appointmentDate = dtpAppDate.Value.Date;

            
            string appointmentTime = cmbAppTime.SelectedItem.ToString();

            string reason = txtReason.Text;
            string status = cmbStatus.SelectedItem.ToString();
            string notes = txtNotes.Text;

            // Insert the new appointment using the table adapter
            try
            {
                Appointment appointment = new Appointment(
                    patientId,
                    providerId,
                    appointmentDate,
                    appointmentTime,
                    reason,
                    status,
                    notes
                );
                appointment.Schedule();
                MessageBox.Show("Appointment scheduled successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to schedule appointment. Error: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
