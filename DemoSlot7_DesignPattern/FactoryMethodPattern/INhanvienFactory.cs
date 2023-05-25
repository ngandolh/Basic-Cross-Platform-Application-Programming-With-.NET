using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public interface INhanvienFactory
    {
        Nhanvien CreateNhanvien(string loaiNhanvien);
        Nhanvien CreateNhanvien(string maso, string hoten, double luongCB, string loaiNhanvien);

    }
}
