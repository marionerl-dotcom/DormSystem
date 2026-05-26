namespace Dormitory
{
    partial class reserve_checkin
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
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuardianFN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnRCI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(358, 287);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(176, 24);
            this.cmbGender.TabIndex = 28;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(447, 329);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(148, 45);
            this.btnReserve.TabIndex = 27;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Guardians\'s Full Name:";
            // 
            // txtGuardianFN
            // 
            this.txtGuardianFN.Location = new System.Drawing.Point(358, 242);
            this.txtGuardianFN.Name = "txtGuardianFN";
            this.txtGuardianFN.Size = new System.Drawing.Size(177, 22);
            this.txtGuardianFN.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(358, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 22);
            this.txtEmail.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(358, 152);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(177, 22);
            this.txtStudentID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contact Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Full Name:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(358, 197);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(177, 22);
            this.txtNo.TabIndex = 17;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(358, 65);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(177, 22);
            this.txtFN.TabIndex = 16;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(251, 329);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(148, 45);
            this.btnCheckIn.TabIndex = 29;
            this.btnCheckIn.Text = "Checkin";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnRCI
            // 
            this.btnRCI.BackColor = System.Drawing.Color.White;
            this.btnRCI.Location = new System.Drawing.Point(341, 381);
            this.btnRCI.Name = "btnRCI";
            this.btnRCI.Size = new System.Drawing.Size(148, 45);
            this.btnRCI.TabIndex = 30;
            this.btnRCI.Text = "Checkin reserve";
            this.btnRCI.UseVisualStyleBackColor = false;
            this.btnRCI.Click += new System.EventHandler(this.btnRCI_Click);
            // 
            // reserve_checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRCI);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGuardianFN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtFN);
            this.Name = "reserve_checkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reserve_checkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuardianFN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnRCI;
    }
}