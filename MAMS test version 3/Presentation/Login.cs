using MedicalAppointmentManagementSystem.BusinessLogic;
using MedicalAppointmentManagementSystem.MAMS1DataSetTableAdapters;
using MedicalAppointmentManagementSystem.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentManagementSystem
{
    public partial class Login : Form
    {
        private MAMS1DataSet MAMS1DataSet = new MAMS1DataSet();
        private PatientTableAdapter patientTableAdapter = new PatientTableAdapter();
        public static Patient CurrentPatient { get; private set; }
        public static Provider CurrentProvider { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private Patient GetPatientById(int patientId)
        {
            var patientTableAdapter = new PatientTableAdapter();
            var patientDataTable = patientTableAdapter.GetData();
            var patientRow = patientDataTable.FindByPatientID(patientId);

            if (patientRow != null)
            {
                // Create a new Patient instance from the patientRow data
                Patient patient = new Patient(
                    patientRow.PatientID, 
                    patientRow.PatientLastName,
                    patientRow.PatientFirstName,
                    patientRow.DOB,
                    patientRow.Email,
                    patientRow.Phone,
                    patientRow.Address,
                    patientRow.City,
                    patientRow.State,
                    patientRow.Zip,
                    patientRow.ProviderID 
                );

                return patient;
            }

            // If the patientRow is null, return null
            return null;
        }

        private Provider GetProviderById(int providerId)
        {
            var providerTableAdapter = new ProviderTableAdapter();
            var providerDataTable = providerTableAdapter.GetData();
            var providerRow = providerDataTable.FindByProviderID(providerId);

            if (providerRow != null)
            {
                // Assuming your provider data table has FirstName and LastName columns
                return new Provider(
                    providerRow.ProviderID,
                    providerRow.FirstName,
                    providerRow.LastName
                );
            }

            return null; // Return null if no provider is found with the given ID
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLoginId.Text, out int loginId))
            {
                Patient patient = GetPatientById(loginId); 
                if (patient != null)
                {
                    // Patient login successful
                    patient.LogIn();
                    CurrentPatient = patient; // Store the logged-in patient

                    PatientOptionsForm patientOptionsForm = new PatientOptionsForm();
                    this.Hide();
                    patientOptionsForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid patient ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        private void btnProviderLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLoginId.Text, out int loginId))
            {
                Provider provider = GetProviderById(loginId);
                if (provider != null)
                {
                    // Provider login successful
                    CurrentProvider = provider; // Store the logged-in provider

                    ProviderOptionsForm providerOptionsForm = new ProviderOptionsForm();
                    this.Hide();
                    providerOptionsForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid provider ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
