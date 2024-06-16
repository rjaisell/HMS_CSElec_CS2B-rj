namespace HMS_CSElec_CS2B
{
    partial class ViewBeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBeds));
            label2 = new Label();
            dgViewB = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgViewB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(697, 73);
            label2.TabIndex = 3;
            label2.Text = "| View Available Beds |";
            // 
            // dgViewB
            // 
            dgViewB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewB.Location = new Point(30, 118);
            dgViewB.Name = "dgViewB";
            dgViewB.Size = new Size(668, 360);
            dgViewB.TabIndex = 4;
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
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 65);
            panel1.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.SteelBlue;
            label17.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(497, 18);
            label17.Name = "label17";
            label17.Size = new Size(220, 25);
            label17.TabIndex = 60;
            label17.Text = "Hospital Management System";
            // 
            // ViewBeds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 566);
            Controls.Add(panel1);
            Controls.Add(dgViewB);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBeds";
            Text = "ViewBeds";
            Load += ViewBeds_Load;
            ((System.ComponentModel.ISupportInitialize)dgViewB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dgViewB;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label17;
    }
}