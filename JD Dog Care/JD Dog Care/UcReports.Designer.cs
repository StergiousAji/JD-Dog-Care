namespace JD_Dog_Care
{
    partial class UcReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JD_Dog_CareDataSet = new JD_Dog_Care.JD_Dog_CareDataSet();
            this.vwJDDogCareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwJDDogCareTableAdapter = new JD_Dog_Care.JD_Dog_CareDataSetTableAdapters.vwJDDogCareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JD_Dog_CareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwJDDogCareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwJDDogCareBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JD_Dog_Care.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(730, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // JD_Dog_CareDataSet
            // 
            this.JD_Dog_CareDataSet.DataSetName = "JD_Dog_CareDataSet";
            this.JD_Dog_CareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwJDDogCareBindingSource
            // 
            this.vwJDDogCareBindingSource.DataMember = "vwJDDogCare";
            this.vwJDDogCareBindingSource.DataSource = this.JD_Dog_CareDataSet;
            // 
            // vwJDDogCareTableAdapter
            // 
            this.vwJDDogCareTableAdapter.ClearBeforeFill = true;
            // 
            // UcReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.reportViewer1);
            this.Name = "UcReports";
            this.Size = new System.Drawing.Size(760, 550);
            ((System.ComponentModel.ISupportInitialize)(this.JD_Dog_CareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwJDDogCareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vwJDDogCareBindingSource;
        private JD_Dog_CareDataSet JD_Dog_CareDataSet;
        private JD_Dog_CareDataSetTableAdapters.vwJDDogCareTableAdapter vwJDDogCareTableAdapter;
    }
}
