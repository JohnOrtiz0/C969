namespace C969_performance_assessment
{
    partial class UpdateAppointmentForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.Label();
            this.startBox = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.urlInput = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.contactInput = new System.Windows.Forms.TextBox();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.typeInput = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(279, 312);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 20);
            this.dateLabel.TabIndex = 57;
            this.dateLabel.Text = "label1";
            // 
            // customerNameInput
            // 
            this.customerNameInput.AutoSize = true;
            this.customerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameInput.Location = new System.Drawing.Point(148, 98);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(124, 20);
            this.customerNameInput.TabIndex = 55;
            this.customerNameInput.Text = "Customer Name";
            // 
            // startBox
            // 
            this.startBox.FormattingEnabled = true;
            this.startBox.Items.AddRange(new object[] {
            "09:00:00 ",
            "09:30:00",
            "10:00:00 ",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00 ",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00"});
            this.startBox.Location = new System.Drawing.Point(282, 354);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(250, 21);
            this.startBox.TabIndex = 54;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(148, 307);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 20);
            this.date.TabIndex = 53;
            this.date.Text = "Date";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(78, 543);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(89, 20);
            this.description.TabIndex = 52;
            this.description.Text = "Description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionInput.Location = new System.Drawing.Point(82, 566);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(583, 277);
            this.descriptionInput.TabIndex = 51;
            // 
            // urlInput
            // 
            this.urlInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlInput.Location = new System.Drawing.Point(282, 481);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(250, 26);
            this.urlInput.TabIndex = 50;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.Location = new System.Drawing.Point(148, 484);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(42, 20);
            this.url.TabIndex = 49;
            this.url.Text = "URL";
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(253, 882);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(250, 50);
            this.UpdateAppointmentButton.TabIndex = 48;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = true;
            this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
            // 
            // contactInput
            // 
            this.contactInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInput.Location = new System.Drawing.Point(282, 413);
            this.contactInput.Name = "contactInput";
            this.contactInput.Size = new System.Drawing.Size(250, 26);
            this.contactInput.TabIndex = 47;
            // 
            // locationInput
            // 
            this.locationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationInput.Location = new System.Drawing.Point(282, 250);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(250, 26);
            this.locationInput.TabIndex = 46;
            // 
            // typeInput
            // 
            this.typeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeInput.Location = new System.Drawing.Point(282, 195);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(250, 26);
            this.typeInput.TabIndex = 45;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(147, 416);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(65, 20);
            this.contact.TabIndex = 44;
            this.contact.Text = "Contact";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(148, 253);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(70, 20);
            this.location.TabIndex = 43;
            this.location.Text = "Location";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(147, 198);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(43, 20);
            this.type.TabIndex = 42;
            this.type.Text = "Type";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(148, 356);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(44, 20);
            this.start.TabIndex = 41;
            this.start.Text = "Start";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(147, 147);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 20);
            this.title.TabIndex = 40;
            this.title.Text = "Title";
            // 
            // titleInput
            // 
            this.titleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleInput.Location = new System.Drawing.Point(282, 144);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(250, 26);
            this.titleInput.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Appointment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "label3";
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 960);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.urlInput);
            this.Controls.Add(this.url);
            this.Controls.Add(this.UpdateAppointmentButton);
            this.Controls.Add(this.contactInput);
            this.Controls.Add(this.locationInput);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.location);
            this.Controls.Add(this.type);
            this.Controls.Add(this.start);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleInput);
            this.Name = "UpdateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerNameInput;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox startBox;
        public System.Windows.Forms.TextBox descriptionInput;
        public System.Windows.Forms.TextBox urlInput;
        public System.Windows.Forms.TextBox contactInput;
        public System.Windows.Forms.TextBox locationInput;
        public System.Windows.Forms.TextBox typeInput;
        public System.Windows.Forms.TextBox titleInput;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Label label3;
    }
}