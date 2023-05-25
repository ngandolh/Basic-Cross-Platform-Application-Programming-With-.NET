using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Ketoanvien : Nhanvien
    {
        public Ketoanvien() : base() { }
        public Ketoanvien(string maso, string hoten, double luongcb) : base(maso, hoten, luongcb) { }
    }

}
