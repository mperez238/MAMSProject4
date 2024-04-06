using MedicalAppointmentManagementSystem.BusinessLogic;
using MedicalAppointmentManagementSystem.MAMS1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalAppointmentManagementSystem.Presentation
{
    public partial class UpdateAccountForm : Form
    {
        public UpdateAccountForm()
        {
            InitializeComponent();
        }

        private void UpdateAccountForm_Load(object sender, EventArgs e)
        {
            lblFirstNameValue.Text = Login.CurrentPatient.FirstName;
            lblLastNameValue.Text = Login.CurrentPatient.LastName;
            lblDOBValue.Text = Login.CurrentPatient.DateOfBirth; 
            lblPatientIDValue.Text = Login.CurrentPatient.PatientID.ToString();

            // Display the editable patient information in TextBoxes
            txtEmail.Text = Login.CurrentPatient.Email;
            txtPhone.Text = Login.CurrentPatient.Phone;
            txtAddress.Text = Login.CurrentPatient.Address;
            txtCity.Text = Login.CurrentPatient.City;
            txtState.Text = Login.CurrentPatient.State;
            txtZip.Text = Login.CurrentPatient.Zip;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the CurrentPatient object with the new values from the text boxes
            Login.CurrentPatient.Email = txtEmail.Text;
            Login.CurrentPatient.Phone = txtPhone.Text;
            Login.CurrentPatient.Address = txtAddress.Text;
            Login.CurrentPatient.City = txtCity.Text;
            Login.CurrentPatient.State = txtState.Text;
            Login.CurrentPatient.Zip = txtZip.Text;

            // Update the database with the new values
            UpdatePatientInDatabase(Login.CurrentPatient);

            // Inform the user that the changes have been saved
            MessageBox.Show("Your changes have been saved.");
        }
        private void UpdatePatientInDatabase(Patient patient)
        {
            try
            {
                var patientTableAdapter = new PatientTableAdapter();

                // Update the patient's information directly in the database using a SQL UPDATE statement
                string updateQuery = @"
                    UPDATE Patient SET
                        PatientLastName = @LastName,
                        PatientFirstName = @FirstName,
                        DOB = @DateOfBirth,
                        Email = @Email,
                        Phone = @Phone,
                        Address = @Address,
                        City = @City,
                        State = @State,
                        Zip = @Zip
                    WHERE PatientID = @PatientID";

                using (var connection = patientTableAdapter.Connection)
                {
                    using (var command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@LastName", patient.LastName);
                        command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                        command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                        command.Parameters.AddWithValue("@Email", patient.Email);
                        command.Parameters.AddWithValue("@Phone", patient.Phone);
                        command.Parameters.AddWithValue("@Address", patient.Address);
                        command.Parameters.AddWithValue("@City", patient.City);
                        command.Parameters.AddWithValue("@State", patient.State);
                        command.Parameters.AddWithValue("@Zip", patient.Zip);
                        command.Parameters.AddWithValue("@PatientID", patient.PatientID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the patient: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
