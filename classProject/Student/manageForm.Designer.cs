
namespace classProject
{
    partial class manageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageForm));
            this.AF_female_check = new System.Windows.Forms.RadioButton();
            this.AF_male_check = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AF_address_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AF_dob_txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AF_fullname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AF_phone_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AF_id_txt = new System.Windows.Forms.TextBox();
            this.fogotPassword = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.AF_picture_pic = new System.Windows.Forms.PictureBox();
            this.listStu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.student11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student11DataSet = new classProject.student11DataSet();
            this.student11TableAdapter = new classProject.student11DataSetTableAdapters.student11TableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AF_picture_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AF_female_check
            // 
            this.AF_female_check.AutoSize = true;
            this.AF_female_check.Location = new System.Drawing.Point(248, 131);
            this.AF_female_check.Name = "AF_female_check";
            this.AF_female_check.Size = new System.Drawing.Size(75, 21);
            this.AF_female_check.TabIndex = 40;
            this.AF_female_check.Text = "Female";
            this.AF_female_check.UseVisualStyleBackColor = true;
            // 
            // AF_male_check
            // 
            this.AF_male_check.AutoSize = true;
            this.AF_male_check.Checked = true;
            this.AF_male_check.Location = new System.Drawing.Point(160, 131);
            this.AF_male_check.Name = "AF_male_check";
            this.AF_male_check.Size = new System.Drawing.Size(59, 21);
            this.AF_male_check.TabIndex = 39;
            this.AF_male_check.TabStop = true;
            this.AF_male_check.Text = "Male";
            this.AF_male_check.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(17, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(17, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Picture:";
            // 
            // AF_address_txt
            // 
            this.AF_address_txt.Location = new System.Drawing.Point(133, 163);
            this.AF_address_txt.Multiline = true;
            this.AF_address_txt.Name = "AF_address_txt";
            this.AF_address_txt.Size = new System.Drawing.Size(190, 87);
            this.AF_address_txt.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Address:";
            // 
            // AF_dob_txt
            // 
            this.AF_dob_txt.CustomFormat = "dd/MM/yyyy";
            this.AF_dob_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AF_dob_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AF_dob_txt.Location = new System.Drawing.Point(133, 96);
            this.AF_dob_txt.Name = "AF_dob_txt";
            this.AF_dob_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AF_dob_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_dob_txt.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "DOB:";
            // 
            // AF_fullname_txt
            // 
            this.AF_fullname_txt.Location = new System.Drawing.Point(133, 40);
            this.AF_fullname_txt.Name = "AF_fullname_txt";
            this.AF_fullname_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_fullname_txt.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Full Name:";
            // 
            // AF_phone_txt
            // 
            this.AF_phone_txt.Location = new System.Drawing.Point(133, 68);
            this.AF_phone_txt.Name = "AF_phone_txt";
            this.AF_phone_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_phone_txt.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Phone Number:";
            // 
            // AF_id_txt
            // 
            this.AF_id_txt.Location = new System.Drawing.Point(133, 12);
            this.AF_id_txt.Name = "AF_id_txt";
            this.AF_id_txt.Size = new System.Drawing.Size(190, 22);
            this.AF_id_txt.TabIndex = 27;
            // 
            // fogotPassword
            // 
            this.fogotPassword.AutoSize = true;
            this.fogotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fogotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fogotPassword.Location = new System.Drawing.Point(17, 12);
            this.fogotPassword.Name = "fogotPassword";
            this.fogotPassword.Size = new System.Drawing.Size(89, 17);
            this.fogotPassword.TabIndex = 26;
            this.fogotPassword.Text = "Student ID:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // AF_picture_pic
            // 
            this.AF_picture_pic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AF_picture_pic.Image = ((System.Drawing.Image)(resources.GetObject("AF_picture_pic.Image")));
            this.AF_picture_pic.Location = new System.Drawing.Point(133, 256);
            this.AF_picture_pic.Name = "AF_picture_pic";
            this.AF_picture_pic.Size = new System.Drawing.Size(190, 134);
            this.AF_picture_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AF_picture_pic.TabIndex = 36;
            this.AF_picture_pic.TabStop = false;
            // 
            // listStu
            // 
            this.listStu.AutoGenerateColumns = false;
            this.listStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.listStu.DataSource = this.student11BindingSource;
            this.listStu.Location = new System.Drawing.Point(359, 40);
            this.listStu.Name = "listStu";
            this.listStu.RowHeadersWidth = 51;
            this.listStu.RowTemplate.Height = 24;
            this.listStu.Size = new System.Drawing.Size(747, 350);
            this.listStu.TabIndex = 41;
            this.listStu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listStu_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 125;
            // 
            // student11BindingSource
            // 
            this.student11BindingSource.DataMember = "student11";
            this.student11BindingSource.DataSource = this.student11DataSetBindingSource;
            // 
            // student11DataSetBindingSource
            // 
            this.student11DataSetBindingSource.DataSource = this.student11DataSet;
            this.student11DataSetBindingSource.Position = 0;
            // 
            // student11DataSet
            // 
            this.student11DataSet.DataSetName = "student11DataSet";
            this.student11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student11TableAdapter
            // 
            this.student11TableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(20, 454);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 45);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Red;
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editButton.Location = new System.Drawing.Point(136, 454);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 45);
            this.editButton.TabIndex = 42;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.LimeGreen;
            this.resetButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(373, 454);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 45);
            this.resetButton.TabIndex = 45;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeButton.Location = new System.Drawing.Point(257, 454);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(90, 45);
            this.removeButton.TabIndex = 44;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(450, 12);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(572, 22);
            this.search_txt.TabIndex = 46;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1031, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 48;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // manageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 517);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.listStu);
            this.Controls.Add(this.AF_female_check);
            this.Controls.Add(this.AF_male_check);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.fogotPassword);
            this.Name = "manageForm";
            this.Text = "manageForm";
            this.Load += new System.EventHandler(this.manageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AF_picture_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AF_female_check;
        private System.Windows.Forms.RadioButton AF_male_check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox AF_picture_pic;
        private System.Windows.Forms.TextBox AF_address_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker AF_dob_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AF_fullname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AF_phone_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AF_id_txt;
        private System.Windows.Forms.Label fogotPassword;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridView listStu;
        private System.Windows.Forms.BindingSource student11DataSetBindingSource;
        private student11DataSet student11DataSet;
        private System.Windows.Forms.BindingSource student11BindingSource;
        private student11DataSetTableAdapters.student11TableAdapter student11TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search_button;
    }
}