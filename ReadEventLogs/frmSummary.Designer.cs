namespace ReadEventLogs
{
    partial class frmSummary
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
            this.lblheading = new System.Windows.Forms.Label();
            this.lblFirstLoginTime = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblTotalTimeInOffice = new System.Windows.Forms.Label();
            this.lblsevenhours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblheading.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.Color.Green;
            this.lblheading.Location = new System.Drawing.Point(0, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(513, 44);
            this.lblheading.TabIndex = 3;
            this.lblheading.Text = "Today\'s First Login Time";
            this.lblheading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstLoginTime
            // 
            this.lblFirstLoginTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstLoginTime.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLoginTime.ForeColor = System.Drawing.Color.Green;
            this.lblFirstLoginTime.Location = new System.Drawing.Point(0, 44);
            this.lblFirstLoginTime.Name = "lblFirstLoginTime";
            this.lblFirstLoginTime.Size = new System.Drawing.Size(513, 37);
            this.lblFirstLoginTime.TabIndex = 4;
            this.lblFirstLoginTime.Text = "lblFirstLoginTime";
            this.lblFirstLoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetails
            // 
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDetails.Location = new System.Drawing.Point(0, 208);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(513, 58);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Login Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblTotalTimeInOffice
            // 
            this.lblTotalTimeInOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTimeInOffice.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimeInOffice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalTimeInOffice.Location = new System.Drawing.Point(0, 81);
            this.lblTotalTimeInOffice.Name = "lblTotalTimeInOffice";
            this.lblTotalTimeInOffice.Size = new System.Drawing.Size(513, 36);
            this.lblTotalTimeInOffice.TabIndex = 6;
            this.lblTotalTimeInOffice.Text = "lblTotalTimeInOffice";
            this.lblTotalTimeInOffice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsevenhours
            // 
            this.lblsevenhours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsevenhours.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsevenhours.ForeColor = System.Drawing.Color.Green;
            this.lblsevenhours.Location = new System.Drawing.Point(0, 117);
            this.lblsevenhours.Name = "lblsevenhours";
            this.lblsevenhours.Size = new System.Drawing.Size(513, 36);
            this.lblsevenhours.TabIndex = 7;
            this.lblsevenhours.Text = "lblsevenhours";
            this.lblsevenhours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 266);
            this.Controls.Add(this.lblsevenhours);
            this.Controls.Add(this.lblTotalTimeInOffice);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblFirstLoginTime);
            this.Controls.Add(this.lblheading);
            this.Name = "frmSummary";
            this.Text = "Apna Login Time Pata Karain";
            this.Load += new System.EventHandler(this.frmSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lblFirstLoginTime;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblTotalTimeInOffice;
        private System.Windows.Forms.Label lblsevenhours;

    }
}

