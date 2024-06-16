namespace HMS_CSElec_CS2B
{
    partial class frmViewAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAppointments));
            label1 = new Label();
            dgApptV = new DataGridView();
            panel1 = new Panel();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgApptV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(668, 73);
            label1.TabIndex = 0;
            label1.Text = "| View Appointments |";
            // 
            // dgApptV
            // 
            dgApptV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgApptV.Location = new Point(30, 137);
            dgApptV.Name = "dgApptV";
            dgApptV.Size = new Size(668, 342);
            dgApptV.TabIndex = 1;
            dgApptV.CellContentClick += dgApptV_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 65);
            panel1.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.SteelBlue;
            label17.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(497, 17);
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
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(30, 94);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 30);
            btnRefresh.TabIndex = 60;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmViewAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 566);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(dgApptV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewAppointments";
            Text = "ViewAppointments";
            Load += frmViewAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgApptV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label17;
        public DataGridView dgApptV;
        private Button btnRefresh;
    }
}