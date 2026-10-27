using System.Collections.Generic;
using Lab06_ThreeLayerMemory.DAL;
using Lab06_ThreeLayerMemory.DTO;

namespace Lab06_ThreeLayerMemory.BUS
{
    public class KhoaBUS
    {
        private readonly KhoaDAL _khoaDAL = new KhoaDAL();
        public List<Khoa> GetAll() => _khoaDAL.GetAll();
    }
}