namespace HMS_CSElec_CS2B
{
    partial class ReleaseBeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseBeds));
            label2 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            btnCont = new Button();
            panel1 = new Panel();
            label17 = new Label();
            pictureBox1 = new PictureBox();
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
            label2.Location = new Point(113, 9);
            label2.Name = "label2";
            label2.Size = new Size(499, 73);
            label2.TabIndex = 36;
            label2.Text = "| Release Beds |";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(398, 27);
            comboBox1.TabIndex = 74;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(263, 109);
            label15.Name = "label15";
            label15.Size = new Size(86, 19);
            label15.TabIndex = 73;
            label15.Text = "Ward Category";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bahnschrift Condensed", 12F);
            textBox2.Location = new Point(61, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 109);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 75;
            label3.Text = "Enter Bed ID";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(48, 213);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(634, 162);
            richTextBox1.TabIndex = 78;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 191);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 77;
            label1.Text = "Discharge Summary";
            // 
            // btnCont
            // 
            btnCont.BackColor = Color.Salmon;
            btnCont.FlatStyle = FlatStyle.Flat;
            btnCont.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCont.ForeColor = Color.White;
            btnCont.Location = new Point(249, 428);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(218, 57);
            btnCont.TabIndex = 79;
            btnCont.Text = "RELEASE BED";
            btnCont.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 65);
            panel1.TabIndex = 80;
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
            // ReleaseBeds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 566);
            Controls.Add(panel1);
            Controls.Add(btnCont);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label15);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReleaseBeds";
            Text = "ReleaseBeds";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private Label label15;
        private TextBox textBox2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button btnCont;
        private Panel panel1;
        private Label label17;
        private PictureBox pictureBox1;
    }
}