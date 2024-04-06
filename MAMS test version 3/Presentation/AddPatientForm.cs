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
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mAMS1DataSet1.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.mAMS1DataSet1.Appointment);
            // TODO: This line of code loads data into the 'mAMS1DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.mAMS1DataSet.Patient);

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Save the changes to the database
                this.patientTableAdapter.Update(this.mAMS1DataSet.Patient);

                // Inform the user
                MessageBox.Show("Patient information saved.");
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("Error saving patient information: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
