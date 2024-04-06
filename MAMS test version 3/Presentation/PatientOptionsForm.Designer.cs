namespace MedicalAppointmentManagementSystem.Presentation
{
    partial class PatientOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnScheduleAppointment = new System.Windows.Forms.Button();
            this.btnReportsCancel = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(126, 61);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(158, 40);
            this.btnUpdateAccount.TabIndex = 0;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.Location = new System.Drawing.Point(126, 124);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(158, 40);
            this.btnScheduleAppointment.TabIndex = 1;
            this.btnScheduleAppointment.Text = "Schedule Appointment";
            this.btnScheduleAppointment.UseVisualStyleBackColor = true;
            this.btnScheduleAppointment.Click += new System.EventHandler(this.btnScheduleAppointment_Click);
            // 
            // btnReportsCancel
            // 
            this.btnReportsCancel.Location = new System.Drawing.Point(126, 194);
            this.btnReportsCancel.Name = "btnReportsCancel";
            this.btnReportsCancel.Size = new System.Drawing.Size(158, 40);
            this.btnReportsCancel.TabIndex = 2;
            this.btnReportsCancel.Text = "Appointment Reports/Cancel";
            this.btnReportsCancel.UseVisualStyleBackColor = true;
            this.btnReportsCancel.Click += new System.EventHandler(this.btnReportsCancel_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(126, 337);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(145, 34);
            this.BackButton.TabIndex = 3;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.btnReportsCancel);
            this.Controls.Add(this.btnScheduleAppointment);
            this.Controls.Add(this.btnUpdateAccount);
            this.Name = "PatientOptionsForm";
            this.Text = "PatientOptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnScheduleAppointment;
        private System.Windows.Forms.Button btnReportsCancel;
        private System.Windows.Forms.Button BackButton;
    }
}