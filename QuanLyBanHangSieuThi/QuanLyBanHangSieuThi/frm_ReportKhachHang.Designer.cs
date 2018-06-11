namespace QuanLyBanHangSieuThi
{
    partial class frm_ReportKhachHang
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
            this.vw_DanhSachKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DanhSachKhachHangTableAdapter = new QuanLyBanHangSieuThi.QLBANHANGDataSetTableAdapters.vw_DanhSachKhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_DanhSachKhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangSieuThi.Report_KhachHang.rdlc";
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
            // vw_DanhSachKhachHangBindingSource
            // 
            this.vw_DanhSachKhachHangBindingSource.DataMember = "vw_DanhSachKhachHang";
            this.vw_DanhSachKhachHangBindingSource.DataSource = this.QLBANHANGDataSet;
            // 
            // vw_DanhSachKhachHangTableAdapter
            // 
            this.vw_DanhSachKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_ReportKhachHang";
            this.Text = "frm_ReportKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ReportKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_DanhSachKhachHangBindingSource;
        private QLBANHANGDataSet QLBANHANGDataSet;
        private QLBANHANGDataSetTableAdapters.vw_DanhSachKhachHangTableAdapter vw_DanhSachKhachHangTableAdapter;
    }
}