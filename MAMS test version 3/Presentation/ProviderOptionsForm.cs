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
    public partial class ProviderOptionsForm : Form
    {
        public ProviderOptionsForm()
        {
            InitializeComponent();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            ProviderAppointmentViewForm providerAppointmentViewForm = new ProviderAppointmentViewForm();
            providerAppointmentViewForm.ShowDialog();
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            ProviderScheduleForm providerScheduleForm = new ProviderScheduleForm();
            providerScheduleForm.ShowDialog();
            
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
        }

        private void ProviderOptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
