using System;
using System.Collections.Generic;
using System.Linq;
using Lab06_ThreeLayerMemory.DAL;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.BUS
{
    public class DanhMucBUS
    {
        private readonly DanhMucDAL _dmDAL = new DanhMucDAL();

        public List<DanhMuc> GetAll() => _dmDAL.GetAll();

        public void Add(DanhMuc dm)
        {
            if (string.IsNullOrWhiteSpace(dm.MaDM))
                throw new ArgumentException("Mã danh mục không được trống.");

            if (string.IsNullOrWhiteSpace(dm.TenDM))
                throw new ArgumentException("Tên danh mục không được trống.");

            if (_dmDAL.GetAll().Any(x => x.MaDM.Equals(dm.MaDM, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Trùng mã danh mục.");

            _dmDAL.Add(dm);
        }

        public void Update(DanhMuc dm)
        {
            if (string.IsNullOrWhiteSpace(dm.TenDM))
                throw new ArgumentException("Tên danh mục không được trống.");

            _dmDAL.Update(dm);
        }

        public void Delete(string maDM)
        {
            if (string.IsNullOrWhiteSpace(maDM))
                throw new ArgumentException("Chưa chọn danh mục cần xóa.");

            _dmDAL.Delete(maDM);
        }
    }
}