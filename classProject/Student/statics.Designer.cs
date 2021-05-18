
namespace classProject
{
    partial class statics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.maleLable = new System.Windows.Forms.Label();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.student11DataSet = new classProject.student11DataSet();
            this.student11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Female = new System.Windows.Forms.Label();
            this.PanelTotal.SuspendLayout();
            this.PanelMale.SuspendLayout();
            this.PanelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTotal
            // 
            this.PanelTotal.BackColor = System.Drawing.Color.Cyan;
            this.PanelTotal.Controls.Add(this.LabelTotal);
            this.PanelTotal.Location = new System.Drawing.Point(2, 0);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(567, 162);
            this.PanelTotal.TabIndex = 0;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelTotal.Location = new System.Drawing.Point(75, 53);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(113, 44);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total";
            // 
            // maleLable
            // 
            this.maleLable.AutoSize = true;
            this.maleLable.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleLable.ForeColor = System.Drawing.Color.FloralWhite;
            this.maleLable.Location = new System.Drawing.Point(3, 66);
            this.maleLable.Name = "maleLable";
            this.maleLable.Size = new System.Drawing.Size(91, 40);
            this.maleLable.TabIndex = 1;
            this.maleLable.Text = "Male";
            // 
            // PanelMale
            // 
            this.PanelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelMale.Controls.Add(this.maleLable);
            this.PanelMale.Location = new System.Drawing.Point(2, 168);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(268, 163);
            this.PanelMale.TabIndex = 2;
            // 
            // PanelFemale
            // 
            this.PanelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelFemale.Controls.Add(this.Female);
            this.PanelFemale.Location = new System.Drawing.Point(276, 168);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(293, 163);
            this.PanelFemale.TabIndex = 2;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.DataSource = this.student11DataSetBindingSource;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(575, 0);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(318, 331);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // student11DataSet
            // 
            this.student11DataSet.DataSetName = "student11DataSet";
            this.student11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student11DataSetBindingSource
            // 
            this.student11DataSetBindingSource.DataSource = this.student11DataSet;
            this.student11DataSetBindingSource.Position = 0;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.FloralWhite;
            this.Female.Location = new System.Drawing.Point(15, 66);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(123, 40);
            this.Female.TabIndex = 1;
            this.Female.Text = "Female";
            // 
            // statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 337);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.PanelTotal);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.PanelMale);
            this.Name = "statics";
            this.Text = "statics";
            this.Load += new System.EventHandler(this.statics_Load);
            this.PanelTotal.ResumeLayout(false);
            this.PanelTotal.PerformLayout();
            this.PanelMale.ResumeLayout(false);
            this.PanelMale.PerformLayout();
            this.PanelFemale.ResumeLayout(false);
            this.PanelFemale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student11DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label maleLable;
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource student11DataSetBindingSource;
        private student11DataSet student11DataSet;
        private System.Windows.Forms.Label Female;
    }
}