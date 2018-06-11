namespace QuanLyBanHangSieuThi
{
    partial class frm_ReportNhaSanXuat
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
            this.QLBANHANGDataSet = new QuanLyBanHangSieuThi.QLBANHANGDataSet();
            this.vw_DanhSachNhaSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DanhSachNhaSanXuatTableAdapter = new QuanLyBanHangSieuThi.QLBANHANGDataSetTableAdapters.vw_DanhSachNhaSanXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachNhaSanXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_DanhSachNhaSanXuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangSieuThi.Report_NhaSanXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBANHANGDataSet
            // 
            this.QLBANHANGDataSet.DataSetName = "QLBANHANGDataSet";
            this.QLBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DanhSachNhaSanXuatBindingSource
            // 
            this.vw_DanhSachNhaSanXuatBindingSource.DataMember = "vw_DanhSachNhaSanXuat";
            this.vw_DanhSachNhaSanXuatBindingSource.DataSource = this.QLBANHANGDataSet;
            // 
            // vw_DanhSachNhaSanXuatTableAdapter
            // 
            this.vw_DanhSachNhaSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_ReportNhaSanXuat";
            this.Text = "frm_ReportNhaSanXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ReportNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachNhaSanXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_DanhSachNhaSanXuatBindingSource;
        private QLBANHANGDataSet QLBANHANGDataSet;
        private QLBANHANGDataSetTableAdapters.vw_DanhSachNhaSanXuatTableAdapter vw_DanhSachNhaSanXuatTableAdapter;
    }
}