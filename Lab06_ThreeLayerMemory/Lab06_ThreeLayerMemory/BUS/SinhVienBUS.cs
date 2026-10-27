using System;
using System.Collections.Generic;
using System.Linq;
using Lab06_ThreeLayerMemory.DAL;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.BUS
{
    public class SinhVienBUS
    {
        private readonly SinhVienDAL _svDAL = new SinhVienDAL();

        public List<SinhVien> GetAll() => _svDAL.GetAll();

        public void Add(SinhVien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV))
                throw new ArgumentException("Mã sinh viên không được để trống!");

            if (string.IsNullOrWhiteSpace(sv.HoTen))
                throw new ArgumentException("Họ tên không được để trống!");

            if (sv.DiemTB < 0.0 || sv.DiemTB > 10.0)
                throw new ArgumentOutOfRangeException(nameof(sv.DiemTB), "Điểm TB phải từ 0.0 đến 10.0!");

            if (_svDAL.GetAll().Any(x => x.MaSV.Equals(sv.MaSV, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Mã sinh viên đã tồn tại!");

            _svDAL.Add(sv);
        }

        public void Update(SinhVien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.HoTen))
                throw new ArgumentException("Họ tên không được để trống!");

            if (sv.DiemTB < 0.0 || sv.DiemTB > 10.0)
                throw new ArgumentOutOfRangeException(nameof(sv.DiemTB), "Điểm TB phải từ 0.0 đến 10.0!");

            _svDAL.Update(sv);
        }

        public void Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new ArgumentException("Vui lòng chọn sinh viên cần xóa!");

            _svDAL.Delete(maSV);
        }

        // Bổ sung phương thức Tìm kiếm sinh viên (Sửa lỗi CS1061 tại dòng 206)
        public List<SinhVien> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _svDAL.GetAll();

            keyword = keyword.ToLower();
            return _svDAL.GetAll()
                         .Where(x => (x.MaSV != null && x.MaSV.ToLower().Contains(keyword)) ||
                                     (x.HoTen != null && x.HoTen.ToLower().Contains(keyword)))
                         .ToList();
        }

        public Dictionary<string, List<SinhVien>> GetGroupedByKhoa(List<Khoa> danhSachKhoa)
        {
            var dict = new Dictionary<string, List<SinhVien>>();
            var allSV = _svDAL.GetAll();

            foreach (var khoa in danhSachKhoa)
            {
                var list = allSV.Where(x => x.MaKhoa == khoa.MaKhoa).ToList();
                dict.Add($"{khoa.TenKhoa} ({khoa.MaKhoa})", list);
            }

            return dict;
        }

        public void ExportCSV(string filePath) => _svDAL.ExportToCSV(filePath);
        public void ImportCSV(string filePath) => _svDAL.ImportFromCSV(filePath);
    }
}