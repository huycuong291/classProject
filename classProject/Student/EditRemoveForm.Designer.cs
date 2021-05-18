
namespace classProject
{
    partial class EditRemoveForm
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
            this.ER_picture = new System.Windows.Forms.PictureBox();
            this.ER_name = new System.Windows.Forms.Label();
            this.ER_dob = new System.Windows.Forms.Label();
            this.ER_phone = new System.Windows.Forms.Label();
            this.ER_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ER_id_txt = new System.Windows.Forms.TextBox();
            this.ER_name_txt = new System.Windows.Forms.TextBox();
            this.ER_phone_txt = new System.Windows.Forms.TextBox();
            this.ER_address_txt = new System.Windows.Forms.TextBox();
            this.ER_male = new System.Windows.Forms.RadioButton();
            this.ER_female = new System.Windows.Forms.RadioButton();
            this.ER_dob1 = new System.Windows.Forms.DateTimePicker();
            this.uploadPic = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ER_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ER_picture
            // 
            this.ER_picture.Location = new System.Drawing.Point(60, 31);
            this.ER_picture.Name = "ER_picture";
            this.ER_picture.Size = new System.Drawing.Size(270, 249);
            this.ER_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ER_picture.TabIndex = 0;
            this.ER_picture.TabStop = false;
            this.ER_picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ER_name
            // 
            this.ER_name.AutoSize = true;
            this.ER_name.Location = new System.Drawing.Point(360, 61);
            this.ER_name.Name = "ER_name";
            this.ER_name.Size = new System.Drawing.Size(71, 17);
            this.ER_name.TabIndex = 1;
            this.ER_name.Text = "Full Name";
            // 
            // ER_dob
            // 
            this.ER_dob.AutoSize = true;
            this.ER_dob.Location = new System.Drawing.Point(360, 89);
            this.ER_dob.Name = "ER_dob";
            this.ER_dob.Size = new System.Drawing.Size(87, 17);
            this.ER_dob.TabIndex = 1;
            this.ER_dob.Text = "Date of Birth";
            // 
            // ER_phone
            // 
            this.ER_phone.AutoSize = true;
            this.ER_phone.Location = new System.Drawing.Point(360, 119);
            this.ER_phone.Name = "ER_phone";
            this.ER_phone.Size = new System.Drawing.Size(49, 17);
            this.ER_phone.TabIndex = 1;
            this.ER_phone.Text = "Phone";
            // 
            // ER_id
            // 
            this.ER_id.AutoSize = true;
            this.ER_id.Location = new System.Drawing.Point(360, 31);
            this.ER_id.Name = "ER_id";
            this.ER_id.Size = new System.Drawing.Size(21, 17);
            this.ER_id.TabIndex = 1;
            this.ER_id.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // ER_id_txt
            // 
            this.ER_id_txt.Location = new System.Drawing.Point(484, 28);
            this.ER_id_txt.Name = "ER_id_txt";
            this.ER_id_txt.Size = new System.Drawing.Size(208, 22);
            this.ER_id_txt.TabIndex = 2;
            // 
            // ER_name_txt
            // 
            this.ER_name_txt.Location = new System.Drawing.Point(484, 58);
            this.ER_name_txt.Name = "ER_name_txt";
            this.ER_name_txt.Size = new System.Drawing.Size(208, 22);
            this.ER_name_txt.TabIndex = 2;
            // 
            // ER_phone_txt
            // 
            this.ER_phone_txt.Location = new System.Drawing.Point(484, 116);
            this.ER_phone_txt.Name = "ER_phone_txt";
            this.ER_phone_txt.Size = new System.Drawing.Size(208, 22);
            this.ER_phone_txt.TabIndex = 2;
            // 
            // ER_address_txt
            // 
            this.ER_address_txt.Location = new System.Drawing.Point(484, 174);
            this.ER_address_txt.Multiline = true;
            this.ER_address_txt.Name = "ER_address_txt";
            this.ER_address_txt.Size = new System.Drawing.Size(208, 88);
            this.ER_address_txt.TabIndex = 2;
            // 
            // ER_male
            // 
            this.ER_male.AutoSize = true;
            this.ER_male.Checked = true;
            this.ER_male.Location = new System.Drawing.Point(517, 147);
            this.ER_male.Name = "ER_male";
            this.ER_male.Size = new System.Drawing.Size(59, 21);
            this.ER_male.TabIndex = 3;
            this.ER_male.TabStop = true;
            this.ER_male.Text = "Male";
            this.ER_male.UseVisualStyleBackColor = true;
            // 
            // ER_female
            // 
            this.ER_female.AutoSize = true;
            this.ER_female.Location = new System.Drawing.Point(595, 147);
            this.ER_female.Name = "ER_female";
            this.ER_female.Size = new System.Drawing.Size(75, 21);
            this.ER_female.TabIndex = 4;
            this.ER_female.Text = "Female";
            this.ER_female.UseVisualStyleBackColor = true;
            // 
            // ER_dob1
            // 
            this.ER_dob1.CustomFormat = "dd/MM/yyyy";
            this.ER_dob1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ER_dob1.Location = new System.Drawing.Point(484, 86);
            this.ER_dob1.Name = "ER_dob1";
            this.ER_dob1.Size = new System.Drawing.Size(208, 22);
            this.ER_dob1.TabIndex = 5;
            // 
            // uploadPic
            // 
            this.uploadPic.Location = new System.Drawing.Point(154, 302);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(75, 23);
            this.uploadPic.TabIndex = 6;
            this.uploadPic.Text = "Upload";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edit.Location = new System.Drawing.Point(482, 287);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 52);
            this.edit.TabIndex = 8;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Red;
            this.remove.Location = new System.Drawing.Point(600, 287);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(92, 52);
            this.remove.TabIndex = 9;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // EditRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 375);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.ER_dob1);
            this.Controls.Add(this.ER_female);
            this.Controls.Add(this.ER_male);
            this.Controls.Add(this.ER_address_txt);
            this.Controls.Add(this.ER_phone_txt);
            this.Controls.Add(this.ER_name_txt);
            this.Controls.Add(this.ER_id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ER_id);
            this.Controls.Add(this.ER_phone);
            this.Controls.Add(this.ER_dob);
            this.Controls.Add(this.ER_name);
            this.Controls.Add(this.ER_picture);
            this.Name = "EditRemoveForm";
            this.Text = "EditRemoveForm";
            ((System.ComponentModel.ISupportInitialize)(this.ER_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ER_name;
        private System.Windows.Forms.Label ER_dob;
        private System.Windows.Forms.Label ER_phone;
        private System.Windows.Forms.Label ER_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ER_id_txt;
        public System.Windows.Forms.TextBox ER_name_txt;
        public System.Windows.Forms.TextBox ER_phone_txt;
        public System.Windows.Forms.TextBox ER_address_txt;
        public System.Windows.Forms.RadioButton ER_male;
        public System.Windows.Forms.RadioButton ER_female;
        public System.Windows.Forms.DateTimePicker ER_dob1;
        public System.Windows.Forms.PictureBox ER_picture;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button remove;
    }
}