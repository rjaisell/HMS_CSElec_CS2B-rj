namespace HMS_CSElec_CS2B
{
    partial class AllocateBeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllocateBeds));
            panel1 = new Panel();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            txtPatientID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            cmbWardCategory = new ComboBox();
            label15 = new Label();
            btnCont = new Button();
            dtpAdmission = new DateTimePicker();
            label11 = new Label();
            dtpDischarge = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            chkHypertension = new CheckBox();
            chkDiabetes = new CheckBox();
            chkHeart = new CheckBox();
            chkKidney = new CheckBox();
            chkRespiratory = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 669);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 87);
            panel1.TabIndex = 54;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.SteelBlue;
            label17.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(571, 24);
            label17.Name = "label17";
            label17.Size = new Size(279, 33);
            label17.TabIndex = 60;
            label17.Text = "Hospital Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // txtPatientID
            // 
            txtPatientID.Font = new Font("Bahnschrift Condensed", 12F);
            txtPatientID.Location = new Point(64, 156);
            txtPatientID.Margin = new Padding(3, 4, 3, 4);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(228, 32);
            txtPatientID.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 127);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 36;
            label1.Text = "Enter Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(98, 12);
            label2.Name = "label2";
            label2.Size = new Size(683, 91);
            label2.TabIndex = 35;
            label2.Text = "| Bed Allocation |";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 205);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 45);
            panel2.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 5);
            label4.Name = "label4";
            label4.Size = new Size(202, 33);
            label4.TabIndex = 58;
            label4.Text = "MEDICAL CONDITIONS ";
            // 
            // cmbWardCategory
            // 
            cmbWardCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWardCategory.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWardCategory.FormattingEnabled = true;
            cmbWardCategory.Items.AddRange(new object[] { "General Ward", "Surgical Ward", "Medical Ward" });
            cmbWardCategory.Location = new Point(299, 156);
            cmbWardCategory.Margin = new Padding(3, 4, 3, 4);
            cmbWardCategory.Name = "cmbWardCategory";
            cmbWardCategory.Size = new Size(461, 32);
            cmbWardCategory.TabIndex = 70;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(295, 127);
            label15.Name = "label15";
            label15.Size = new Size(106, 24);
            label15.TabIndex = 69;
            label15.Text = "Ward Category";
            // 
            // btnCont
            // 
            btnCont.BackColor = Color.Salmon;
            btnCont.FlatStyle = FlatStyle.Flat;
            btnCont.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCont.ForeColor = Color.White;
            btnCont.Location = new Point(283, 571);
            btnCont.Margin = new Padding(3, 4, 3, 4);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(249, 76);
            btnCont.TabIndex = 71;
            btnCont.Text = "ALLOCATE BED";
            btnCont.UseVisualStyleBackColor = false;
            btnCont.Click += btnCont_Click;
            // 
            // dtpAdmission
            // 
            dtpAdmission.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAdmission.Format = DateTimePickerFormat.Custom;
            dtpAdmission.Location = new Point(64, 508);
            dtpAdmission.Margin = new Padding(3, 4, 3, 4);
            dtpAdmission.Name = "dtpAdmission";
            dtpAdmission.Size = new Size(228, 32);
            dtpAdmission.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(62, 479);
            label11.Name = "label11";
            label11.Size = new Size(112, 24);
            label11.TabIndex = 72;
            label11.Text = "Admission Date";
            // 
            // dtpDischarge
            // 
            dtpDischarge.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDischarge.Format = DateTimePickerFormat.Custom;
            dtpDischarge.Location = new Point(334, 508);
            dtpDischarge.Margin = new Padding(3, 4, 3, 4);
            dtpDischarge.Name = "dtpDischarge";
            dtpDischarge.Size = new Size(228, 32);
            dtpDischarge.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 479);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 75;
            label3.Text = "Discharge Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(58, 5);
            label5.Name = "label5";
            label5.Size = new Size(191, 33);
            label5.TabIndex = 58;
            label5.Text = "ALLOCATION DETAILS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 424);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 45);
            panel3.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(64, 261);
            label6.Name = "label6";
            label6.Size = new Size(362, 24);
            label6.TabIndex = 41;
            label6.Text = "Please check any of the following that applies to you";
            // 
            // chkHypertension
            // 
            chkHypertension.AutoSize = true;
            chkHypertension.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHypertension.Location = new Point(64, 297);
            chkHypertension.Margin = new Padding(3, 4, 3, 4);
            chkHypertension.Name = "chkHypertension";
            chkHypertension.Size = new Size(118, 28);
            chkHypertension.TabIndex = 58;
            chkHypertension.Text = "Hypertension";
            chkHypertension.UseVisualStyleBackColor = true;
            // 
            // chkDiabetes
            // 
            chkDiabetes.AutoSize = true;
            chkDiabetes.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDiabetes.Location = new Point(64, 336);
            chkDiabetes.Margin = new Padding(3, 4, 3, 4);
            chkDiabetes.Name = "chkDiabetes";
            chkDiabetes.Size = new Size(89, 28);
            chkDiabetes.TabIndex = 59;
            chkDiabetes.Text = "Diabetes";
            chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // chkHeart
            // 
            chkHeart.AutoSize = true;
            chkHeart.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHeart.Location = new Point(64, 375);
            chkHeart.Margin = new Padding(3, 4, 3, 4);
            chkHeart.Name = "chkHeart";
            chkHeart.Size = new Size(122, 28);
            chkHeart.TabIndex = 60;
            chkHeart.Text = "Heart Disease";
            chkHeart.UseVisualStyleBackColor = true;
            // 
            // chkKidney
            // 
            chkKidney.AutoSize = true;
            chkKidney.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkKidney.Location = new Point(334, 297);
            chkKidney.Margin = new Padding(3, 4, 3, 4);
            chkKidney.Name = "chkKidney";
            chkKidney.Size = new Size(132, 28);
            chkKidney.TabIndex = 61;
            chkKidney.Text = "Kidney Disease";
            chkKidney.UseVisualStyleBackColor = true;
            // 
            // chkRespiratory
            // 
            chkRespiratory.AutoSize = true;
            chkRespiratory.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRespiratory.Location = new Point(334, 336);
            chkRespiratory.Margin = new Padding(3, 4, 3, 4);
            chkRespiratory.Name = "chkRespiratory";
            chkRespiratory.Size = new Size(169, 28);
            chkRespiratory.TabIndex = 62;
            chkRespiratory.Text = "Respiratory Disorder";
            chkRespiratory.UseVisualStyleBackColor = true;
            // 
            // AllocateBeds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 755);
            Controls.Add(dtpDischarge);
            Controls.Add(label3);
            Controls.Add(dtpAdmission);
            Controls.Add(label11);
            Controls.Add(btnCont);
            Controls.Add(cmbWardCategory);
            Controls.Add(label15);
            Controls.Add(panel3);
            Controls.Add(chkRespiratory);
            Controls.Add(chkKidney);
            Controls.Add(chkHeart);
            Controls.Add(chkDiabetes);
            Controls.Add(chkHypertension);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllocateBeds";
            Text = "AllocateBeds";
            Load += AllocateBeds_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtPatientID;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label17;
        private ComboBox cmbWardCategory;
        private Label label15;
        private Button btnCont;
        private DateTimePicker dtpAdmission;
        private Label label11;
        private DateTimePicker dtpDischarge;
        private Label label3;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private CheckBox chkHypertension;
        private CheckBox chkDiabetes;
        private CheckBox chkHeart;
        private CheckBox chkKidney;
        private CheckBox chkRespiratory;
    }
}