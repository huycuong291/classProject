
namespace classProject
{
    partial class printCourseForm
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
            this.printC_dgv = new System.Windows.Forms.DataGridView();
            this.saveToTxt = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printC_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // printC_dgv
            // 
            this.printC_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printC_dgv.Location = new System.Drawing.Point(0, 0);
            this.printC_dgv.Name = "printC_dgv";
            this.printC_dgv.RowHeadersWidth = 51;
            this.printC_dgv.RowTemplate.Height = 24;
            this.printC_dgv.Size = new System.Drawing.Size(651, 387);
            this.printC_dgv.TabIndex = 0;
            // 
            // saveToTxt
            // 
            this.saveToTxt.Location = new System.Drawing.Point(44, 405);
            this.saveToTxt.Name = "saveToTxt";
            this.saveToTxt.Size = new System.Drawing.Size(178, 72);
            this.saveToTxt.TabIndex = 1;
            this.saveToTxt.Text = "Save To Text File";
            this.saveToTxt.UseVisualStyleBackColor = true;
            this.saveToTxt.Click += new System.EventHandler(this.saveToTxt_Click);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(279, 405);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(178, 72);
            this.print_btn.TabIndex = 1;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // printCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 489);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.saveToTxt);
            this.Controls.Add(this.printC_dgv);
            this.Name = "printCourseForm";
            this.Text = "printCourseForm";
            this.Load += new System.EventHandler(this.printCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printC_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView printC_dgv;
        private System.Windows.Forms.Button saveToTxt;
        private System.Windows.Forms.Button print_btn;
    }
}