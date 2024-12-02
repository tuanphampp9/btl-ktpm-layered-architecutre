namespace BTL_QLNhaTro
{
    partial class frmToaNha
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
            this.lbBuildingName = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtgvToaNha = new System.Windows.Forms.DataGridView();
            this.sMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToaNha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBuildingName
            // 
            this.lbBuildingName.AutoSize = true;
            this.lbBuildingName.Location = new System.Drawing.Point(116, 94);
            this.lbBuildingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuildingName.Name = "lbBuildingName";
            this.lbBuildingName.Size = new System.Drawing.Size(85, 17);
            this.lbBuildingName.TabIndex = 0;
            this.lbBuildingName.Text = "Tên toà nhà";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(114, 148);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(311, 148);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(903, 148);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(100, 28);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(585, 90);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 17);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(256, 90);
            this.txtBuildingName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(192, 22);
            this.txtBuildingName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(677, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(327, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(706, 148);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(443, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(276, 25);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Dánh sách toà nhà của bạn";
            // 
            // dtgvToaNha
            // 
            this.dtgvToaNha.AllowUserToAddRows = false;
            this.dtgvToaNha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvToaNha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvToaNha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvToaNha.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvToaNha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvToaNha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvToaNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvToaNha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKH,
            this.sTenKH,
            this.sDiaChi});
            this.dtgvToaNha.Location = new System.Drawing.Point(60, 205);
            this.dtgvToaNha.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvToaNha.Name = "dtgvToaNha";
            this.dtgvToaNha.RowHeadersWidth = 51;
            this.dtgvToaNha.Size = new System.Drawing.Size(995, 300);
            this.dtgvToaNha.TabIndex = 14;
            this.dtgvToaNha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvToaNha_CellClick);
            // 
            // sMaKH
            // 
            this.sMaKH.DataPropertyName = "PK_MaToa";
            this.sMaKH.HeaderText = "Mã Toà nhà";
            this.sMaKH.MinimumWidth = 6;
            this.sMaKH.Name = "sMaKH";
            // 
            // sTenKH
            // 
            this.sTenKH.DataPropertyName = "sTenToa";
            this.sTenKH.HeaderText = "Tên toà nhà";
            this.sTenKH.MinimumWidth = 6;
            this.sTenKH.Name = "sTenKH";
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.MinimumWidth = 6;
            this.sDiaChi.Name = "sDiaChi";
            // 
            // frmToaNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 660);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtgvToaNha);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbBuildingName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToaNha";
            this.Text = "Toà nhà";
            this.Load += new System.EventHandler(this.frmToaNha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToaNha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBuildingName;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dtgvToaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
    }
}