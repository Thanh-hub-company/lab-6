namespace Lab06_ThreeLayerMemory.DTO
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string MaDM { get; set; }

        public double TongGiaTri => DonGia * SoLuongTon;

        public SanPham() { }

        public SanPham(string maSP, string tenSP, double donGia, int soLuongTon, string maDM)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuongTon = soLuongTon;
            MaDM = maDM;
        }
    }
}