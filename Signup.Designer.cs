namespace Visual_Programming_Project
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_psw = new System.Windows.Forms.TextBox();
            this.frsf = new System.Windows.Forms.Label();
            this.signup_close = new System.Windows.Forms.Label();
            this.signup_loginhere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showPsw = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.sdcf = new System.Windows.Forms.Label();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.sup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signup_psw);
            this.panel1.Controls.Add(this.frsf);
            this.panel1.Controls.Add(this.signup_close);
            this.panel1.Controls.Add(this.signup_loginhere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_showPsw);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.signup_username);
            this.panel1.Controls.Add(this.sdcf);
            this.panel1.Controls.Add(this.signup_email);
            this.panel1.Controls.Add(this.sup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 517);
            this.panel1.TabIndex = 1;
            // 
            // signup_psw
            // 
            this.signup_psw.Location = new System.Drawing.Point(302, 295);
            this.signup_psw.Multiline = true;
            this.signup_psw.Name = "signup_psw";
            this.signup_psw.PasswordChar = '*';
            this.signup_psw.Size = new System.Drawing.Size(302, 34);
            this.signup_psw.TabIndex = 12;
            // 
            // frsf
            // 
            this.frsf.AutoSize = true;
            this.frsf.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frsf.Location = new System.Drawing.Point(298, 269);
            this.frsf.Name = "frsf";
            this.frsf.Size = new System.Drawing.Size(108, 23);
            this.frsf.TabIndex = 11;
            this.frsf.Text = "Password:";
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_close.Location = new System.Drawing.Point(617, 33);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(21, 20);
            this.signup_close.TabIndex = 10;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // signup_loginhere
            // 
            this.signup_loginhere.AutoSize = true;
            this.signup_loginhere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_loginhere.ForeColor = System.Drawing.Color.Black;
            this.signup_loginhere.Location = new System.Drawing.Point(496, 435);
            this.signup_loginhere.Name = "signup_loginhere";
            this.signup_loginhere.Size = new System.Drawing.Size(90, 18);
            this.signup_loginhere.TabIndex = 9;
            this.signup_loginhere.Text = "Login Here";
            this.signup_loginhere.Click += new System.EventHandler(this.signup_loginhere_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(299, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already have an account?";
            // 
            // signup_showPsw
            // 
            this.signup_showPsw.AutoSize = true;
            this.signup_showPsw.BackColor = System.Drawing.Color.Transparent;
            this.signup_showPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_showPsw.ForeColor = System.Drawing.Color.Gray;
            this.signup_showPsw.Location = new System.Drawing.Point(482, 347);
            this.signup_showPsw.Name = "signup_showPsw";
            this.signup_showPsw.Size = new System.Drawing.Size(151, 24);
            this.signup_showPsw.TabIndex = 7;
            this.signup_showPsw.Text = "Show Password";
            this.signup_showPsw.UseVisualStyleBackColor = false;
            this.signup_showPsw.CheckedChanged += new System.EventHandler(this.signup_showPsw_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Navy;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.ForeColor = System.Drawing.Color.Transparent;
            this.signup_btn.Location = new System.Drawing.Point(302, 377);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(119, 41);
            this.signup_btn.TabIndex = 6;
            this.signup_btn.Text = "LOGIN";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(302, 214);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(302, 34);
            this.signup_username.TabIndex = 5;
            this.signup_username.UseSystemPasswordChar = true;
            // 
            // sdcf
            // 
            this.sdcf.AutoSize = true;
            this.sdcf.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sdcf.Location = new System.Drawing.Point(298, 188);
            this.sdcf.Name = "sdcf";
            this.sdcf.Size = new System.Drawing.Size(120, 23);
            this.sdcf.TabIndex = 4;
            this.sdcf.Text = "User name:";
            // 
            // signup_email
            // 
            this.signup_email.Location = new System.Drawing.Point(302, 139);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(302, 34);
            this.signup_email.TabIndex = 3;
            // 
            // sup
            // 
            this.sup.AutoSize = true;
            this.sup.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sup.Location = new System.Drawing.Point(298, 113);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(148, 23);
            this.sup.TabIndex = 2;
            this.sup.Text = "Email address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(298, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Started";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 514);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 490);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label signup_loginhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_showPsw;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label sdcf;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label sup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox signup_psw;
        private System.Windows.Forms.Label frsf;
    }
}