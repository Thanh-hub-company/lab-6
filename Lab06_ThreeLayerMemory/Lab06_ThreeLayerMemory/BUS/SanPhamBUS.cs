using System;
using System.Collections.Generic;
using System.Linq;
using Lab06_ThreeLayerMemory.DAL;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL _spDAL = new SanPhamDAL();

        public List<SanPham> GetAll() => _spDAL.GetAll();

        public void Add(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không được để trống.");

            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống.");

            if (sp.DonGia <= 0)
                throw new ArgumentException("Đơn giá phải lớn hơn 0.");

            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn không được âm.");

            if (_spDAL.GetAll().Any(x => x.MaSP.Equals(sp.MaSP, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Mã sản phẩm đã tồn tại.");

            _spDAL.Add(sp);
        }

        public void Update(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống.");

            if (sp.DonGia <= 0)
                throw new ArgumentException("Đơn giá phải lớn hơn 0.");

            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn không được âm.");

            _spDAL.Update(sp);
        }

        public void Delete(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Vui lòng chọn sản phẩm cần xóa.");

            _spDAL.Delete(maSP);
        }

        // Bài 6: Tính tổng giá trị toàn bộ hàng tồn kho
        public double TinhTongGiaTriTonKho()
        {
            return _spDAL.GetAll().Sum(x => x.TongGiaTri);
        }

        // Bài 6: Tìm kiếm sản phẩm theo Tên/Mã
        public List<SanPham> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return GetAll();
            keyword = keyword.ToLower();
            return _spDAL.GetAll().Where(x => x.MaSP.ToLower().Contains(keyword) || x.TenSP.ToLower().Contains(keyword)).ToList();
        }

        // Bài 6: Sắp xếp danh sách
        public List<SanPham> SortByPrice(bool ascending)
        {
            return ascending
                ? _spDAL.GetAll().OrderBy(x => x.DonGia).ToList()
                : _spDAL.GetAll().OrderByDescending(x => x.DonGia).ToList();
        }

        public void ExportCSV(string path) => _spDAL.ExportToCSV(path);
        public void ImportCSV(string path) => _spDAL.ImportFromCSV(path);
    }
}