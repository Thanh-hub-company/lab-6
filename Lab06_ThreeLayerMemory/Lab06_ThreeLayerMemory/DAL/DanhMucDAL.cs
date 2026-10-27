using System.Collections.Generic;
using System.Linq;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
    public class DanhMucDAL
    {
        private readonly List<DanhMuc> _listDM = new List<DanhMuc>();

        public DanhMucDAL()
        {
            _listDM.Add(new DanhMuc("DM01", "Điện thoại & Máy tính bảng"));
            _listDM.Add(new DanhMuc("DM02", "Laptop & Linh kiện"));
            _listDM.Add(new DanhMuc("DM03", "Thiết bị âm thanh"));
        }

        public List<DanhMuc> GetAll() => new List<DanhMuc>(_listDM);

        public void Add(DanhMuc dm) => _listDM.Add(dm);

        public void Update(DanhMuc dm)
        {
            var item = _listDM.FirstOrDefault(x => x.MaDM == dm.MaDM);
            if (item != null) item.TenDM = dm.TenDM;
        }

        public void Delete(string maDM) => _listDM.RemoveAll(x => x.MaDM == maDM);
    }
}