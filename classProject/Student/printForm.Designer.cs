
namespace classProject
{
    partial class printForm
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
            this.listPrint = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.student11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student11DataSet2 = new classProject.student11DataSet2();
            this.student11TableAdapter = new classProject.student11DataSet2TableAdapters.student11TableAdapter();
            this.check_Button = new System.Windows.Forms.Button();
            this.saveToTextFile = new System.Windows.Forms.Button();
            this.Male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.all = new System.Windows.Forms.RadioButton();
            this.isDateRange = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.saveToMSW = new System.Windows.Forms.Button();
            this.saveToPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // listPrint
            // 
            this.listPrint.AutoGenerateColumns = false;
            this.listPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.listPrint.DataSource = this.student11BindingSource;
            this.listPrint.Location = new System.Drawing.Point(41, 179);
            this.listPrint.Name = "listPrint";
            this.listPrint.RowHeadersWidth = 51;
            this.listPrint.RowTemplate.Height = 24;
            this.listPrint.Size = new System.Drawing.Size(1148, 295);
            this.listPrint.TabIndex = 3;
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
            this.student11BindingSource.DataSource = this.student11DataSet2;
            // 
            // student11DataSet2
            // 
            this.student11DataSet2.DataSetName = "student11DataSet2";
            this.student11DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student11TableAdapter
            // 
            this.student11TableAdapter.ClearBeforeFill = true;
            // 
            // check_Button
            // 
            this.check_Button.Location = new System.Drawing.Point(881, 59);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(80, 48);
            this.check_Button.TabIndex = 4;
            this.check_Button.Text = "CHECK";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // saveToTextFile
            // 
            this.saveToTextFile.Location = new System.Drawing.Point(41, 496);
            this.saveToTextFile.Name = "saveToTextFile";
            this.saveToTextFile.Size = new System.Drawing.Size(130, 48);
            this.saveToTextFile.TabIndex = 4;
            this.saveToTextFile.Text = "Save To .txt";
            this.saveToTextFile.UseVisualStyleBackColor = true;
            this.saveToTextFile.Click += new System.EventHandler(this.print_Click);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(129, 73);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(59, 21);
            this.Male.TabIndex = 5;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(232, 73);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 5;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Checked = true;
            this.all.Location = new System.Drawing.Point(62, 73);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(44, 21);
            this.all.TabIndex = 5;
            this.all.TabStop = true;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            // 
            // isDateRange
            // 
            this.isDateRange.AutoSize = true;
            this.isDateRange.Location = new System.Drawing.Point(543, 39);
            this.isDateRange.Name = "isDateRange";
            this.isDateRange.Size = new System.Drawing.Size(106, 21);
            this.isDateRange.TabIndex = 6;
            this.isDateRange.Text = "Date Range";
            this.isDateRange.UseVisualStyleBackColor = true;
            this.isDateRange.CheckedChanged += new System.EventHandler(this.isDateRange_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(543, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(543, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // saveToMSW
            // 
            this.saveToMSW.Location = new System.Drawing.Point(192, 496);
            this.saveToMSW.Name = "saveToMSW";
            this.saveToMSW.Size = new System.Drawing.Size(115, 48);
            this.saveToMSW.TabIndex = 8;
            this.saveToMSW.Text = "Save To MS Word";
            this.saveToMSW.UseVisualStyleBackColor = true;
            this.saveToMSW.Click += new System.EventHandler(this.saveToMSW_Click);
            // 
            // saveToPDF
            // 
            this.saveToPDF.Location = new System.Drawing.Point(333, 496);
            this.saveToPDF.Name = "saveToPDF";
            this.saveToPDF.Size = new System.Drawing.Size(98, 48);
            this.saveToPDF.TabIndex = 10;
            this.saveToPDF.Text = "Save To PDF ";
            this.saveToPDF.UseVisualStyleBackColor = true;
            this.saveToPDF.Click += new System.EventHandler(this.saveToPDF_Click);
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 556);
            this.Controls.Add(this.saveToPDF);
            this.Controls.Add(this.saveToMSW);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.isDateRange);
            this.Controls.Add(this.all);
            this.Controls.Add(this.female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.saveToTextFile);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.listPrint);
            this.Name = "printForm";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listPrint;
        private student11DataSet2 student11DataSet2;
        private System.Windows.Forms.BindingSource student11BindingSource;
        private student11DataSet2TableAdapters.student11TableAdapter student11TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button saveToTextFile;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton all;
        private System.Windows.Forms.CheckBox isDateRange;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button saveToMSW;
        private System.Windows.Forms.Button saveToPDF;
    }
}