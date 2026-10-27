using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly SinhVienBUS _svBUS = new SinhVienBUS();
        private readonly KhoaBUS _khoaBUS = new KhoaBUS();
        private BindingList<SinhVien> _bindingListSV;

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhoa();
            RefreshAllViews();
        }

        private void LoadComboBoxKhoa()
        {
            cboKhoa.DataSource = _khoaBUS.GetAll();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void RefreshAllViews()
        {
            var data = _svBUS.GetAll();

            // 1. Nạp dữ liệu vào DataGridView bằng BindingList (Mục 1 & 2)
            _bindingListSV = new BindingList<SinhVien>(data);
            dgvSinhVien.DataSource = _bindingListSV;
            ConfigureDataGridView();

            // 2. Nạp dữ liệu vào ListView (Mục 3 & Bài 8)
            LoadListView(data);

            // 3. Nạp dữ liệu vào TreeView (Mục 4)
            LoadTreeView();
        }

        private void ConfigureDataGridView()
        {
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
            if (dgvSinhVien.Columns["MaKhoa"] != null) dgvSinhVien.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            if (dgvSinhVien.Columns["MaSV"] != null) dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
            if (dgvSinhVien.Columns["HoTen"] != null) dgvSinhVien.Columns["HoTen"].HeaderText = "Họ và Tên";
            if (dgvSinhVien.Columns["NgaySinh"] != null) dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            if (dgvSinhVien.Columns["DiemTB"] != null) dgvSinhVien.Columns["DiemTB"].HeaderText = "Điểm TB";
        }

        // --- CẤU HÌNH LISTVIEW ---
        private void LoadListView(System.Collections.Generic.IEnumerable<SinhVien> list)
        {
            lvSinhVien.Items.Clear();
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;

            if (lvSinhVien.Columns.Count == 0)
            {
                lvSinhVien.Columns.Add("Mã SV", 80);
                lvSinhVien.Columns.Add("Họ và Tên", 150);
                lvSinhVien.Columns.Add("Khoa", 80);
                lvSinhVien.Columns.Add("Điểm TB", 70);
                lvSinhVien.Columns.Add("Xếp Loại", 90);
            }

            foreach (var sv in list)
            {
                ListViewItem item = new ListViewItem(sv.MaSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.MaKhoa);
                item.SubItems.Add(sv.DiemTB.ToString("N2"));
                item.SubItems.Add(sv.XepLoai);
                item.Tag = sv;

                lvSinhVien.Items.Add(item);
            }
        }

        // --- CẤU HÌNH TREEVIEW ---
        private void LoadTreeView()
        {
            tvKhoa.Nodes.Clear();
            var groupedData = _svBUS.GetGroupedByKhoa(_khoaBUS.GetAll());

            foreach (var group in groupedData)
            {
                TreeNode khoaNode = new TreeNode(group.Key);
                foreach (SinhVien sv in group.Value)
                {
                    TreeNode svNode = new TreeNode($"{sv.MaSV} - {sv.HoTen}")
                    {
                        Tag = sv
                    };
                    khoaNode.Nodes.Add(svNode);
                }
                tvKhoa.Nodes.Add(khoaNode);
            }
            tvKhoa.ExpandAll();
        }

        // --- BẮT SỰ KIỆN CHỌN DỮ LIỆU ---
        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is SinhVien sv)
            {
                DisplaySinhVienToControl(sv);
            }
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is SinhVien sv)
            {
                DisplaySinhVienToControl(sv);
            }
        }

        private void DisplaySinhVienToControl(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtDiemTB.Text = sv.DiemTB.ToString();
            cboKhoa.SelectedValue = sv.MaKhoa;
        }

        // --- XỬ LÝ CHỨC NĂNG CRUD ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien(
                    txtMaSV.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    dtpNgaySinh.Value,
                    double.Parse(txtDiemTB.Text.Trim()),
                    cboKhoa.SelectedValue.ToString()
                );

                _svBUS.Add(sv);
                RefreshAllViews();
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien(
                    txtMaSV.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    dtpNgaySinh.Value,
                    double.Parse(txtDiemTB.Text.Trim()),
                    cboKhoa.SelectedValue.ToString()
                );

                _svBUS.Update(sv);
                RefreshAllViews();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa SV: {maSV}?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _svBUS.Delete(maSV);
                    RefreshAllViews();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var result = _svBUS.Search(txtTimKiem.Text.Trim());
            dgvSinhVien.DataSource = new BindingList<SinhVien>(result);
            LoadListView(result);
        }

        // --- XUẤT / NHẬP FILE CSV (Bài 9) ---
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _svBUS.ExportCSV(sfd.FileName);
                MessageBox.Show("Xuất dữ liệu ra tệp CSV thành công!", "Thông báo");
            }
        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "CSV Files (*.csv)|*.csv" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _svBUS.ImportCSV(ofd.FileName);
                RefreshAllViews();
                MessageBox.Show("Nhập dữ liệu từ tệp CSV thành công!", "Thông báo");
            }
        }
    }
}