namespace classProject
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCouresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECUORSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aDDSCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.staticToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.addNewStudentToolStripMenuItem.Text = "Add new student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.studentListToolStripMenuItem.Text = "Student List";
            this.studentListToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.staticToolStripMenuItem.Text = "Static";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.editRemoveToolStripMenuItem.Text = "Edit/Remove";
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.BackColor = System.Drawing.Color.BlueViolet;
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            this.manageStudentFormToolStripMenuItem.Click += new System.EventHandler(this.manageStudentFormToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCourseToolStripMenuItem,
            this.removeCouresToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.mANAGECUORSEToolStripMenuItem,
            this.pRINTToolStripMenuItem1});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addNewCourseToolStripMenuItem
            // 
            this.addNewCourseToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            this.addNewCourseToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.addNewCourseToolStripMenuItem.Text = "Add New Course ";
            this.addNewCourseToolStripMenuItem.Click += new System.EventHandler(this.addNewCourseToolStripMenuItem_Click);
            // 
            // removeCouresToolStripMenuItem
            // 
            this.removeCouresToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.removeCouresToolStripMenuItem.Name = "removeCouresToolStripMenuItem";
            this.removeCouresToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.removeCouresToolStripMenuItem.Text = "Remove Course";
            this.removeCouresToolStripMenuItem.Click += new System.EventHandler(this.removeCouresToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // mANAGECUORSEToolStripMenuItem
            // 
            this.mANAGECUORSEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mANAGECUORSEToolStripMenuItem.Name = "mANAGECUORSEToolStripMenuItem";
            this.mANAGECUORSEToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.mANAGECUORSEToolStripMenuItem.Text = "MANAGE COURSE";
            this.mANAGECUORSEToolStripMenuItem.Click += new System.EventHandler(this.mANAGECUORSEToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDSCOREToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.aVGScoreByCourseToolStripMenuItem,
            this.printToolStripMenuItem2});
            this.scoreToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(93, 30);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // pRINTToolStripMenuItem1
            // 
            this.pRINTToolStripMenuItem1.BackColor = System.Drawing.Color.Orange;
            this.pRINTToolStripMenuItem1.Name = "pRINTToolStripMenuItem1";
            this.pRINTToolStripMenuItem1.Size = new System.Drawing.Size(288, 30);
            this.pRINTToolStripMenuItem1.Text = "PRINT ";
            this.pRINTToolStripMenuItem1.Click += new System.EventHandler(this.pRINTToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::classProject.Properties.Resources.RfmR;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // aDDSCOREToolStripMenuItem
            // 
            this.aDDSCOREToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aDDSCOREToolStripMenuItem.Name = "aDDSCOREToolStripMenuItem";
            this.aDDSCOREToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.aDDSCOREToolStripMenuItem.Text = "ADD SCORE";
            this.aDDSCOREToolStripMenuItem.Click += new System.EventHandler(this.aDDSCOREToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // aVGScoreByCourseToolStripMenuItem
            // 
            this.aVGScoreByCourseToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aVGScoreByCourseToolStripMenuItem.Name = "aVGScoreByCourseToolStripMenuItem";
            this.aVGScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.aVGScoreByCourseToolStripMenuItem.Text = "AVG score by course";
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(333, 30);
            this.printToolStripMenuItem2.Text = "print";
            this.printToolStripMenuItem2.Click += new System.EventHandler(this.printToolStripMenuItem2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "student management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addNewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCouresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGECUORSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aDDSCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVGScoreByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem2;
    }
}