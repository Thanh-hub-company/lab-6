namespace Lab06_ThreeLayerMemory.GUI
{
    partial class frmQuanLySinhVien
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDataGridView = new System.Windows.Forms.TabPage();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.tpListView = new System.Windows.Forms.TabPage();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.tpTreeView = new System.Windows.Forms.TabPage();
            this.tvKhoa = new System.Windows.Forms.TreeView();

            this.gbThongTin.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.tpListView.SuspendLayout();
            this.tpTreeView.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(220, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SINH VIÊN (MÔ HÌNH 3 LỚP)";

            // gbThongTin
            this.gbThongTin.Controls.Add(this.cboKhoa);
            this.gbThongTin.Controls.Add(this.dtpNgaySinh);
            this.gbThongTin.Controls.Add(this.txtDiemTB);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.txtMaSV);
            this.gbThongTin.Controls.Add(this.lblKhoa);
            this.gbThongTin.Controls.Add(this.lblDiemTB);
            this.gbThongTin.Controls.Add(this.lblNgaySinh);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Controls.Add(this.lblMaSV);
            this.gbThongTin.Location = new System.Drawing.Point(12, 50);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(760, 100);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sinh viên";

            // lblMaSV
            this.lblMaSV.Location = new System.Drawing.Point(15, 25);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(60, 20);
            this.lblMaSV.Text = "Mã SV:";

            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(80, 22);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(150, 20);

            // lblHoTen
            this.lblHoTen.Location = new System.Drawing.Point(250, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(60, 20);
            this.lblHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(315, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);

            // lblKhoa
            this.lblKhoa.Location = new System.Drawing.Point(510, 25);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(50, 20);
            this.lblKhoa.Text = "Khoa:";

            // cboKhoa
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Location = new System.Drawing.Point(565, 22);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(180, 21);

            // lblNgaySinh
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 60);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 20);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(80, 57);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 20);

            // lblDiemTB
            this.lblDiemTB.Location = new System.Drawing.Point(250, 60);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(60, 20);
            this.lblDiemTB.Text = "Điểm TB:";

            // txtDiemTB
            this.txtDiemTB.Location = new System.Drawing.Point(315, 57);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(180, 20);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(12, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(110, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(208, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnExportCSV
            this.btnExportCSV.Location = new System.Drawing.Point(306, 160);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(110, 30);
            this.btnExportCSV.Text = "Xuất CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            // btnImportCSV
            this.btnImportCSV.Location = new System.Drawing.Point(424, 160);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(110, 30);
            this.btnImportCSV.Text = "Nhập CSV";
            this.btnImportCSV.Click += new System.EventHandler(this.btnImportCSV_Click);

            // lblTimKiem
            this.lblTimKiem.Location = new System.Drawing.Point(545, 165);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(55, 20);
            this.lblTimKiem.Text = "Tìm kiếm:";

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(605, 162);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(167, 20);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // tcMain
            this.tcMain.Controls.Add(this.tpDataGridView);
            this.tcMain.Controls.Add(this.tpListView);
            this.tcMain.Controls.Add(this.tpTreeView);
            this.tcMain.Location = new System.Drawing.Point(12, 200);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(760, 350);

            // tpDataGridView
            this.tpDataGridView.Controls.Add(this.dgvSinhVien);
            this.tpDataGridView.Location = new System.Drawing.Point(4, 22);
            this.tpDataGridView.Name = "tpDataGridView";
            this.tpDataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataGridView.Size = new System.Drawing.Size(752, 324);
            this.tpDataGridView.Text = "DataGridView (BindingList)";

            // dgvSinhVien
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 3);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(746, 318);
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);

            // tpListView
            this.tpListView.Controls.Add(this.lvSinhVien);
            this.tpListView.Location = new System.Drawing.Point(4, 22);
            this.tpListView.Name = "tpListView";
            this.tpListView.Padding = new System.Windows.Forms.Padding(3);
            this.tpListView.Size = new System.Drawing.Size(752, 324);
            this.tpListView.Text = "ListView (Chi tiết)";

            // lvSinhVien
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 3);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(746, 318);

            // tpTreeView
            this.tpTreeView.Controls.Add(this.tvKhoa);
            this.tpTreeView.Location = new System.Drawing.Point(4, 22);
            this.tpTreeView.Name = "tpTreeView";
            this.tpTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tpTreeView.Size = new System.Drawing.Size(752, 324);
            this.tpTreeView.Text = "TreeView (Cây Khoa - SV)";

            // tvKhoa
            this.tvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvKhoa.Location = new System.Drawing.Point(3, 3);
            this.tvKhoa.Name = "tvKhoa";
            this.tvKhoa.Size = new System.Drawing.Size(746, 318);
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);

            // frmQuanLySinhVien
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnImportCSV);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 06 - Quản lý Sinh viên (Three-Layer Memory)";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);

            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.tpListView.ResumeLayout(false);
            this.tpTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDataGridView;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TabPage tpListView;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.TabPage tpTreeView;
        private System.Windows.Forms.TreeView tvKhoa;
    }
}