using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
    public class SinhVienDAL
    {
        private readonly List<SinhVien> _listSV = new List<SinhVien>();

        public SinhVienDAL()
        {
            _listSV.Add(new SinhVien("SV01", "Nguyễn Văn An", new DateTime(2003, 5, 10), 8.8, "CNTT"));
            _listSV.Add(new SinhVien("SV02", "Trần Thị Bình", new DateTime(2003, 8, 15), 7.2, "CNTT"));
            _listSV.Add(new SinhVien("SV03", "Lê Hoàng Cường", new DateTime(2002, 12, 1), 9.0, "CNTT"));
            _listSV.Add(new SinhVien("SV04", "Phạm Minh Đức", new DateTime(2003, 1, 20), 6.0, "DTVT"));
            _listSV.Add(new SinhVien("SV05", "Vũ Tuyết Giang", new DateTime(2003, 3, 22), 8.1, "DTVT"));
            _listSV.Add(new SinhVien("SV06", "Đặng Quang Hải", new DateTime(2002, 11, 5), 4.5, "DTVT"));
            _listSV.Add(new SinhVien("SV07", "Bùi Khánh Linh", new DateTime(2003, 9, 30), 7.8, "QTKD"));
            _listSV.Add(new SinhVien("SV08", "Đỗ Nam Phong", new DateTime(2003, 4, 18), 5.5, "QTKD"));
            _listSV.Add(new SinhVien("SV09", "Hoàng Ngọc Sơn", new DateTime(2002, 7, 12), 9.5, "QTKD"));
        }

        public List<SinhVien> GetAll() => new List<SinhVien>(_listSV);

        public void Add(SinhVien sv) => _listSV.Add(sv);

        public void Update(SinhVien sv)
        {
            var item = _listSV.FirstOrDefault(x => x.MaSV == sv.MaSV);
            if (item != null)
            {
                item.HoTen = sv.HoTen;
                item.NgaySinh = sv.NgaySinh;
                item.DiemTB = sv.DiemTB;
                item.MaKhoa = sv.MaKhoa;
            }
        }

        public void Delete(string maSV) => _listSV.RemoveAll(x => x.MaSV == maSV);

        // Bài 9: Xuất danh sách ra tệp CSV
        public void ExportToCSV(string filePath)
        {
            var lines = new List<string> { "MaSV,HoTen,NgaySinh,DiemTB,MaKhoa" };
            lines.AddRange(_listSV.Select(sv =>
                $"{sv.MaSV},{sv.HoTen},{sv.NgaySinh:yyyy-MM-dd},{sv.DiemTB},{sv.MaKhoa}"));
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        // Bài 9: Đọc dữ liệu từ tệp CSV
        public void ImportFromCSV(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath, Encoding.UTF8).Skip(1);
            _listSV.Clear();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    _listSV.Add(new SinhVien
                    {
                        MaSV = parts[0].Trim(),
                        HoTen = parts[1].Trim(),
                        NgaySinh = DateTime.Parse(parts[2].Trim()),
                        DiemTB = double.Parse(parts[3].Trim()),
                        MaKhoa = parts[4].Trim()
                    });
                }
            }
        }
    }
}