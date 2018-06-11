namespace QuanLyBanHangSieuThi
{
    partial class frm_ReportDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportDonDatHang));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBANHANGDataSet = new QuanLyBanHangSieuThi.QLBANHANGDataSet();
            this.vw_DanhSachDonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DanhSachDonDatHangTableAdapter = new QuanLyBanHangSieuThi.QLBANHANGDataSetTableAdapters.vw_DanhSachDonDatHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachDonDatHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(333, 152);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Ok";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(422, 152);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Ok";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Permission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname:";
            // 
            // txtPermission
            // 
            this.txtPermission.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermission.Location = new System.Drawing.Point(207, 114);
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Size = new System.Drawing.Size(296, 23);
            this.txtPermission.TabIndex = 0;
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(207, 85);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(296, 23);
            this.txtFullname.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(207, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 23);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(207, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(296, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_DanhSachDonDatHangBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyBanHangSieuThi.Report_DonDatHang.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(933, 519);
            this.reportViewer2.TabIndex = 0;
            // 
            // QLBANHANGDataSet
            // 
            this.QLBANHANGDataSet.DataSetName = "QLBANHANGDataSet";
            this.QLBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DanhSachDonDatHangBindingSource
            // 
            this.vw_DanhSachDonDatHangBindingSource.DataMember = "vw_DanhSachDonDatHang";
            this.vw_DanhSachDonDatHangBindingSource.DataSource = this.QLBANHANGDataSet;
            // 
            // vw_DanhSachDonDatHangTableAdapter
            // 
            this.vw_DanhSachDonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // frm_DonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.reportViewer2);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_DonDatHang";
            this.Text = "frm_DonDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachDonDatHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource vw_DanhSachDonDatHangBindingSource;
        private QLBANHANGDataSet QLBANHANGDataSet;
        private QLBANHANGDataSetTableAdapters.vw_DanhSachDonDatHangTableAdapter vw_DanhSachDonDatHangTableAdapter;
    }
}