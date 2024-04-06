using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentManagementSystem.BusinessLogic
{
    public class Patient
    {
        // Properties
        public int PatientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int ProviderID { get; set; }
        public bool IsLoggedIn { get; private set; }

        // Constructor
        public Patient(int patientID, string lastName, string firstName, string dateOfBirth, string email, string phone, string address, string city, string state, string zip, int providerID)
        {
            PatientID = patientID;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            ProviderID = providerID;

            IsLoggedIn = false; // Default to not logged in
            
        }

        // Methods related to account management
        public void LogIn()
        {
            
            IsLoggedIn = true;

            
        }

        public void LogOut()
        {
            IsLoggedIn= false;
        }

        public void CreateAcct()
        {
            // Logic to create a new patient account
        }

        public void UpdateAcct(string updatedFirstName, string updatedLastName, string updatedDateOfBirth)
        {

            if (string.IsNullOrWhiteSpace(updatedFirstName))
            {
                throw new ArgumentException("First name cannot be empty.", nameof(updatedFirstName));
            }

            if (string.IsNullOrWhiteSpace(updatedLastName))
            {
                throw new ArgumentException("Last name cannot be empty.", nameof(updatedLastName));
            }

            FirstName = updatedFirstName;
            LastName = updatedLastName;
            DateOfBirth = updatedDateOfBirth;
        }

        public void RemoveAcct()
        {
            // Logic to remove the patient's account
        }
    }
}

