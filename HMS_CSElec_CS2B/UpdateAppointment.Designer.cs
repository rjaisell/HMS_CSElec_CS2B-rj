namespace HMS_CSElec_CS2B
{
    partial class UpdateAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAppointment));
            btnBook = new Button();
            panel3 = new Panel();
            label16 = new Label();
            panel2 = new Panel();
            label14 = new Label();
            panel1 = new Panel();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dtBday = new DateTimePicker();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtAdd = new TextBox();
            label7 = new Label();
            txtContact = new TextBox();
            label6 = new Label();
            txtMName = new TextBox();
            txtFName = new TextBox();
            label3 = new Label();
            txtLName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            lblPatientID = new Label();
            cbApptType = new ComboBox();
            label15 = new Label();
            dtApptD = new DateTimePicker();
            label11 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Salmon;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(238, 430);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(218, 57);
            btnBook.TabIndex = 85;
            btnBook.Text = "UPDATE APPOINTMENT";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label16);
            panel3.Location = new Point(-10, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 34);
            panel3.TabIndex = 84;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.SteelBlue;
            label16.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(51, 4);
            label16.Name = "label16";
            label16.Size = new Size(193, 25);
            label16.TabIndex = 58;
            label16.Text = "APPOINTMENT SCHEDULING";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label14);
            panel2.Location = new Point(0, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 34);
            panel2.TabIndex = 83;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.SteelBlue;
            label14.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(51, 4);
            label14.Name = "label14";
            label14.Size = new Size(175, 25);
            label14.TabIndex = 58;
            label14.Text = "PERSONAL INFORMATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-12, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 65);
            panel1.TabIndex = 79;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.SteelBlue;
            label17.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(499, 19);
            label17.Name = "label17";
            label17.Size = new Size(220, 25);
            label17.TabIndex = 59;
            label17.Text = "Hospital Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 11);
            label2.Name = "label2";
            label2.Size = new Size(714, 73);
            label2.TabIndex = 60;
            label2.Text = "| Update Appointment |";
            // 
            // dtBday
            // 
            dtBday.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtBday.Format = DateTimePickerFormat.Custom;
            dtBday.Location = new Point(462, 272);
            dtBday.Name = "dtBday";
            dtBday.Size = new Size(200, 27);
            dtBday.TabIndex = 101;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(458, 250);
            label13.Name = "label13";
            label13.Size = new Size(75, 19);
            label13.TabIndex = 99;
            label13.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(525, 223);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 96;
            label5.Text = "Middlename";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(327, 223);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 95;
            label4.Text = "Firstname";
            // 
            // txtAdd
            // 
            txtAdd.Font = new Font("Bahnschrift Condensed", 12F);
            txtAdd.Location = new Point(256, 272);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(200, 27);
            txtAdd.TabIndex = 94;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(252, 250);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 93;
            label7.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Bahnschrift Condensed", 12F);
            txtContact.Location = new Point(50, 272);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 27);
            txtContact.TabIndex = 92;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 250);
            label6.Name = "label6";
            label6.Size = new Size(60, 19);
            label6.TabIndex = 91;
            label6.Text = "Contact #";
            // 
            // txtMName
            // 
            txtMName.Font = new Font("Bahnschrift Condensed", 12F);
            txtMName.Location = new Point(462, 193);
            txtMName.Name = "txtMName";
            txtMName.Size = new Size(200, 27);
            txtMName.TabIndex = 90;
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Bahnschrift Condensed", 12F);
            txtFName.Location = new Point(256, 193);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(200, 27);
            txtFName.TabIndex = 89;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(122, 223);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 88;
            label3.Text = "Lastname";
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Bahnschrift Condensed", 12F);
            txtLName.Location = new Point(50, 193);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(200, 27);
            txtLName.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 171);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 86;
            label1.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(51, 96);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 102;
            label8.Text = "PatientID:";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(117, 96);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(20, 19);
            lblPatientID.TabIndex = 103;
            lblPatientID.Text = "\" \"";
            // 
            // cbApptType
            // 
            cbApptType.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbApptType.FormattingEnabled = true;
            cbApptType.Items.AddRange(new object[] { "Initial Consultation Visit", "Follow-up Visit" });
            cbApptType.Location = new Point(256, 380);
            cbApptType.Name = "cbApptType";
            cbApptType.Size = new Size(406, 27);
            cbApptType.TabIndex = 108;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(252, 358);
            label15.Name = "label15";
            label15.Size = new Size(101, 19);
            label15.TabIndex = 107;
            label15.Text = "Appointment Type";
            // 
            // dtApptD
            // 
            dtApptD.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtApptD.Format = DateTimePickerFormat.Custom;
            dtApptD.Location = new Point(50, 380);
            dtApptD.Name = "dtApptD";
            dtApptD.Size = new Size(200, 27);
            dtApptD.TabIndex = 106;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 358);
            label11.Name = "label11";
            label11.Size = new Size(155, 19);
            label11.TabIndex = 104;
            label11.Text = "Preferred Appointment Date";
            // 
            // UpdateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 566);
            Controls.Add(cbApptType);
            Controls.Add(label15);
            Controls.Add(dtApptD);
            Controls.Add(label11);
            Controls.Add(lblPatientID);
            Controls.Add(label8);
            Controls.Add(dtBday);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAdd);
            Controls.Add(label7);
            Controls.Add(txtContact);
            Controls.Add(label6);
            Controls.Add(txtMName);
            Controls.Add(txtFName);
            Controls.Add(label3);
            Controls.Add(txtLName);
            Controls.Add(label1);
            Controls.Add(btnBook);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdateAppointment";
            Text = "Update Appointment";
            Load += UpdateAppointment_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBook;
        private Panel panel3;
        private Label label16;
        private Panel panel2;
        private Label label14;
        private Panel panel1;
        private Label label17;
        private PictureBox pictureBox1;
        private Label label2;
        private DateTimePicker dtBday;
        private Label label13;
        private Label label5;
        private Label label4;
        private TextBox txtAdd;
        private Label label7;
        private TextBox txtContact;
        private Label label6;
        private TextBox txtMName;
        private TextBox txtFName;
        private Label label3;
        private TextBox txtLName;
        private Label label1;
        private Label label8;
        private Label lblPatientID;
        private ComboBox cbApptType;
        private Label label15;
        private DateTimePicker dtApptD;
        private Label label11;
    }
}