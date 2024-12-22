namespace Visual_Programming_Project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_close = new System.Windows.Forms.Label();
            this.login_registerHere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_showPsw = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_psw = new System.Windows.Forms.TextBox();
            this.login_ps = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.loginus = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.login_registerHere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.login_showPsw);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.login_psw);
            this.panel1.Controls.Add(this.login_ps);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.loginus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 490);
            this.panel1.TabIndex = 0;
        
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_close.Location = new System.Drawing.Point(625, 18);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(21, 20);
            this.login_close.TabIndex = 10;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // login_registerHere
            // 
            this.login_registerHere.AutoSize = true;
            this.login_registerHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_registerHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_registerHere.ForeColor = System.Drawing.Color.Black;
            this.login_registerHere.Location = new System.Drawing.Point(496, 435);
            this.login_registerHere.Name = "login_registerHere";
            this.login_registerHere.Size = new System.Drawing.Size(112, 18);
            this.login_registerHere.TabIndex = 9;
            this.login_registerHere.Text = "Register Here";
            this.login_registerHere.Click += new System.EventHandler(this.login_registerHere_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(299, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t you have an account?";
            // 
            // login_showPsw
            // 
            this.login_showPsw.AutoSize = true;
            this.login_showPsw.BackColor = System.Drawing.Color.Transparent;
            this.login_showPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_showPsw.ForeColor = System.Drawing.Color.Gray;
            this.login_showPsw.Location = new System.Drawing.Point(453, 325);
            this.login_showPsw.Name = "login_showPsw";
            this.login_showPsw.Size = new System.Drawing.Size(151, 24);
            this.login_showPsw.TabIndex = 7;
            this.login_showPsw.Text = "Show Password";
            this.login_showPsw.UseVisualStyleBackColor = false;
            this.login_showPsw.CheckedChanged += new System.EventHandler(this.login_showPsw_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Navy;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.Transparent;
            this.login_btn.Location = new System.Drawing.Point(302, 367);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(119, 41);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_psw
            // 
            this.login_psw.Location = new System.Drawing.Point(302, 268);
            this.login_psw.Multiline = true;
            this.login_psw.Name = "login_psw";
            this.login_psw.PasswordChar = '*';
            this.login_psw.Size = new System.Drawing.Size(302, 34);
            this.login_psw.TabIndex = 5;
            // 
            // login_ps
            // 
            this.login_ps.AutoSize = true;
            this.login_ps.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_ps.Location = new System.Drawing.Point(298, 242);
            this.login_ps.Name = "login_ps";
            this.login_ps.Size = new System.Drawing.Size(108, 23);
            this.login_ps.TabIndex = 4;
            this.login_ps.Text = "Password:";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(302, 184);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(302, 34);
            this.login_username.TabIndex = 3;
            // 
            // loginus
            // 
            this.loginus.AutoSize = true;
            this.loginus.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginus.Location = new System.Drawing.Point(298, 158);
            this.loginus.Name = "loginus";
            this.loginus.Size = new System.Drawing.Size(123, 23);
            this.loginus.TabIndex = 2;
            this.loginus.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(298, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 490);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 490);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loginus;
        private System.Windows.Forms.CheckBox login_showPsw;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_psw;
        private System.Windows.Forms.Label login_ps;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label login_registerHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label login_close;
    }
}

