namespace Lab06_ThreeLayerMemory.GUI
{
    public partial class frmQuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbTangDan = new System.Windows.Forms.RadioButton();
            this.rbGiamDan = new System.Windows.Forms.RadioButton();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.lblTongGiaTriTon = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDataGridView = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tpTreeView = new System.Windows.Forms.TabPage();
            this.tvDanhMuc = new System.Windows.Forms.TreeView();
            this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThemNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoiTenNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoaNode = new System.Windows.Forms.ToolStripMenuItem();

            this.gbThongTin.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tpTreeView.SuspendLayout();
            this.cmsTreeView.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(180, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM & DANH MỤC (BÀI 6 & 7)";

            // gbThongTin
            this.gbThongTin.Controls.Add(this.cboDanhMuc);
            this.gbThongTin.Controls.Add(this.txtSoLuongTon);
            this.gbThongTin.Controls.Add(this.txtDonGia);
            this.gbThongTin.Controls.Add(this.txtTenSP);
            this.gbThongTin.Controls.Add(this.txtMaSP);
            this.gbThongTin.Controls.Add(this.lblDanhMuc);
            this.gbThongTin.Controls.Add(this.lblSoLuongTon);
            this.gbThongTin.Controls.Add(this.lblDonGia);
            this.gbThongTin.Controls.Add(this.lblTenSP);
            this.gbThongTin.Controls.Add(this.lblMaSP);
            this.gbThongTin.Location = new System.Drawing.Point(12, 45);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(760, 95);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sản phẩm";

            // lblMaSP & txtMaSP
            this.lblMaSP.Location = new System.Drawing.Point(15, 25);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(60, 20);
            this.lblMaSP.Text = "Mã SP:";

            this.txtMaSP.Location = new System.Drawing.Point(80, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(150, 20);

            // lblTenSP & txtTenSP
            this.lblTenSP.Location = new System.Drawing.Point(250, 25);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(60, 20);
            this.lblTenSP.Text = "Tên SP:";

            this.txtTenSP.Location = new System.Drawing.Point(315, 22);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(180, 20);

            // lblDanhMuc & cboDanhMuc
            this.lblDanhMuc.Location = new System.Drawing.Point(510, 25);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(65, 20);
            this.lblDanhMuc.Text = "Danh mục:";

            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Location = new System.Drawing.Point(580, 22);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(165, 21);

            // lblDonGia & txtDonGia
            this.lblDonGia.Location = new System.Drawing.Point(15, 58);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(60, 20);
            this.lblDonGia.Text = "Đơn giá:";

            this.txtDonGia.Location = new System.Drawing.Point(80, 55);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(150, 20);

            // lblSoLuongTon & txtSoLuongTon
            this.lblSoLuongTon.Location = new System.Drawing.Point(250, 58);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(60, 20);
            this.lblSoLuongTon.Text = "SL Tồn:";

            this.txtSoLuongTon.Location = new System.Drawing.Point(315, 55);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(180, 20);

            // Controls chức năng
            this.btnThem.Location = new System.Drawing.Point(12, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(98, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(184, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.lblTimKiem.Location = new System.Drawing.Point(280, 150);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(55, 20);
            this.lblTimKiem.Text = "Tìm kiếm:";

            this.txtTimKiem.Location = new System.Drawing.Point(340, 147);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(140, 20);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            this.rbTangDan.Checked = true;
            this.rbTangDan.Location = new System.Drawing.Point(490, 148);
            this.rbTangDan.Name = "rbTangDan";
            this.rbTangDan.Size = new System.Drawing.Size(65, 20);
            this.rbTangDan.Text = "Giá tăng";

            this.rbGiamDan.Location = new System.Drawing.Point(560, 148);
            this.rbGiamDan.Name = "rbGiamDan";
            this.rbGiamDan.Size = new System.Drawing.Size(70, 20);
            this.rbGiamDan.Text = "Giá giảm";

            this.btnSapXep.Location = new System.Drawing.Point(635, 145);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(80, 30);
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);

            // lblTongGiaTriTon
            this.lblTongGiaTriTon.AutoSize = true;
            this.lblTongGiaTriTon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongGiaTriTon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongGiaTriTon.Location = new System.Drawing.Point(12, 185);
            this.lblTongGiaTriTon.Name = "lblTongGiaTriTon";
            this.lblTongGiaTriTon.Size = new System.Drawing.Size(250, 20);
            this.lblTongGiaTriTon.Text = "TỔNG GIÁ TRỊ TỒN KHO: 0 VNĐ";

            // TabControl
            this.tcMain.Controls.Add(this.tpDataGridView);
            this.tcMain.Controls.Add(this.tpTreeView);
            this.tcMain.Location = new System.Drawing.Point(12, 215);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(760, 335);

            // tpDataGridView
            this.tpDataGridView.Controls.Add(this.dgvSanPham);
            this.tpDataGridView.Location = new System.Drawing.Point(4, 22);
            this.tpDataGridView.Name = "tpDataGridView";
            this.tpDataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataGridView.Size = new System.Drawing.Size(752, 309);
            this.tpDataGridView.Text = "Sản Phẩm (Bài 6)";

            // dgvSanPham
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(746, 303);
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);

            // tpTreeView
            this.tpTreeView.Controls.Add(this.tvDanhMuc);
            this.tpTreeView.Location = new System.Drawing.Point(4, 22);
            this.tpTreeView.Name = "tpTreeView";
            this.tpTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tpTreeView.Size = new System.Drawing.Size(752, 309);
            this.tpTreeView.Text = "TreeView Cây Danh Mục (Bài 7)";

            // tvDanhMuc
            this.tvDanhMuc.ContextMenuStrip = this.cmsTreeView;
            this.tvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDanhMuc.Location = new System.Drawing.Point(3, 3);
            this.tvDanhMuc.Name = "tvDanhMuc";
            this.tvDanhMuc.Size = new System.Drawing.Size(746, 303);
            this.tvDanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDanhMuc_NodeMouseClick);

            // ContextMenuStrip
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThemNode,
            this.tsmiDoiTenNode,
            this.tsmiXoaNode});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(144, 70);

