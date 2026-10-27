using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Lab06_ThreeLayerMemory.BUS;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmQuanLySanPham : Form
    {
        private readonly SanPhamBUS _spBUS = new SanPhamBUS();
        private readonly DanhMucBUS _dmBUS = new DanhMucBUS();
        private BindingList<SanPham> _bindingListSP;

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadComboBoxDanhMuc();
            RefreshAllViews();
        }

        private void LoadComboBoxDanhMuc()
        {
            cboDanhMuc.DataSource = _dmBUS.GetAll();
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
        }

        private void RefreshAllViews()
        {
            var data = _spBUS.GetAll();
            _bindingListSP = new BindingList<SanPham>(data);
            dgvSanPham.DataSource = _bindingListSP;

            lblTongGiaTriTon.Text = $"TỔNG GIÁ TRỊ TỒN KHO: {_spBUS.TinhTongGiaTriTonKho():N0} VNĐ";
            LoadTreeViewDanhMuc();
        }

        private void LoadTreeViewDanhMuc()
        {
            tvDanhMuc.Nodes.Clear();
            var danhSachDM = _dmBUS.GetAll();
            var danhSachSP = _spBUS.GetAll();

            foreach (var dm in danhSachDM)
            {
                TreeNode dmNode = new TreeNode(dm.TenDM) { Tag = dm };
                foreach (var sp in danhSachSP)
                {
                    if (sp.MaDM == dm.MaDM)
                    {
                        TreeNode spNode = new TreeNode($"{sp.TenSP} ({sp.DonGia:N0}đ)") { Tag = sp };
                        dmNode.Nodes.Add(spNode);
                    }
                }
                tvDanhMuc.Nodes.Add(dmNode);
            }
            tvDanhMuc.ExpandAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham(
                    txtMaSP.Text.Trim(),
                    txtTenSP.Text.Trim(),
                    double.Parse(txtDonGia.Text.Trim()),
                    int.Parse(txtSoLuongTon.Text.Trim()),
                    cboDanhMuc.SelectedValue?.ToString()
                );

                _spBUS.Add(sp);
                RefreshAllViews();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SanPham sp = new SanPham(
                    txtMaSP.Text.Trim(),
                    txtTenSP.Text.Trim(),
                    double.Parse(txtDonGia.Text.Trim()),
                    int.Parse(txtSoLuongTon.Text.Trim()),
                    cboDanhMuc.SelectedValue?.ToString()
                );

                _spBUS.Update(sp);
                RefreshAllViews();
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string maSP = txtMaSP.Text.Trim();
                if (MessageBox.Show($"Bạn có muốn xóa sản phẩm {maSP}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _spBUS.Delete(maSP);
                    RefreshAllViews();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var res = _spBUS.Search(txtTimKiem.Text.Trim());
            dgvSanPham.DataSource = new BindingList<SanPham>(res);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            var res = _spBUS.SortByPrice(rbTangDan.Checked);
            dgvSanPham.DataSource = new BindingList<SanPham>(res);
        }

        private void tvDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvDanhMuc.SelectedNode = e.Node;
            }
        }

        private void tsmiThemNode_Click(object sender, EventArgs e)
        {
            TreeNode selected = tvDanhMuc.SelectedNode;
            if (selected == null) return;

            string tenMoi = PromptInput("Nhập tên Node con mới:", "Thêm Node");
            if (!string.IsNullOrWhiteSpace(tenMoi))
            {
                selected.Nodes.Add(new TreeNode(tenMoi));
                selected.Expand();
            }
        }

        private void tsmiDoiTenNode_Click(object sender, EventArgs e)
        {
            TreeNode selected = tvDanhMuc.SelectedNode;
            if (selected == null) return;

            string tenMoi = PromptInput("Nhập tên mới:", "Đổi Tên Node", selected.Text);
            if (!string.IsNullOrWhiteSpace(tenMoi))
            {
                selected.Text = tenMoi;
            }
        }

        private void tsmiXoaNode_Click(object sender, EventArgs e)
        {
            TreeNode selected = tvDanhMuc.SelectedNode;
            if (selected != null && MessageBox.Show($"Xóa node '{selected.Text}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tvDanhMuc.Nodes.Remove(selected);
            }
        }

        private string PromptInput(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 20, Top = 15, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 40, Width = 290, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 210, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPham sp)
            {
                txtMaSP.Text = sp.MaSP;
                txtTenSP.Text = sp.TenSP;
                txtDonGia.Text = sp.DonGia.ToString();
                txtSoLuongTon.Text = sp.SoLuongTon.ToString();
                cboDanhMuc.SelectedValue = sp.MaDM;
            }
        }
    }
}