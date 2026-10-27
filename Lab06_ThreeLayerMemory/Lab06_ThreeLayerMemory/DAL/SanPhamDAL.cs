using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
    public class SanPhamDAL
    {
        private readonly List<SanPham> _listSP = new List<SanPham>();

        public SanPhamDAL()
        {
            _listSP.Add(new SanPham("SP01", "iPhone 15 Pro Max", 30000000, 10, "DM01"));
            _listSP.Add(new SanPham("SP02", "Samsung Galaxy S24 Ultra", 27000000, 15, "DM01"));
            _listSP.Add(new SanPham("SP03", "iPad Air 5 M1", 14500000, 8, "DM01"));
            _listSP.Add(new SanPham("SP04", "MacBook Pro M3", 42000000, 5, "DM02"));
            _listSP.Add(new SanPham("SP05", "Dell XPS 15", 38000000, 7, "DM02"));
            _listSP.Add(new SanPham("SP06", "RAM DDR5 16GB", 1800000, 30, "DM02"));
            _listSP.Add(new SanPham("SP07", "Tai nghe AirPods Pro 2", 5500000, 20, "DM03"));
            _listSP.Add(new SanPham("SP08", "Loa Bluetooth JBL Charge 5", 3200000, 12, "DM03"));
        }

        public List<SanPham> GetAll() => new List<SanPham>(_listSP);

        public void Add(SanPham sp) => _listSP.Add(sp);

        public void Update(SanPham sp)
        {
            var item = _listSP.FirstOrDefault(x => x.MaSP == sp.MaSP);
            if (item != null)
            {
                item.TenSP = sp.TenSP;
                item.DonGia = sp.DonGia;
                item.SoLuongTon = sp.SoLuongTon;
                item.MaDM = sp.MaDM;
            }
        }

        public void Delete(string maSP) => _listSP.RemoveAll(x => x.MaSP == maSP);

        // Bài 9: Xuất sản phẩm ra CSV
        public void ExportToCSV(string filePath)
        {
            var lines = new List<string> { "MaSP,TenSP,DonGia,SoLuongTon,MaDM" };
            lines.AddRange(_listSP.Select(sp =>
                $"{sp.MaSP},{sp.TenSP},{sp.DonGia},{sp.SoLuongTon},{sp.MaDM}"));
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        // Bài 9: Đọc sản phẩm từ CSV
        public void ImportFromCSV(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath, Encoding.UTF8).Skip(1);
            _listSP.Clear();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    _listSP.Add(new SanPham
                    {
                        MaSP = parts[0].Trim(),
                        TenSP = parts[1].Trim(),
                        DonGia = double.Parse(parts[2].Trim()),
                        SoLuongTon = int.Parse(parts[3].Trim()),
                        MaDM = parts[4].Trim()
                    });
                }
            }
        }
    }
}