            // tsmiThemNode
            this.tsmiThemNode.Name = "tsmiThemNode";
            this.tsmiThemNode.Size = new System.Drawing.Size(143, 22);
            this.tsmiThemNode.Text = "Thêm node";
            this.tsmiThemNode.Click += new System.EventHandler(this.tsmiThemNode_Click);

            // tsmiDoiTenNode
            this.tsmiDoiTenNode.Name = "tsmiDoiTenNode";
            this.tsmiDoiTenNode.Size = new System.Drawing.Size(143, 22);
            this.tsmiDoiTenNode.Text = "Đổi tên node";
            this.tsmiDoiTenNode.Click += new System.EventHandler(this.tsmiDoiTenNode_Click);

            // tsmiXoaNode
            this.tsmiXoaNode.Name = "tsmiXoaNode";
            this.tsmiXoaNode.Size = new System.Drawing.Size(143, 22);
            this.tsmiXoaNode.Text = "Xóa node";
            this.tsmiXoaNode.Click += new System.EventHandler(this.tsmiXoaNode_Click);

            // frmQuanLySanPham
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lblTongGiaTriTon);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.rbGiamDan);
            this.Controls.Add(this.rbTangDan);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 6 & 7 - Quản lý Sản phẩm";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);

            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tpTreeView.ResumeLayout(false);
            this.cmsTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rbTangDan;
        private System.Windows.Forms.RadioButton rbGiamDan;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Label lblTongGiaTriTon;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDataGridView;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TabPage tpTreeView;
        private System.Windows.Forms.TreeView tvDanhMuc;
        private System.Windows.Forms.ContextMenuStrip cmsTreeView;
        private System.Windows.Forms.ToolStripMenuItem tsmiThemNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiTenNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoaNode;
    }
}
