using System;

namespace Lab06_ThreeLayerMemory.DTO
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemTB { get; set; }
        public string MaKhoa { get; set; }

        // MỤC 8: Phân loại học tập phục vụ gắn Biểu tượng (Icon)
        public string XepLoai
        {
            get
            {
                if (DiemTB >= 8.5) return "Xuất sắc";
                if (DiemTB >= 8.0) return "Giỏi";
                if (DiemTB >= 6.5) return "Khá";
                if (DiemTB >= 5.0) return "Trung bình";
                return "Yếu";
            }
        }

        // MỤC 8: Chỉ số hình ảnh tương ứng trong ImageList
        public int ImageIndex
        {
            get
            {
                if (DiemTB >= 8.5) return 0; // Icon Xuất sắc
                if (DiemTB >= 8.0) return 1; // Icon Giỏi
                if (DiemTB >= 6.5) return 2; // Icon Khá
                if (DiemTB >= 5.0) return 3; // Icon Trung bình
                return 4;                   // Icon Yếu
            }
        }

        public SinhVien() { }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB, string maKhoa)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiemTB = diemTB;
            MaKhoa = maKhoa;
        }
    }
}