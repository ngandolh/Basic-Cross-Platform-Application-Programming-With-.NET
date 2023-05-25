using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class NhanvienKiemthu : Nhanvien
    {
        public NhanvienKiemthu() : base() { }
        public NhanvienKiemthu(string maso, string hoten, double luongcb) : base(maso, hoten, luongcb) { }
    }

}
