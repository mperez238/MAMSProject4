using MedicalAppointmentManagementSystem.BusinessLogic;
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
    public partial class ProviderScheduleForm : Form
    {
        private Provider _loggedInProvider;
        public ProviderScheduleForm()
        {
            InitializeComponent();
            _loggedInProvider = Login.CurrentProvider;
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
            cmbStatus.Items.Add("Confirmed");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPatientID.Text, out int patientId))
            {
                MessageBox.Show("Please enter a valid patient ID.");
                return;
            }

            if (!int.TryParse(txtProviderID.Text, out int providerId))
            {
                MessageBox.Show("Please enter a valid provider ID.");
                return;
            }

            

            DateTime appointmentDate = dtpAppDate.Value.Date;
            string appointmentTime = cmbAppTime.SelectedItem.ToString();
            string reason = txtReason.Text;
            string status = cmbStatus.SelectedItem.ToString();
            string notes = txtNotes.Text;

            
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

        private void ProviderScheduleForm_Load(object sender, EventArgs e)
        {
            lblProviderName.Text = $"{_loggedInProvider.FirstName} {_loggedInProvider.LastName}";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
