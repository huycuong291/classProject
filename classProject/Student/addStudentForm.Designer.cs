namespace classProject
{
    partial class addStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudentForm));
            this.stuLable = new System.Windows.Forms.Label();
            this.AF_id_txt = new System.Windows.Forms.TextBox();
            this.AF_phone_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AF_fullname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AF_dob_txt = new System.Windows.Forms.DateTimePicker();
            this.AF_address_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AF_male_check = new System.Windows.Forms.RadioButton();
            this.AF_female_check = new System.Windows.Forms.RadioButton();
            this.AF_picture_pic = new System.Windows.Forms.PictureBox();
            this.backGround = new System.Windows.Forms.PictureBox();
            this.backgourd2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AF_picture_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgourd2)).BeginInit();
            this.SuspendLayout();
            // 
            // stuLable
            // 
            this.stuLable.AutoSize = true;
            this.stuLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.stuLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuLable.ForeColor = System.Drawing.Color.Black;
            this.stuLable.Location = new System.Drawing.Point(12, 24);
            this.stuLable.Name = "stuLable";
            this.stuLable.Size = new System.Drawing.Size(89, 17);
            this.stuLable.TabIndex = 8;
            this.stuLable.Text = "Student ID:";
            // 
            // AF_id_txt
            // 
            this.AF_id_txt.Location = new System.Drawing.Point(128, 24);
            this.AF_id_txt.Name = "AF_id_txt";
            this.AF_id_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_id_txt.TabIndex = 9;
            // 
            // AF_phone_txt
            // 
            this.AF_phone_txt.Location = new System.Drawing.Point(128, 80);
            this.AF_phone_txt.Name = "AF_phone_txt";
            this.AF_phone_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_phone_txt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone Number:";
            // 
            // AF_fullname_txt
            // 
            this.AF_fullname_txt.Location = new System.Drawing.Point(128, 52);
            this.AF_fullname_txt.Name = "AF_fullname_txt";
            this.AF_fullname_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_fullname_txt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "DOB:";
            // 
            // AF_dob_txt
            // 
            this.AF_dob_txt.CustomFormat = "dd/MM/yyyy";
            this.AF_dob_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AF_dob_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AF_dob_txt.Location = new System.Drawing.Point(128, 108);
            this.AF_dob_txt.Name = "AF_dob_txt";
            this.AF_dob_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AF_dob_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_dob_txt.TabIndex = 16;
            // 
            // AF_address_txt
            // 
            this.AF_address_txt.Location = new System.Drawing.Point(128, 175);
            this.AF_address_txt.Multiline = true;
            this.AF_address_txt.Name = "AF_address_txt";
            this.AF_address_txt.Size = new System.Drawing.Size(190, 87);
            this.AF_address_txt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Picture:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(32, 419);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 45);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(191, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 45);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gender:";
            // 
            // AF_male_check
            // 
            this.AF_male_check.AutoSize = true;
            this.AF_male_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.AF_male_check.Checked = true;
            this.AF_male_check.Location = new System.Drawing.Point(155, 143);
            this.AF_male_check.Name = "AF_male_check";
            this.AF_male_check.Size = new System.Drawing.Size(59, 21);
            this.AF_male_check.TabIndex = 24;
            this.AF_male_check.TabStop = true;
            this.AF_male_check.Text = "Male";
            this.AF_male_check.UseVisualStyleBackColor = false;
            // 
            // AF_female_check
            // 
            this.AF_female_check.AutoSize = true;
            this.AF_female_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(108)))), ((int)(((byte)(136)))));
            this.AF_female_check.Location = new System.Drawing.Point(243, 143);
            this.AF_female_check.Name = "AF_female_check";
            this.AF_female_check.Size = new System.Drawing.Size(75, 21);
            this.AF_female_check.TabIndex = 25;
            this.AF_female_check.Text = "Female";
            this.AF_female_check.UseVisualStyleBackColor = false;
            // 
            // AF_picture_pic
            // 
            this.AF_picture_pic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AF_picture_pic.Image = ((System.Drawing.Image)(resources.GetObject("AF_picture_pic.Image")));
            this.AF_picture_pic.Location = new System.Drawing.Point(128, 268);
            this.AF_picture_pic.Name = "AF_picture_pic";
            this.AF_picture_pic.Size = new System.Drawing.Size(190, 134);
            this.AF_picture_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AF_picture_pic.TabIndex = 19;
            this.AF_picture_pic.TabStop = false;
            this.AF_picture_pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backGround
            // 
            this.backGround.Image = global::classProject.Properties.Resources.UUg;
            this.backGround.Location = new System.Drawing.Point(177, -79);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(729, 631);
            this.backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backGround.TabIndex = 26;
            this.backGround.TabStop = false;
            // 
            // backgourd2
            // 
            this.backgourd2.Image = global::classProject.Properties.Resources.UUg;
            this.backgourd2.Location = new System.Drawing.Point(-551, -66);
            this.backgourd2.Name = "backgourd2";
            this.backgourd2.Size = new System.Drawing.Size(729, 631);
            this.backgourd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgourd2.TabIndex = 27;
            this.backgourd2.TabStop = false;
            // 
            // addStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 492);
            this.Controls.Add(this.AF_female_check);
            this.Controls.Add(this.AF_male_check);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AF_picture_pic);
            this.Controls.Add(this.AF_address_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AF_dob_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AF_fullname_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AF_phone_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AF_id_txt);
            this.Controls.Add(this.stuLable);
            this.Controls.Add(this.backGround);
            this.Controls.Add(this.backgourd2);
            this.Name = "addStudentForm";
            this.Text = "Add new student";
            this.Load += new System.EventHandler(this.addStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AF_picture_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgourd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stuLable;
        private System.Windows.Forms.TextBox AF_id_txt;
        private System.Windows.Forms.TextBox AF_phone_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AF_fullname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker AF_dob_txt;
        private System.Windows.Forms.TextBox AF_address_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox AF_picture_pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton AF_male_check;
        private System.Windows.Forms.RadioButton AF_female_check;
        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.PictureBox backgourd2;
    }
}