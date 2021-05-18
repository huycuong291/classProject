
namespace classProject
{
    partial class removeCform
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
            this.remove_button = new System.Windows.Forms.Button();
            this.CN_txt = new System.Windows.Forms.TextBox();
            this.label_addCN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(640, 77);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(93, 48);
            this.remove_button.TabIndex = 6;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // CN_txt
            // 
            this.CN_txt.Location = new System.Drawing.Point(328, 87);
            this.CN_txt.Name = "CN_txt";
            this.CN_txt.Size = new System.Drawing.Size(306, 22);
            this.CN_txt.TabIndex = 5;
            this.CN_txt.TextChanged += new System.EventHandler(this.CN_txt_TextChanged);
            // 
            // label_addCN
            // 
            this.label_addCN.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label_addCN.AutoSize = true;
            this.label_addCN.BackColor = System.Drawing.Color.Transparent;
            this.label_addCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_addCN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addCN.ForeColor = System.Drawing.Color.Maroon;
            this.label_addCN.Location = new System.Drawing.Point(104, 87);
            this.label_addCN.Name = "label_addCN";
            this.label_addCN.Size = new System.Drawing.Size(203, 25);
            this.label_addCN.TabIndex = 4;
            this.label_addCN.Text = "Enter course name:";
            this.label_addCN.Click += new System.EventHandler(this.label_addCN_Click);
            // 
            // removeCform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.CN_txt);
            this.Controls.Add(this.label_addCN);
            this.Name = "removeCform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.TextBox CN_txt;
        private System.Windows.Forms.Label label_addCN;
    }
}