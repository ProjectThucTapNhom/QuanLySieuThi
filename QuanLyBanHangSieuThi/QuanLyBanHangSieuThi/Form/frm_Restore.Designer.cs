namespace QuanLyBanHangSieuThi
{
    partial class frm_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Restore));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(494, 52);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(24, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "...";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(131)))), ((int)(((byte)(66)))));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "Ok";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOk.Iconimage")));
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 20D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(270, 115);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnOk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(106, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Textcolor = System.Drawing.Color.Black;
            this.btnOk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn file sao lưu:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(133, 52);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(355, 23);
            this.txtPath.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnCancel.IconZoom = 20D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(382, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(106, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.Black;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frm_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(530, 209);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnChoose);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Restore";
            this.Load += new System.EventHandler(this.frm_Restore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private System.Windows.Forms.Button btnChoose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}