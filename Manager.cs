using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_OnThi_07_10_Cau2
{
    internal class Manager : Employee
    {
        private string teamSize;

        public string TeamSize { get => teamSize; set => teamSize = value; }

        public Manager() { }

        public Manager(string tenNV, string maNV, string chucVu, double luongcoBan, string teamSize) : base(tenNV,maNV,chucVu,luongcoBan)
        {
            TeamSize = teamSize;
        }
    }
}
