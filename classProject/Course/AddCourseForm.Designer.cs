
namespace classProject
{
    partial class AddCourseForm
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
            this.description_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseLabel_txt = new System.Windows.Forms.TextBox();
            this.stuLable = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseID = new System.Windows.Forms.TextBox();
            this.cID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(179, 113);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(190, 87);
            this.description_txt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hours:";
            // 
            // courseLabel_txt
            // 
            this.courseLabel_txt.Location = new System.Drawing.Point(179, 32);
            this.courseLabel_txt.Name = "courseLabel_txt";
            this.courseLabel_txt.Size = new System.Drawing.Size(190, 22);
            this.courseLabel_txt.TabIndex = 20;
            this.courseLabel_txt.TextChanged += new System.EventHandler(this.AF_id_txt_TextChanged);
            // 
            // stuLable
            // 
            this.stuLable.AutoSize = true;
            this.stuLable.BackColor = System.Drawing.Color.White;
            this.stuLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuLable.ForeColor = System.Drawing.Color.Black;
            this.stuLable.Location = new System.Drawing.Point(63, 32);
            this.stuLable.Name = "stuLable";
            this.stuLable.Size = new System.Drawing.Size(109, 17);
            this.stuLable.TabIndex = 19;
            this.stuLable.Text = "Course Label:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(257, 225);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 45);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(98, 225);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 45);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(179, 60);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(190, 22);
            this.numericUpDownHours.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::classProject.Properties.Resources.h4p;
            this.pictureBox1.Location = new System.Drawing.Point(88, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // courseID
            // 
            this.courseID.Location = new System.Drawing.Point(179, 4);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(190, 22);
            this.courseID.TabIndex = 30;
            // 
            // cID
            // 
            this.cID.AutoSize = true;
            this.cID.BackColor = System.Drawing.Color.White;
            this.cID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cID.ForeColor = System.Drawing.Color.Black;
            this.cID.Location = new System.Drawing.Point(63, 4);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(84, 17);
            this.cID.TabIndex = 29;
            this.cID.Text = "Course ID:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 295);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.cID);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseLabel_txt);
            this.Controls.Add(this.stuLable);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseLabel_txt;
        private System.Windows.Forms.Label stuLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.TextBox courseID;
        private System.Windows.Forms.Label cID;
    }
}