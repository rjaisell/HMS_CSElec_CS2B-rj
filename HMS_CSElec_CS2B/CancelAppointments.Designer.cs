namespace HMS_CSElec_CS2B
{
    partial class CancelAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelAppointments));
            label2 = new Label();
            panel1 = new Panel();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            txtPatientID = new TextBox();
            label1 = new Label();
            btnCont = new Button();
            label3 = new Label();
            rtxtReason = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 9);
            label2.Name = "label2";
            label2.Size = new Size(719, 73);
            label2.TabIndex = 3;
            label2.Text = "| Cancel Appointment |";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 65);
            panel1.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.SteelBlue;
            label17.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(497, 19);
            label17.Name = "label17";
            label17.Size = new Size(220, 25);
            label17.TabIndex = 60;
            label17.Text = "Hospital Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // txtPatientID
            // 
            txtPatientID.Font = new Font("Bahnschrift Condensed", 12F);
            txtPatientID.Location = new Point(44, 147);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(200, 27);
            txtPatientID.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 125);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 32;
            label1.Text = "Enter Patient ID";
            // 
            // btnCont
            // 
            btnCont.BackColor = Color.Salmon;
            btnCont.FlatStyle = FlatStyle.Flat;
            btnCont.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCont.ForeColor = Color.White;
            btnCont.Location = new Point(248, 427);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(218, 57);
            btnCont.TabIndex = 35;
            btnCont.Text = "CANCEL APPOINTMENT";
            btnCont.UseVisualStyleBackColor = false;
            btnCont.Click += btnCont_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 220);
            label3.Name = "label3";
            label3.Size = new Size(137, 19);
            label3.TabIndex = 36;
            label3.Text = "Reason for Cancellation";
            // 
            // rtxtReason
            // 
            rtxtReason.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtReason.Location = new Point(45, 242);
            rtxtReason.Name = "rtxtReason";
            rtxtReason.Size = new Size(634, 162);
            rtxtReason.TabIndex = 38;
            rtxtReason.Text = "";
            // 
            // CancelAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 566);
            Controls.Add(rtxtReason);
            Controls.Add(label3);
            Controls.Add(btnCont);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelAppointments";
            Text = "CancelAppointments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtPatientID;
        private Label label1;
        private Button btnCont;
        private Label label3;
        private RichTextBox rtxtReason;
        private Label label17;
    }
}