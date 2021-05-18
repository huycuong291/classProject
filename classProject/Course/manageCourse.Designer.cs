
namespace classProject
{
    partial class manageCourse
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
            this.courseID = new System.Windows.Forms.TextBox();
            this.cID = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseLabel_txt = new System.Windows.Forms.TextBox();
            this.stuLable = new System.Windows.Forms.Label();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.totalCourseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // courseID
            // 
            this.courseID.Location = new System.Drawing.Point(152, 29);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(113, 22);
            this.courseID.TabIndex = 40;
            // 
            // cID
            // 
            this.cID.AutoSize = true;
            this.cID.BackColor = System.Drawing.Color.White;
            this.cID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cID.ForeColor = System.Drawing.Color.Black;
            this.cID.Location = new System.Drawing.Point(36, 29);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(84, 17);
            this.cID.TabIndex = 39;
            this.cID.Text = "Course ID:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(152, 89);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownHours.TabIndex = 38;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(30, 289);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 45);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeButton.Location = new System.Drawing.Point(140, 289);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(90, 45);
            this.removeButton.TabIndex = 36;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(152, 123);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(190, 87);
            this.description_txt.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hours:";
            // 
            // courseLabel_txt
            // 
            this.courseLabel_txt.Location = new System.Drawing.Point(152, 57);
            this.courseLabel_txt.Name = "courseLabel_txt";
            this.courseLabel_txt.Size = new System.Drawing.Size(190, 22);
            this.courseLabel_txt.TabIndex = 32;
            // 
            // stuLable
            // 
            this.stuLable.AutoSize = true;
            this.stuLable.BackColor = System.Drawing.Color.White;
            this.stuLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuLable.ForeColor = System.Drawing.Color.Black;
            this.stuLable.Location = new System.Drawing.Point(36, 57);
            this.stuLable.Name = "stuLable";
            this.stuLable.Size = new System.Drawing.Size(109, 17);
            this.stuLable.TabIndex = 31;
            this.stuLable.Text = "Course Label:";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 23;
            this.listBoxCourse.Location = new System.Drawing.Point(385, 29);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(228, 257);
            this.listBoxCourse.TabIndex = 41;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LimeGreen;
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(252, 289);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 45);
            this.editButton.TabIndex = 42;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstButton.Font = new System.Drawing.Font("Gill Sans MT", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(28, 232);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 35);
            this.firstButton.TabIndex = 43;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.previousButton.Font = new System.Drawing.Font("Gill Sans MT", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(109, 232);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 35);
            this.previousButton.TabIndex = 43;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nextButton.Font = new System.Drawing.Font("Gill Sans MT", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(190, 232);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 35);
            this.nextButton.TabIndex = 43;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.endButton.Font = new System.Drawing.Font("Gill Sans MT", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.Location = new System.Drawing.Point(271, 232);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 35);
            this.endButton.TabIndex = 43;
            this.endButton.Text = "End";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // totalCourseLabel
            // 
            this.totalCourseLabel.AutoSize = true;
            this.totalCourseLabel.BackColor = System.Drawing.Color.Gray;
            this.totalCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCourseLabel.ForeColor = System.Drawing.Color.Black;
            this.totalCourseLabel.Location = new System.Drawing.Point(435, 289);
            this.totalCourseLabel.Name = "totalCourseLabel";
            this.totalCourseLabel.Size = new System.Drawing.Size(144, 25);
            this.totalCourseLabel.TabIndex = 44;
            this.totalCourseLabel.Text = "Total Course:";
            // 
            // manageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 374);
            this.Controls.Add(this.totalCourseLabel);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.courseID);
            this.Controls.Add(this.cID);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseLabel_txt);
            this.Controls.Add(this.stuLable);
            this.Name = "manageCourse";
            this.Text = "manageCourse";
            this.Load += new System.EventHandler(this.manageCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseID;
        private System.Windows.Forms.Label cID;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseLabel_txt;
        private System.Windows.Forms.Label stuLable;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label totalCourseLabel;
    }
}