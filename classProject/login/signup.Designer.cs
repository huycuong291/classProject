
namespace classProject
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.label1 = new System.Windows.Forms.Label();
            this.su_name = new System.Windows.Forms.TextBox();
            this.su_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.su_ok = new System.Windows.Forms.Button();
            this.su_cancel = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.Button();
            this.hidePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // su_name
            // 
            this.su_name.Location = new System.Drawing.Point(102, 97);
            this.su_name.Name = "su_name";
            this.su_name.Size = new System.Drawing.Size(150, 22);
            this.su_name.TabIndex = 1;
            // 
            // su_pass
            // 
            this.su_pass.Location = new System.Drawing.Point(102, 136);
            this.su_pass.Name = "su_pass";
            this.su_pass.PasswordChar = '•';
            this.su_pass.Size = new System.Drawing.Size(150, 22);
            this.su_pass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // su_ok
            // 
            this.su_ok.Location = new System.Drawing.Point(177, 186);
            this.su_ok.Name = "su_ok";
            this.su_ok.Size = new System.Drawing.Size(75, 23);
            this.su_ok.TabIndex = 2;
            this.su_ok.Text = "OK";
            this.su_ok.UseVisualStyleBackColor = true;
            this.su_ok.Click += new System.EventHandler(this.su_ok_Click);
            // 
            // su_cancel
            // 
            this.su_cancel.Location = new System.Drawing.Point(83, 186);
            this.su_cancel.Name = "su_cancel";
            this.su_cancel.Size = new System.Drawing.Size(75, 23);
            this.su_cancel.TabIndex = 2;
            this.su_cancel.Text = "Cancel";
            this.su_cancel.UseVisualStyleBackColor = true;
            this.su_cancel.Click += new System.EventHandler(this.su_cancel_Click);
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.Location = new System.Drawing.Point(275, 136);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(30, 25);
            this.showPassword.TabIndex = 12;
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click_1);
            // 
            // hidePassword
            // 
            this.hidePassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hidePassword.Image = ((System.Drawing.Image)(resources.GetObject("hidePassword.Image")));
            this.hidePassword.Location = new System.Drawing.Point(255, 136);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(33, 25);
            this.hidePassword.TabIndex = 13;
            this.hidePassword.UseVisualStyleBackColor = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click_1);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 281);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.su_cancel);
            this.Controls.Add(this.su_ok);
            this.Controls.Add(this.su_pass);
            this.Controls.Add(this.su_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hidePassword);
            this.Name = "signup";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox su_name;
        private System.Windows.Forms.TextBox su_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button su_ok;
        private System.Windows.Forms.Button su_cancel;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button hidePassword;
    }
}