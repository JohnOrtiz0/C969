namespace C969_performance_assessment
{
    partial class CustomerRecordsForm
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
			this.CustomerRecordView = new System.Windows.Forms.DataGridView();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CustomerRecordView)).BeginInit();
			this.SuspendLayout();
			// 
			// CustomerRecordView
			// 
			this.CustomerRecordView.AllowUserToAddRows = false;
			this.CustomerRecordView.AllowUserToDeleteRows = false;
			this.CustomerRecordView.AllowUserToResizeColumns = false;
			this.CustomerRecordView.AllowUserToResizeRows = false;
			this.CustomerRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CustomerRecordView.Location = new System.Drawing.Point(128, 138);
			this.CustomerRecordView.Name = "CustomerRecordView";
			this.CustomerRecordView.ReadOnly = true;
			this.CustomerRecordView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CustomerRecordView.Size = new System.Drawing.Size(847, 362);
			this.CustomerRecordView.TabIndex = 0;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.DeleteButton.Location = new System.Drawing.Point(900, 515);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 33);
			this.DeleteButton.TabIndex = 2;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.UpdateButton.Location = new System.Drawing.Point(801, 515);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(75, 33);
			this.UpdateButton.TabIndex = 4;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.AddButton.Location = new System.Drawing.Point(702, 515);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 33);
			this.AddButton.TabIndex = 5;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ExitButton.Location = new System.Drawing.Point(900, 576);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 33);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// CustomerRecordsForm
			// 
			this.ClientSize = new System.Drawing.Size(1102, 649);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.CustomerRecordView);
			this.Name = "CustomerRecordsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Customer Information";
			((System.ComponentModel.ISupportInitialize)(this.CustomerRecordView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.DataGridView CustomerRecordView;
    }
}