
namespace classProject
{
    partial class listStuform
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
            this.refesh_Button = new System.Windows.Forms.Button();
            this.listStu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.student11BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student11DataSet1 = new classProject.student11DataSet1();
            this.student11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student11DataSet = new classProject.student11DataSet();
            this.student11TableAdapter = new classProject.student11DataSetTableAdapters.student11TableAdapter();
            this.student11TableAdapter1 = new classProject.student11DataSet1TableAdapters.student11TableAdapter();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refesh_Button
            // 
            this.refesh_Button.Location = new System.Drawing.Point(470, 327);
            this.refesh_Button.Name = "refesh_Button";
            this.refesh_Button.Size = new System.Drawing.Size(198, 67);
            this.refesh_Button.TabIndex = 1;
            this.refesh_Button.Text = "refesh";
            this.refesh_Button.UseVisualStyleBackColor = true;
            this.refesh_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // listStu
            // 
            this.listStu.AutoGenerateColumns = false;
            this.listStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.listStu.DataSource = this.student11BindingSource1;
            this.listStu.Location = new System.Drawing.Point(0, 0);
            this.listStu.Name = "listStu";
            this.listStu.RowHeadersWidth = 51;
            this.listStu.RowTemplate.Height = 24;
            this.listStu.Size = new System.Drawing.Size(1141, 295);
            this.listStu.TabIndex = 2;
            this.listStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listStu_CellContentClick);
            this.listStu.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fullname";
            this.dataGridViewTextBoxColumn2.HeaderText = "fullname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dob";
            this.dataGridViewTextBoxColumn3.HeaderText = "dob";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "gender";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "picture";
            this.dataGridViewImageColumn1.HeaderText = "picture";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // student11BindingSource1
            // 
            this.student11BindingSource1.DataMember = "student11";
            this.student11BindingSource1.DataSource = this.student11DataSet1;
            // 
            // student11DataSet1
            // 
            this.student11DataSet1.DataSetName = "student11DataSet1";
            this.student11DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student11BindingSource
            // 
            this.student11BindingSource.DataMember = "student11";
            this.student11BindingSource.DataSource = this.student11DataSet;
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
            // student11TableAdapter1
            // 
            this.student11TableAdapter1.ClearBeforeFill = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // listStuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 437);
            this.Controls.Add(this.listStu);
            this.Controls.Add(this.refesh_Button);
            this.Name = "listStuform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.listStuform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    
        private System.Windows.Forms.BindingSource tableBindingSource;

        private System.Windows.Forms.BindingSource tableBindingSource1;

        private System.Windows.Forms.BindingSource studentBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button refesh_Button;
        private System.Windows.Forms.DataGridView listStu;
        private student11DataSet student11DataSet;
        private System.Windows.Forms.BindingSource student11BindingSource;
        private student11DataSetTableAdapters.student11TableAdapter student11TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private student11DataSet1 student11DataSet1;
        private System.Windows.Forms.BindingSource student11BindingSource1;
        private student11DataSet1TableAdapters.student11TableAdapter student11TableAdapter1;
    }
}