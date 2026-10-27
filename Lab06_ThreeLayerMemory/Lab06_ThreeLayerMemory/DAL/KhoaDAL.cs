using System.Collections.Generic;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.DAL
{
	public class KhoaDAL
	{
		private readonly List<Khoa> _listKhoa = new List<Khoa>();

		public KhoaDAL()
		{
			_listKhoa.Add(new Khoa("CNTT", "Công nghệ thông tin"));
			_listKhoa.Add(new Khoa("DTVT", "Điện tử viễn thông"));
			_listKhoa.Add(new Khoa("QTKD", "Quản trị kinh doanh"));
		}

		public List<Khoa> GetAll() => new List<Khoa>(_listKhoa);
		public void Add(Khoa khoa) => _listKhoa.Add(khoa);
		public void Delete(string maKhoa) => _listKhoa.RemoveAll(x => x.MaKhoa == maKhoa);
	}
}