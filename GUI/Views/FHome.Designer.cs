namespace GUI.Views
{
    partial class FHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_qlsv = new System.Windows.Forms.Button();
            this.btn_qlp = new System.Windows.Forms.Button();
            this.btn_qlhd = new System.Windows.Forms.Button();
            this.btn_qltb = new System.Windows.Forms.Button();
            this.btn_qlnv = new System.Windows.Forms.Button();
            this.btn_bctk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // btn_qlsv
            // 
            this.btn_qlsv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_qlsv.Location = new System.Drawing.Point(12, 50);
            this.btn_qlsv.Name = "btn_qlsv";
            this.btn_qlsv.Size = new System.Drawing.Size(148, 42);
            this.btn_qlsv.TabIndex = 1;
            this.btn_qlsv.Text = "QUẢN LÝ SINH VIÊN";
            this.btn_qlsv.UseVisualStyleBackColor = true;
            this.btn_qlsv.Click += new System.EventHandler(this.btn_qlsv_Click);
            // 
            // btn_qlp
            // 
            this.btn_qlp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_qlp.Location = new System.Drawing.Point(12, 115);
            this.btn_qlp.Name = "btn_qlp";
            this.btn_qlp.Size = new System.Drawing.Size(148, 42);
            this.btn_qlp.TabIndex = 1;
            this.btn_qlp.Text = "QUẢN LÝ PHÒNG";
            this.btn_qlp.UseVisualStyleBackColor = true;
            this.btn_qlp.Click += new System.EventHandler(this.btn_qlp_Click);
            // 
            // btn_qlhd
            // 
            this.btn_qlhd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_qlhd.Location = new System.Drawing.Point(12, 182);
            this.btn_qlhd.Name = "btn_qlhd";
            this.btn_qlhd.Size = new System.Drawing.Size(148, 42);
            this.btn_qlhd.TabIndex = 1;
            this.btn_qlhd.Text = "QUẢN LÝ HÓA ĐƠN";
            this.btn_qlhd.UseVisualStyleBackColor = true;
            this.btn_qlhd.Click += new System.EventHandler(this.btn_qlhd_Click);
            // 
            // btn_qltb
            // 
            this.btn_qltb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_qltb.Location = new System.Drawing.Point(12, 253);
            this.btn_qltb.Name = "btn_qltb";
            this.btn_qltb.Size = new System.Drawing.Size(148, 42);
            this.btn_qltb.TabIndex = 1;
            this.btn_qltb.Text = "QUẢN LÝ THIẾT BỊ";
            this.btn_qltb.UseVisualStyleBackColor = true;
            this.btn_qltb.Click += new System.EventHandler(this.btn_qltb_Click);
            // 
            // btn_qlnv
            // 
            this.btn_qlnv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_qlnv.Location = new System.Drawing.Point(12, 320);
            this.btn_qlnv.Name = "btn_qlnv";
            this.btn_qlnv.Size = new System.Drawing.Size(148, 42);
            this.btn_qlnv.TabIndex = 1;
            this.btn_qlnv.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btn_qlnv.UseVisualStyleBackColor = true;
            this.btn_qlnv.Click += new System.EventHandler(this.btn_qlnv_Click);
            // 
            // btn_bctk
            // 
            this.btn_bctk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_bctk.Location = new System.Drawing.Point(12, 387);
            this.btn_bctk.Name = "btn_bctk";
            this.btn_bctk.Size = new System.Drawing.Size(148, 42);
            this.btn_bctk.TabIndex = 1;
            this.btn_bctk.Text = "BÁO CÁO - THỐNG KÊ";
            this.btn_bctk.UseVisualStyleBackColor = true;
            this.btn_bctk.Click += new System.EventHandler(this.btn_bctk_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(183, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 540);
            this.panel1.TabIndex = 2;
            // 
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_bctk);
            this.Controls.Add(this.btn_qlnv);
            this.Controls.Add(this.btn_qltb);
            this.Controls.Add(this.btn_qlhd);
            this.Controls.Add(this.btn_qlp);
            this.Controls.Add(this.btn_qlsv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button btn_qlsv;
        private System.Windows.Forms.Button btn_qlp;
        private System.Windows.Forms.Button btn_qlhd;
        private System.Windows.Forms.Button btn_qltb;
        private System.Windows.Forms.Button btn_qlnv;
        private System.Windows.Forms.Button btn_bctk;
        private System.Windows.Forms.Panel panel1;
    }
}