namespace C969_performance_assessment
{
    partial class CalenderClickForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.AddAppointmentButton = new System.Windows.Forms.Button();
			this.DeleteAppoinmentButton = new System.Windows.Forms.Button();
			this.UpdateAppointmentButton = new System.Windows.Forms.Button();
			this.appointmentView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.CustomerRecordButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.appointmentView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Appointments for";
			// 
			// AddAppointmentButton
			// 
			this.AddAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddAppointmentButton.Location = new System.Drawing.Point(681, 482);
			this.AddAppointmentButton.Name = "AddAppointmentButton";
			this.AddAppointmentButton.Size = new System.Drawing.Size(166, 41);
			this.AddAppointmentButton.TabIndex = 1;
			this.AddAppointmentButton.Text = "Add Appointment";
			this.AddAppointmentButton.UseVisualStyleBackColor = true;
			this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
			// 
			// DeleteAppoinmentButton
			// 
			this.DeleteAppoinmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteAppoinmentButton.Location = new System.Drawing.Point(1025, 482);
			this.DeleteAppoinmentButton.Name = "DeleteAppoinmentButton";
			this.DeleteAppoinmentButton.Size = new System.Drawing.Size(166, 41);
			this.DeleteAppoinmentButton.TabIndex = 2;
			this.DeleteAppoinmentButton.Text = "Delete Appointment";
			this.DeleteAppoinmentButton.UseVisualStyleBackColor = true;
			this.DeleteAppoinmentButton.Click += new System.EventHandler(this.DeleteAppoinmentButton_Click);
			// 
			// UpdateAppointmentButton
			// 
			this.UpdateAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateAppointmentButton.Location = new System.Drawing.Point(853, 482);
			this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
			this.UpdateAppointmentButton.Size = new System.Drawing.Size(166, 41);
			this.UpdateAppointmentButton.TabIndex = 3;
			this.UpdateAppointmentButton.Text = "Update Appointment";
			this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
			this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
			// 
			// appointmentView
			// 
			this.appointmentView.AllowUserToAddRows = false;
			this.appointmentView.AllowUserToDeleteRows = false;
			this.appointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentView.Location = new System.Drawing.Point(51, 138);
			this.appointmentView.Name = "appointmentView";
			this.appointmentView.ReadOnly = true;
			this.appointmentView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.appointmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.appointmentView.Size = new System.Drawing.Size(1139, 328);
			this.appointmentView.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(258, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 31);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// CustomerRecordButton
			// 
			this.CustomerRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomerRecordButton.Location = new System.Drawing.Point(1025, 80);
			this.CustomerRecordButton.Name = "CustomerRecordButton";
			this.CustomerRecordButton.Size = new System.Drawing.Size(166, 41);
			this.CustomerRecordButton.TabIndex = 6;
			this.CustomerRecordButton.Text = "Customer Record";
			this.CustomerRecordButton.UseVisualStyleBackColor = true;
			this.CustomerRecordButton.Click += new System.EventHandler(this.CustomerRecordButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(1025, 553);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(166, 41);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// CalenderClickForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1344, 606);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.CustomerRecordButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.appointmentView);
			this.Controls.Add(this.UpdateAppointmentButton);
			this.Controls.Add(this.DeleteAppoinmentButton);
			this.Controls.Add(this.AddAppointmentButton);
			this.Controls.Add(this.label1);
			this.Name = "CalenderClickForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Appointments";
			((System.ComponentModel.ISupportInitialize)(this.appointmentView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Button DeleteAppoinmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.DataGridView appointmentView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CustomerRecordButton;
		private System.Windows.Forms.Button ExitButton;
	}
}