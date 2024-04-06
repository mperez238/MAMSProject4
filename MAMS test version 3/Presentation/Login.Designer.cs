namespace MedicalAppointmentManagementSystem
{
    partial class Login
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
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnProviderLogin = new System.Windows.Forms.Button();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(416, 291);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(132, 33);
            this.btnPatientLogin.TabIndex = 0;
            this.btnPatientLogin.Text = "Patient Login";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // btnProviderLogin
            // 
            this.btnProviderLogin.Location = new System.Drawing.Point(416, 239);
            this.btnProviderLogin.Name = "btnProviderLogin";
            this.btnProviderLogin.Size = new System.Drawing.Size(132, 31);
            this.btnProviderLogin.TabIndex = 1;
            this.btnProviderLogin.Text = "Provider Login";
            this.btnProviderLogin.UseVisualStyleBackColor = true;
            this.btnProviderLogin.Click += new System.EventHandler(this.btnProviderLogin_Click);
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(416, 193);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(132, 20);
            this.txtLoginId.TabIndex = 2;
            this.txtLoginId.TextChanged += new System.EventHandler(this.txtLoginId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter ID:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.btnProviderLogin);
            this.Controls.Add(this.btnPatientLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Button btnProviderLogin;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label label1;
    }
}

