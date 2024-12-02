
namespace BTL_QLNhaTro
{
    partial class frmChiTietPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTaiSanPhong = new System.Windows.Forms.DataGridView();
            this.clTenTaiSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToaNha = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNguoiThue = new System.Windows.Forms.DataGridView();
            this.btnTaiSan = new System.Windows.Forms.Button();
            this.btnNguoiThue = new System.Windows.Forms.Button();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiSanPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTaiSanPhong);
            this.groupBox1.Location = new System.Drawing.Point(24, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài sản phòng";
            // 
            // dgvTaiSanPhong
            // 
            this.dgvTaiSanPhong.AllowUserToAddRows = false;
            this.dgvTaiSanPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiSanPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTaiSanPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiSanPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiSanPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTenTaiSan,
            this.clSoLuong,
            this.clTinhTrang,
            this.clViTri});
            this.dgvTaiSanPhong.Location = new System.Drawing.Point(6, 19);
            this.dgvTaiSanPhong.Name = "dgvTaiSanPhong";
            this.dgvTaiSanPhong.ReadOnly = true;
            this.dgvTaiSanPhong.Size = new System.Drawing.Size(720, 119);
            this.dgvTaiSanPhong.TabIndex = 0;
            // 
            // clTenTaiSan
            // 
            this.clTenTaiSan.DataPropertyName = "sTenTaiSan";
            this.clTenTaiSan.HeaderText = "Tên tài sản";
            this.clTenTaiSan.Name = "clTenTaiSan";
            this.clTenTaiSan.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "iSoLuong";
            this.clSoLuong.HeaderText = "Số lương";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "sTinhTrang";
            this.clTinhTrang.HeaderText = "Tình trang";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.ReadOnly = true;
            // 
            // clViTri
            // 
            this.clViTri.DataPropertyName = "sViTri";
            this.clViTri.HeaderText = "Vị trí";
            this.clViTri.Name = "clViTri";
            this.clViTri.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tào nhà: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tầng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Diện tích: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số người tối đa: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tình trạng: ";
            // 
            // txtToaNha
            // 
            this.txtToaNha.Location = new System.Drawing.Point(217, 61);
            this.txtToaNha.Name = "txtToaNha";
            this.txtToaNha.ReadOnly = true;
            this.txtToaNha.Size = new System.Drawing.Size(100, 20);
            this.txtToaNha.TabIndex = 7;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(217, 90);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(100, 20);
            this.txtPhong.TabIndex = 8;
            // 
            // txtTang
            // 
            this.txtTang.Location = new System.Drawing.Point(217, 119);
            this.txtTang.Name = "txtTang";
            this.txtTang.ReadOnly = true;
            this.txtTang.Size = new System.Drawing.Size(100, 20);
            this.txtTang.TabIndex = 9;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(539, 58);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(100, 20);
            this.txtTinhTrang.TabIndex = 10;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(539, 89);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(100, 20);
            this.txtDienTich.TabIndex = 11;
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(539, 120);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.ReadOnly = true;
            this.txtSoNguoi.Size = new System.Drawing.Size(100, 20);
            this.txtSoNguoi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chi tiết phòng trọ";
            // 
            // txtTienThue
            // 
            this.txtTienThue.Location = new System.Drawing.Point(217, 149);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.ReadOnly = true;
            this.txtTienThue.Size = new System.Drawing.Size(100, 20);
            this.txtTienThue.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tiên thuê: ";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(443, 159);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(123, 23);
            this.btnThemKH.TabIndex = 16;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNguoiThue);
            this.groupBox2.Location = new System.Drawing.Point(24, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người thuê";
            this.groupBox2.Visible = false;
            // 
            // dgvNguoiThue
            // 
            this.dgvNguoiThue.AllowUserToAddRows = false;
            this.dgvNguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiThue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHoTen,
            this.clGioiTinh,
            this.clNgaySinh,
            this.clSDT,
            this.clEmail,
            this.clMa});
            this.dgvNguoiThue.Location = new System.Drawing.Point(6, 19);
            this.dgvNguoiThue.Name = "dgvNguoiThue";
            this.dgvNguoiThue.ReadOnly = true;
            this.dgvNguoiThue.Size = new System.Drawing.Size(720, 119);
            this.dgvNguoiThue.TabIndex = 0;
            // 
            // btnTaiSan
            // 
            this.btnTaiSan.Location = new System.Drawing.Point(93, 188);
            this.btnTaiSan.Name = "btnTaiSan";
            this.btnTaiSan.Size = new System.Drawing.Size(108, 23);
            this.btnTaiSan.TabIndex = 16;
            this.btnTaiSan.Text = "Xem Tài Sản";
            this.btnTaiSan.UseVisualStyleBackColor = true;
            this.btnTaiSan.Click += new System.EventHandler(this.btnTaiSan_Click);
            // 
            // btnNguoiThue
            // 
            this.btnNguoiThue.Location = new System.Drawing.Point(625, 188);
            this.btnNguoiThue.Name = "btnNguoiThue";
            this.btnNguoiThue.Size = new System.Drawing.Size(108, 23);
            this.btnNguoiThue.TabIndex = 17;
            this.btnNguoiThue.Text = "Xem Người Thuê";
            this.btnNguoiThue.UseVisualStyleBackColor = true;
            this.btnNguoiThue.Click += new System.EventHandler(this.btnNguoiThue_Click);
            // 
            // clHoTen
            // 
            this.clHoTen.DataPropertyName = "sHoTen";
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.DataPropertyName = "bGT";
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.ReadOnly = true;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.DataPropertyName = "dNgaySinh";
            this.clNgaySinh.HeaderText = "Ngày Sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.ReadOnly = true;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "sSDT";
            this.clSDT.HeaderText = "SĐT";
            this.clSDT.Name = "clSDT";
            this.clSDT.ReadOnly = true;
            // 
            // clEmail
            // 
            this.clEmail.DataPropertyName = "sEmail";
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            this.clEmail.ReadOnly = true;
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "PK_Id";
            this.clMa.HeaderText = "Ma";
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            this.clMa.Visible = false;
            // 
            // frmChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnNguoiThue);
            this.Controls.Add(this.btnTaiSan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTienThue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoNguoi);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtTang);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtToaNha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietPhong";
            this.Text = "frmChiTietPhong";
            this.Load += new System.EventHandler(this.frmCTHB_Ban_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiSanPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTaiSanPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToaNha;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTaiSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clViTri;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNguoiThue;
        private System.Windows.Forms.Button btnTaiSan;
        private System.Windows.Forms.Button btnNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
    }
}