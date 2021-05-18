
namespace classProject
{
    partial class removeScoreForm
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
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.removeScore_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.removeScore_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveScore.Location = new System.Drawing.Point(-32, 424);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(865, 59);
            this.buttonRemoveScore.TabIndex = 23;
            this.buttonRemoveScore.Text = "Remove Score";
            this.buttonRemoveScore.UseVisualStyleBackColor = false;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click_1);
            // 
            // removeScore_dgv
            // 
            this.removeScore_dgv.AllowUserToAddRows = false;
            this.removeScore_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.removeScore_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeScore_dgv.Location = new System.Drawing.Point(-32, -32);
            this.removeScore_dgv.Name = "removeScore_dgv";
            this.removeScore_dgv.RowHeadersWidth = 51;
            this.removeScore_dgv.RowTemplate.Height = 24;
            this.removeScore_dgv.Size = new System.Drawing.Size(865, 450);
            this.removeScore_dgv.TabIndex = 22;
        
            // 
            // removeScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 491);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.removeScore_dgv);
            this.Name = "removeScoreForm";
            this.Text = "removeScoreForm";
            this.Load += new System.EventHandler(this.removeScoreForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.removeScore_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.DataGridView removeScore_dgv;
    }
}