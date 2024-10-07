using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_OnThi_07_10_Cau2
{
    internal class Employee
    {
        private string tenNV;
        private string maNV;
        private string chucVu;
        private double luongcoBan;

        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double LuongcoBan { get => luongcoBan; set => luongcoBan = value; }

        public Employee() { }

        public Employee(string tenNV, string maNV, string chucVu, double luongcoBan)
        {
            TenNV = tenNV;
            MaNV = maNV;
            ChucVu = chucVu;
            LuongcoBan = luongcoBan;
        }
    }
}
