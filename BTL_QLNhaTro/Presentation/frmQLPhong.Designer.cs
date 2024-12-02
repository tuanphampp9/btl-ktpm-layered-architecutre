
namespace BTL_QLNhaTro
{
    partial class frmQLPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbxToaNha = new System.Windows.Forms.ComboBox();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.clMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clToaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clMaChuToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eprQLPhong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprQLPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(869, 245);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 36);
            this.btnTim.TabIndex = 82;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(627, 245);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 36);
            this.btnLamMoi.TabIndex = 81;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(140, 245);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 36);
            this.btnSua.TabIndex = 79;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(391, 245);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 36);
            this.btnThem.TabIndex = 78;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Quản lý phòng trọ";
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "Đã thuê",
            "Còn trống"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(711, 110);
            this.cbxTinhTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(160, 24);
            this.cbxTinhTrang.TabIndex = 76;
            // 
            // cbxToaNha
            // 
            this.cbxToaNha.FormattingEnabled = true;
            this.cbxToaNha.Location = new System.Drawing.Point(711, 76);
            this.cbxToaNha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxToaNha.Name = "cbxToaNha";
            this.cbxToaNha.Size = new System.Drawing.Size(160, 24);
            this.cbxToaNha.TabIndex = 75;
            // 
            // txtTienThue
            // 
            this.txtTienThue.Location = new System.Drawing.Point(288, 192);
            this.txtTienThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Size = new System.Drawing.Size(132, 22);
            this.txtTienThue.TabIndex = 74;
            this.txtTienThue.TextChanged += new System.EventHandler(this.txtTienThue_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Tiên thuê: ";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(711, 186);
            this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(132, 22);
            this.txtSoNguoi.TabIndex = 72;
            this.txtSoNguoi.TextChanged += new System.EventHandler(this.txtSoNguoi_TextChanged);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(711, 148);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(132, 22);
            this.txtDienTich.TabIndex = 71;
            this.txtDienTich.TextChanged += new System.EventHandler(this.txtDienTich_TextChanged);
            // 
            // txtTang
            // 
            this.txtTang.Location = new System.Drawing.Point(288, 155);
            this.txtTang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(132, 22);
            this.txtTang.TabIndex = 70;
            this.txtTang.TextChanged += new System.EventHandler(this.txtTang_TextChanged);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(288, 119);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(132, 22);
            this.txtPhong.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Tình trạng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Số người tối đa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Diện tích: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tầng: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Phòng: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tào nhà: ";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhong,
            this.clTenPhong,
            this.clToaNha,
            this.clTang,
            this.clTienThu,
            this.clDienTich,
            this.clSoNguoiToiDa,
            this.clTinhTrang,
            this.clChiTiet,
            this.clMaChuToa});
            this.dgvPhong.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPhong.Location = new System.Drawing.Point(16, 309);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(1035, 215);
            this.dgvPhong.TabIndex = 62;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // clMaPhong
            // 
            this.clMaPhong.DataPropertyName = "PK_MaPhong";
            this.clMaPhong.FillWeight = 80F;
            this.clMaPhong.HeaderText = "Mã Phòng";
            this.clMaPhong.MinimumWidth = 6;
            this.clMaPhong.Name = "clMaPhong";
            this.clMaPhong.ReadOnly = true;
            // 
            // clTenPhong
            // 
            this.clTenPhong.DataPropertyName = "sTenPhong";
            this.clTenPhong.HeaderText = "Tên phòng";
            this.clTenPhong.MinimumWidth = 6;
            this.clTenPhong.Name = "clTenPhong";
            this.clTenPhong.ReadOnly = true;
            // 
            // clToaNha
            // 
            this.clToaNha.DataPropertyName = "sTenToa";
            this.clToaNha.HeaderText = "Toà nhà";
            this.clToaNha.MinimumWidth = 6;
            this.clToaNha.Name = "clToaNha";
            this.clToaNha.ReadOnly = true;
            // 
            // clTang
            // 
            this.clTang.DataPropertyName = "iTang";
            this.clTang.FillWeight = 60F;
            this.clTang.HeaderText = "Tầng";
            this.clTang.MinimumWidth = 6;
            this.clTang.Name = "clTang";
            this.clTang.ReadOnly = true;
            // 
            // clTienThu
            // 
            this.clTienThu.DataPropertyName = "fTienThu";
            this.clTienThu.HeaderText = "Tiên thu";
            this.clTienThu.MinimumWidth = 6;
            this.clTienThu.Name = "clTienThu";
            this.clTienThu.ReadOnly = true;
            // 
            // clDienTich
            // 
            this.clDienTich.DataPropertyName = "fDienTich";
            this.clDienTich.FillWeight = 70F;
            this.clDienTich.HeaderText = "Diện tích";
            this.clDienTich.MinimumWidth = 6;
            this.clDienTich.Name = "clDienTich";
            this.clDienTich.ReadOnly = true;
            // 
            // clSoNguoiToiDa
            // 
            this.clSoNguoiToiDa.DataPropertyName = "iSoNguoiToiDa";
            this.clSoNguoiToiDa.HeaderText = "Số người tối đa";
            this.clSoNguoiToiDa.MinimumWidth = 6;
            this.clSoNguoiToiDa.Name = "clSoNguoiToiDa";
            this.clSoNguoiToiDa.ReadOnly = true;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "sTinhTrang";
            this.clTinhTrang.HeaderText = "Tình trạng";
            this.clTinhTrang.MinimumWidth = 6;
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.ReadOnly = true;
            // 
            // clChiTiet
            // 
            this.clChiTiet.FillWeight = 60F;
            this.clChiTiet.HeaderText = "Chi tiết";
            this.clChiTiet.MinimumWidth = 6;
            this.clChiTiet.Name = "clChiTiet";
            this.clChiTiet.ReadOnly = true;
            this.clChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clChiTiet.Text = "Xem";
            // 
            // clMaChuToa
            // 
            this.clMaChuToa.DataPropertyName = "FK_User_id";
            this.clMaChuToa.HeaderText = "MaChuToa";
            this.clMaChuToa.MinimumWidth = 6;
            this.clMaChuToa.Name = "clMaChuToa";
            this.clMaChuToa.ReadOnly = true;
            this.clMaChuToa.Visible = false;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(288, 80);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(132, 22);
            this.txtMaPhong.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Mã phòng: ";
            // 
            // eprQLPhong
            // 
            this.eprQLPhong.ContainerControl = this;
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTinhTrang);
            this.Controls.Add(this.cbxToaNha);
            this.Controls.Add(this.txtTienThue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoNguoi);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPhong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLPhong";
            this.Text = "frmQLPhong";
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprQLPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.ComboBox cbxToaNha;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clToaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewButtonColumn clChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaChuToa;
        private System.Windows.Forms.ErrorProvider eprQLPhong;
    }
}