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
    public partial class PatientOptionsForm : Form
    {
        public PatientOptionsForm()
        {
            InitializeComponent();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            
            UpdateAccountForm updateAccountForm = new UpdateAccountForm();
            this.Hide();
            updateAccountForm.ShowDialog();
            this.Show();
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            AppointmentScheduleForm scheduleForm = new AppointmentScheduleForm();
            this.Hide();
            scheduleForm.ShowDialog();
            this.Show();
        }

        private void btnReportsCancel_Click(object sender, EventArgs e)
        {
            PatientAppointmentReportForm reportForm = new PatientAppointmentReportForm();
            this.Hide();
            reportForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This hides the form, and causes ShowDialog() to return in your Form1
            this.DialogResult = DialogResult.OK;
        }
    }
}
