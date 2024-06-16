namespace HMS_CSElec_CS2B
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnCont = new Button();
            lblClear = new Label();
            btnExit = new Button();
            pictureBox4 = new PictureBox();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(95, 61);
            label1.Name = "label1";
            label1.Size = new Size(126, 42);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(36, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 2);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(36, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 2);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnCont
            // 
            btnCont.BackColor = Color.SteelBlue;
            btnCont.FlatStyle = FlatStyle.Flat;
            btnCont.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCont.ForeColor = Color.White;
            btnCont.Location = new Point(36, 253);
            btnCont.Name = "btnCont";
            btnCont.Size = new Size(239, 54);
            btnCont.TabIndex = 6;
            btnCont.Text = "CONTINUE";
            btnCont.UseVisualStyleBackColor = false;
            btnCont.Click += btnCont_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Font = new Font("Myanmar Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClear.ForeColor = Color.SteelBlue;
            lblClear.Location = new Point(209, 310);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(68, 20);
            lblClear.TabIndex = 8;
            lblClear.Text = "Clear Fields";
            lblClear.Click += lblClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Salmon;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(129, 430);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 27);
            btnExit.TabIndex = 9;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(314, -3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(634, 475);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(64, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(213, 22);
            txtUsername.TabIndex = 11;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(64, 204);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(213, 22);
            txtPass.TabIndex = 12;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 469);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox4);
            Controls.Add(btnExit);
            Controls.Add(lblClear);
            Controls.Add(btnCont);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignInForm";
            Text = "Sign-In Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btnCont;
        private Label lblClear;
        private Button btnExit;
        private PictureBox pictureBox4;
        private TextBox txtUsername;
        private TextBox txtPass;
    }
}
