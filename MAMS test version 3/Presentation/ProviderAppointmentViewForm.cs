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
    public partial class ProviderAppointmentViewForm : Form
    {
        public ProviderAppointmentViewForm()
        {
            InitializeComponent();
        }

        private void ProviderAppointmentViewForm_Load(object sender, EventArgs e)
        {
            RefreshAppointmentData();
        }

        private void RefreshAppointmentData()
        {
            var appointmentsTableAdapter = new AppointmentTableAdapter();
            var allAppointments = new MAMS1DataSet.AppointmentDataTable();
            appointmentsTableAdapter.Fill(allAppointments); 
            dataGridViewAppointments.DataSource = allAppointments;
        }

        private void CancelAppointment(int appointmentId)
        {
            var appointmentsTableAdapter = new AppointmentTableAdapter();
            appointmentsTableAdapter.UpdateAppointmentStatus("Canceled", appointmentId);
        }

        private void ConfirmAppointment(int appointmentId)
        {
            var appointmentsTableAdapter = new AppointmentTableAdapter();
            appointmentsTableAdapter.UpdateAppointmentStatus("Confirmed", appointmentId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointments.SelectedRows[0];
                var appointmentId = Convert.ToInt32(selectedRow.Cells["AppointmentID"].Value); // selects appointmentid for changing
                CancelAppointment(appointmentId);
                RefreshAppointmentData();
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointments.SelectedRows[0];
                var appointmentId = Convert.ToInt32(selectedRow.Cells["AppointmentID"].Value); // selects appointmentid for changing
                ConfirmAppointment(appointmentId);
                RefreshAppointmentData();
            }
            else
            {
                MessageBox.Show("Please select an appointment to confirm.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
