
namespace classProject
{
    partial class editCForm
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
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseLabel_txt = new System.Windows.Forms.TextBox();
            this.stuLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(317, 86);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(190, 24);
            this.comboBoxCourse.TabIndex = 50;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Select Course:";
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(524, 125);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(75, 23);
            this.find_button.TabIndex = 48;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(317, 156);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(190, 22);
            this.numericUpDownHours.TabIndex = 47;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(361, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 45);
            this.saveButton.TabIndex = 46;
            this.saveButton.Text = "Edit";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(317, 209);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(190, 87);
            this.description_txt.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(201, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(201, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hours:";
            // 
            // courseLabel_txt
            // 
            this.courseLabel_txt.Location = new System.Drawing.Point(317, 128);
            this.courseLabel_txt.Name = "courseLabel_txt";
            this.courseLabel_txt.Size = new System.Drawing.Size(190, 22);
            this.courseLabel_txt.TabIndex = 42;
            // 
            // stuLable
            // 
            this.stuLable.AutoSize = true;
            this.stuLable.BackColor = System.Drawing.Color.White;
            this.stuLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuLable.ForeColor = System.Drawing.Color.Black;
            this.stuLable.Location = new System.Drawing.Point(201, 128);
            this.stuLable.Name = "stuLable";
            this.stuLable.Size = new System.Drawing.Size(109, 17);
            this.stuLable.TabIndex = 41;
            this.stuLable.Text = "Course Label:";
            // 
            // editCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseLabel_txt);
            this.Controls.Add(this.stuLable);
            this.Name = "editCForm";
            this.Text = "editCForm";
            this.Load += new System.EventHandler(this.editCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseLabel_txt;
        private System.Windows.Forms.Label stuLable;
    }
}