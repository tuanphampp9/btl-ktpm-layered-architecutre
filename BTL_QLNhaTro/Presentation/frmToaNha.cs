using BTL_QLNhaTro.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNhaTro
{
    public partial class frmToaNha : Form
    {
        private BuildingBLL buildingBLL = new BuildingBLL();
        private int selectedBuildingId = -1;
        public int userId;

        public frmToaNha(int user_id)
        {
            this.userId = user_id;
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            dtgvToaNha.DataSource = buildingBLL.GetBuildingsByUserId(userId);
        }

        private void ClearForm()
        {
            txtBuildingName.Text = "";
            txtAddress.Text = "";
            selectedBuildingId = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtBuildingName.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (buildingBLL.AddBuilding(name, address, userId))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuildingName.Text.Trim()))
            {
                string buildingName = txtBuildingName.Text.Trim();
                DataTable result = buildingBLL.GetBuildingsByUserIdAndNameBuilding(userId, buildingName);
                dtgvToaNha.DataSource = result;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tòa nhà để tìm kiếm.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedBuildingId < 0)
            {
                MessageBox.Show("Vui lòng chọn tòa nhà để sửa!");
                return;
            }

            string name = txtBuildingName.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (buildingBLL.UpdateBuilding(selectedBuildingId, name, address))
            {
                MessageBox.Show("Sửa thành công!");
                LoadDataGridView();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDataGridView();
        }

        private void dtgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBuildingId = Convert.ToInt32(dtgvToaNha.Rows[e.RowIndex].Cells[0].Value);
                txtBuildingName.Text = dtgvToaNha.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dtgvToaNha.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void frmToaNha_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
