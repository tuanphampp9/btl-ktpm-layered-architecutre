
namespace BTL_QLNhaTro
{
    partial class frmTaiSan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvTaiSan = new System.Windows.Forms.DataGridView();
            this.PK_MaTaiSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenTaiSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.lbSoLuon = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbTenTaiSan = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.cbToaNha = new System.Windows.Forms.ComboBox();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lbToaNha = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.lbViTri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(314, 30);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(154, 20);
            this.lbTitle.TabIndex = 29;
            this.lbTitle.Text = "Dánh sách tài sản";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(514, 186);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgvTaiSan
            // 
            this.dtgvTaiSan.AllowUserToAddRows = false;
            this.dtgvTaiSan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTaiSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaiSan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTaiSan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvTaiSan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTaiSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_MaTaiSan,
            this.sTenTaiSan,
            this.iSoLuong,
            this.sTinhTrang,
            this.sViTri,
            this.sTenToa,
            this.sTenPhong});
            this.dtgvTaiSan.Location = new System.Drawing.Point(34, 228);
            this.dtgvTaiSan.Name = "dtgvTaiSan";
            this.dtgvTaiSan.RowHeadersWidth = 51;
            this.dtgvTaiSan.Size = new System.Drawing.Size(739, 210);
            this.dtgvTaiSan.TabIndex = 27;
            this.dtgvTaiSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTaiSan_CellClick);
            // 
            // PK_MaTaiSan
            // 
            this.PK_MaTaiSan.DataPropertyName = "PK_MaTaiSan";
            this.PK_MaTaiSan.HeaderText = "Mã tài sản";
            this.PK_MaTaiSan.Name = "PK_MaTaiSan";
            // 
            // sTenTaiSan
            // 
            this.sTenTaiSan.DataPropertyName = "sTenTaiSan";
            this.sTenTaiSan.HeaderText = "Tên tài sản";
            this.sTenTaiSan.Name = "sTenTaiSan";
            // 
            // iSoLuong
            // 
            this.iSoLuong.DataPropertyName = "iSoLuong";
            this.iSoLuong.HeaderText = "Số lượng";
            this.iSoLuong.Name = "iSoLuong";
            // 
            // sTinhTrang
            // 
            this.sTinhTrang.DataPropertyName = "sTinhTrang";
            this.sTinhTrang.HeaderText = "Tình trạng";
            this.sTinhTrang.Name = "sTinhTrang";
            // 
            // sViTri
            // 
            this.sViTri.DataPropertyName = "sViTri";
            this.sViTri.HeaderText = "Vị trí";
            this.sViTri.Name = "sViTri";
            // 
            // sTenToa
            // 
            this.sTenToa.DataPropertyName = "sTenToa";
            this.sTenToa.HeaderText = "Tên tòa";
            this.sTenToa.Name = "sTenToa";
            // 
            // sTenPhong
            // 
            this.sTenPhong.DataPropertyName = "sTenPhong";
            this.sTenPhong.HeaderText = "Tên phòng";
            this.sTenPhong.Name = "sTenPhong";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(380, 83);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(57, 20);
            this.txtSoLuong.TabIndex = 26;
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Location = new System.Drawing.Point(118, 83);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(145, 20);
            this.txtTenTaiSan.TabIndex = 25;
            // 
            // lbSoLuon
            // 
            this.lbSoLuon.AutoSize = true;
            this.lbSoLuon.Location = new System.Drawing.Point(311, 86);
            this.lbSoLuon.Name = "lbSoLuon";
            this.lbSoLuon.Size = new System.Drawing.Size(49, 13);
            this.lbSoLuon.TabIndex = 24;
            this.lbSoLuon.Text = "Số lượng";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(661, 186);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 23;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(217, 186);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(70, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbTenTaiSan
            // 
            this.lbTenTaiSan.AutoSize = true;
            this.lbTenTaiSan.Location = new System.Drawing.Point(31, 86);
            this.lbTenTaiSan.Name = "lbTenTaiSan";
            this.lbTenTaiSan.Size = new System.Drawing.Size(60, 13);
            this.lbTenTaiSan.TabIndex = 20;
            this.lbTenTaiSan.Text = "Tên tài sản";
            this.lbTenTaiSan.Click += new System.EventHandler(this.lbBuildingName_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(579, 83);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(145, 20);
            this.txtTinhTrang.TabIndex = 31;
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(492, 86);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(55, 13);
            this.lbTinhTrang.TabIndex = 30;
            this.lbTinhTrang.Text = "Tình trạng";
            this.lbTinhTrang.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(365, 132);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(103, 21);
            this.cbPhong.TabIndex = 32;
            // 
            // cbToaNha
            // 
            this.cbToaNha.FormattingEnabled = true;
            this.cbToaNha.Location = new System.Drawing.Point(118, 132);
            this.cbToaNha.Name = "cbToaNha";
            this.cbToaNha.Size = new System.Drawing.Size(121, 21);
            this.cbToaNha.TabIndex = 33;
            this.cbToaNha.SelectionChangeCommitted += new System.EventHandler(this.cbToaNha_SelectionChangeCommitted);
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(311, 135);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(38, 13);
            this.lbPhong.TabIndex = 34;
            this.lbPhong.Text = "Phòng";
            // 
            // lbToaNha
            // 
            this.lbToaNha.AutoSize = true;
            this.lbToaNha.Location = new System.Drawing.Point(42, 135);
            this.lbToaNha.Name = "lbToaNha";
            this.lbToaNha.Size = new System.Drawing.Size(47, 13);
            this.lbToaNha.TabIndex = 35;
            this.lbToaNha.Text = "Tòa nhà";
            this.lbToaNha.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(579, 133);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(145, 20);
            this.txtViTri.TabIndex = 37;
            this.txtViTri.TextChanged += new System.EventHandler(this.txtViTri_TextChanged);
            // 
            // lbViTri
            // 
            this.lbViTri.AutoSize = true;
            this.lbViTri.Location = new System.Drawing.Point(492, 136);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(29, 13);
            this.lbViTri.TabIndex = 36;
            this.lbViTri.Text = "Vị trí";
            // 
            // frmTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.lbViTri);
            this.Controls.Add(this.lbToaNha);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.cbToaNha);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtgvTaiSan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenTaiSan);
            this.Controls.Add(this.lbSoLuon);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTenTaiSan);
            this.Name = "frmTaiSan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiSan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvTaiSan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.Label lbSoLuon;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbTenTaiSan;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbToaNha;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbToaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_MaTaiSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenTaiSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenPhong;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label lbViTri;
    }
}