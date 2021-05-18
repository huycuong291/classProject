namespace classProject
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.txtLogin = new System.Windows.Forms.Label();
            this.icon_Password = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.icon_User = new System.Windows.Forms.PictureBox();
            this.fogotPassword = new System.Windows.Forms.Label();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Label();
            this.dontHaveAcc = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Button();
            this.hidePassword = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_User)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLogin.Location = new System.Drawing.Point(194, 39);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(179, 54);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Text = "LOG IN ";
            // 
            // icon_Password
            // 
            this.icon_Password.Image = ((System.Drawing.Image)(resources.GetObject("icon_Password.Image")));
            this.icon_Password.Location = new System.Drawing.Point(111, 183);
            this.icon_Password.Name = "icon_Password";
            this.icon_Password.Size = new System.Drawing.Size(48, 46);
            this.icon_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_Password.TabIndex = 3;
            this.icon_Password.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(111, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(111, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassword.Location = new System.Drawing.Point(165, 183);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(246, 46);
            this.txtPassword.TabIndex = 4;
            // 
            // icon_User
            // 
            this.icon_User.Image = ((System.Drawing.Image)(resources.GetObject("icon_User.Image")));
            this.icon_User.Location = new System.Drawing.Point(111, 120);
            this.icon_User.Name = "icon_User";
            this.icon_User.Size = new System.Drawing.Size(48, 46);
            this.icon_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_User.TabIndex = 3;
            this.icon_User.TabStop = false;
            // 
            // fogotPassword
            // 
            this.fogotPassword.AutoSize = true;
            this.fogotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fogotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fogotPassword.Location = new System.Drawing.Point(297, 246);
            this.fogotPassword.Name = "fogotPassword";
            this.fogotPassword.Size = new System.Drawing.Size(137, 17);
            this.fogotPassword.TabIndex = 7;
            this.fogotPassword.Text = "Fogot Password ?";
            // 
            // button_LogIn
            // 
            this.button_LogIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_LogIn.Location = new System.Drawing.Point(174, 278);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(143, 57);
            this.button_LogIn.TabIndex = 8;
            this.button_LogIn.Text = "LOG IN";
            this.button_LogIn.UseVisualStyleBackColor = false;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUp.Location = new System.Drawing.Point(211, 359);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(59, 16);
            this.signUp.TabIndex = 9;
            this.signUp.Text = "Sign up";
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // dontHaveAcc
            // 
            this.dontHaveAcc.AutoSize = true;
            this.dontHaveAcc.Location = new System.Drawing.Point(171, 338);
            this.dontHaveAcc.Name = "dontHaveAcc";
            this.dontHaveAcc.Size = new System.Drawing.Size(150, 17);
            this.dontHaveAcc.TabIndex = 10;
            this.dontHaveAcc.Text = "Don\'t have a account?";
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.Location = new System.Drawing.Point(417, 193);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(46, 41);
            this.showPassword.TabIndex = 11;
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hidePassword.Image = ((System.Drawing.Image)(resources.GetObject("hidePassword.Image")));
            this.hidePassword.Location = new System.Drawing.Point(417, 193);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(46, 41);
            this.hidePassword.TabIndex = 11;
            this.hidePassword.UseVisualStyleBackColor = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsername.Location = new System.Drawing.Point(165, 118);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 46);
            this.txtUsername.TabIndex = 4;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 406);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.dontHaveAcc);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.fogotPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.icon_User);
            this.Controls.Add(this.icon_Password);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.hidePassword);
            this.Name = "loginForm";
            this.Text = "19110107_KhucNguyenHuyCuong_day01";
            ((System.ComponentModel.ISupportInitialize)(this.icon_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.PictureBox icon_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox icon_User;
        private System.Windows.Forms.Label fogotPassword;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.Label dontHaveAcc;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button hidePassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

