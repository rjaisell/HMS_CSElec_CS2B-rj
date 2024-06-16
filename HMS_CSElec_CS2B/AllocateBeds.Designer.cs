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
            panel1.Location = new Point(-3, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 65);
            panel1.TabIndex = 54;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.SteelBlue;
            label17.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(500, 18);
            label17.Name = "label17";
            label17.Size = new Size(220, 25);
            label17.TabIndex = 60;
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
            // txtPatientID
            // 
            txtPatientID.Font = new Font("Bahnschrift Condensed", 12F);
            txtPatientID.Location = new Point(56, 117);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(200, 27);
            txtPatientID.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 95);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 36;
            label1.Text = "Enter Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 9);
            label2.Name = "label2";
            label2.Size = new Size(550, 73);
            label2.TabIndex = 35;
            label2.Text = "| Bed Allocation |";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 34);
            panel2.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 4);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 58;
            label4.Text = "MEDICAL CONDITIONS ";
            // 
            // cmbWardCategory
            // 
            cmbWardCategory.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWardCategory.FormattingEnabled = true;
            cmbWardCategory.Location = new Point(262, 117);
            cmbWardCategory.Name = "cmbWardCategory";
            cmbWardCategory.Size = new Size(404, 27);
            cmbWardCategory.TabIndex = 70;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(258, 95);
            label15.Name = "label15";
            label15.Size = new Size(86, 19);
            label15.TabIndex = 69;
            label15.Text = "Ward Category";
            // 
            // btnCont
            // 
            btnCont.BackColor = Color.Salmon;
            btnCont.FlatStyle = FlatStyle.Flat;
            btnCont.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCont.ForeColor = Color.White;
            btnCont.Location = new Point(248, 428);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(218, 57);
            btnCont.TabIndex = 71;
            btnCont.Text = "ALLOCATE BED";
            btnCont.UseVisualStyleBackColor = false;
            btnCont.Click += btnCont_Click;
            // 
            // dtpAdmission
            // 
            dtpAdmission.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAdmission.Format = DateTimePickerFormat.Custom;
            dtpAdmission.Location = new Point(56, 381);
            dtpAdmission.Name = "dtpAdmission";
            dtpAdmission.Size = new Size(200, 27);
            dtpAdmission.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(54, 359);
            label11.Name = "label11";
            label11.Size = new Size(90, 19);
            label11.TabIndex = 72;
            label11.Text = "Admission Date";
            // 
            // dtpDischarge
            // 
            dtpDischarge.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDischarge.Format = DateTimePickerFormat.Custom;
            dtpDischarge.Location = new Point(292, 381);
            dtpDischarge.Name = "dtpDischarge";
            dtpDischarge.Size = new Size(200, 27);
            dtpDischarge.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 359);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 75;
            label3.Text = "Discharge Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 4);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 58;
            label5.Text = "ALLOCATION DETAILS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 34);
            panel3.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 196);
            label6.Name = "label6";
            label6.Size = new Size(288, 19);
            label6.TabIndex = 41;
            label6.Text = "Please check any of the following that applies to you";
            // 
            // chkHypertension
            // 
            chkHypertension.AutoSize = true;
            chkHypertension.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHypertension.Location = new Point(56, 223);
            chkHypertension.Name = "chkHypertension";
            chkHypertension.Size = new Size(97, 23);
            chkHypertension.TabIndex = 58;
            chkHypertension.Text = "Hypertension";
            chkHypertension.UseVisualStyleBackColor = true;
            // 
            // chkDiabetes
            // 
            chkDiabetes.AutoSize = true;
            chkDiabetes.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDiabetes.Location = new Point(56, 252);
            chkDiabetes.Name = "chkDiabetes";
            chkDiabetes.Size = new Size(73, 23);
            chkDiabetes.TabIndex = 59;
            chkDiabetes.Text = "Diabetes";
            chkDiabetes.UseVisualStyleBackColor = true;
            // 
            // chkHeart
            // 
            chkHeart.AutoSize = true;
            chkHeart.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHeart.Location = new Point(56, 281);
            chkHeart.Name = "chkHeart";
            chkHeart.Size = new Size(101, 23);
            chkHeart.TabIndex = 60;
            chkHeart.Text = "Heart Disease";
            chkHeart.UseVisualStyleBackColor = true;
            // 
            // chkKidney
            // 
            chkKidney.AutoSize = true;
            chkKidney.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkKidney.Location = new Point(292, 223);
            chkKidney.Name = "chkKidney";
            chkKidney.Size = new Size(107, 23);
            chkKidney.TabIndex = 61;
            chkKidney.Text = "Kidney Disease";
            chkKidney.UseVisualStyleBackColor = true;
            // 
            // chkRespiratory
            // 
            chkRespiratory.AutoSize = true;
            chkRespiratory.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRespiratory.Location = new Point(292, 252);
            chkRespiratory.Name = "chkRespiratory";
            chkRespiratory.Size = new Size(136, 23);
            chkRespiratory.TabIndex = 62;
            chkRespiratory.Text = "Respiratory Disorder";
            chkRespiratory.UseVisualStyleBackColor = true;
            // 
            // AllocateBeds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 566);
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