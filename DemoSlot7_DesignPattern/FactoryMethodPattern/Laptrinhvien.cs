using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Laptrinhvien : Nhanvien
    {
        public Laptrinhvien() : base() { }
        public Laptrinhvien(string maso, string hoten, double luongcb) : base(maso, hoten, luongcb) { }
    }

}
