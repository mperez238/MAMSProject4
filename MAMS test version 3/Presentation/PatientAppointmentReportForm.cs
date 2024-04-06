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
    public partial class PatientAppointmentReportForm : Form
    {
        private Patient _loggedInPatient;
        public PatientAppointmentReportForm()
        {
            InitializeComponent();
            _loggedInPatient = Login.CurrentPatient;
        }

        private void PatientAppointmentReportForm_Load(object sender, EventArgs e)
        {
            
            var appointmentsTableAdapter = new AppointmentTableAdapter();

            
            var patientAppointments = new MAMS1DataSet.AppointmentDataTable();

            
            appointmentsTableAdapter.FillBy(patientAppointments, _loggedInPatient.PatientID);

            
            dataGridViewAppointments.DataSource = patientAppointments;
            

        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                
                var selectedRow = dataGridViewAppointments.SelectedRows[0];

                
                var appointmentId = Convert.ToInt32(selectedRow.Cells["AppointmentID"].Value);
                

               
                CancelAppointment(appointmentId);

                
                RefreshAppointmentData();
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.");
            }
        }
        private void CancelAppointment(int appointmentId)
        {
            
            var appointmentsTableAdapter = new AppointmentTableAdapter();

            
            appointmentsTableAdapter.UpdateAppointmentStatus("Canceled", appointmentId);
        }

        private void RefreshAppointmentData()
        {
            
            var patientAppointments = new MAMS1DataSet.AppointmentDataTable();
            var appointmentsTableAdapter = new AppointmentTableAdapter();
            appointmentsTableAdapter.FillBy(patientAppointments, _loggedInPatient.PatientID);
            dataGridViewAppointments.DataSource = patientAppointments;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
