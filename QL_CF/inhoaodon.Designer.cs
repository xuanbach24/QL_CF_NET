namespace QL_CF
{
    partial class inhoaodon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_QUANCAFEDataSet = new QL_CF.QL_QUANCAFEDataSet();
            this.INHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INHOADONTableAdapter = new QL_CF.QL_QUANCAFEDataSetTableAdapters.INHOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_QUANCAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "data_inhoadon";
            reportDataSource1.Value = this.INHOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CF.inhoadon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(849, 570);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_QUANCAFEDataSet
            // 
            this.QL_QUANCAFEDataSet.DataSetName = "QL_QUANCAFEDataSet";
            this.QL_QUANCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // INHOADONBindingSource
            // 
            this.INHOADONBindingSource.DataMember = "INHOADON";
            this.INHOADONBindingSource.DataSource = this.QL_QUANCAFEDataSet;
            // 
            // INHOADONTableAdapter
            // 
            this.INHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // inhoaodon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 587);
            this.Controls.Add(this.reportViewer1);
            this.Name = "inhoaodon";
            this.Text = "inhoaodon";
            this.Load += new System.EventHandler(this.inhoaodon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_QUANCAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource INHOADONBindingSource;
        private QL_QUANCAFEDataSet QL_QUANCAFEDataSet;
        private QL_QUANCAFEDataSetTableAdapters.INHOADONTableAdapter INHOADONTableAdapter;
    }
}