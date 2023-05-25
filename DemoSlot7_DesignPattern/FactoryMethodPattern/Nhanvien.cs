using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Nhanvien
    {
        public string Maso { set; get; }
        public string Hoten { set; get; }
        public double LuongCB { set; get; }
        public ITienthuong PhuongthucTinhThuong { set; get; }

        public Nhanvien() : this("", "", 0) { }

        public Nhanvien(string maso, string hoten, double luongcb)
        {
            Maso = maso;
            Hoten = hoten;
            LuongCB = luongcb;
        }

        public override String ToString()
        {
            return "Ma nhan vien : " + Maso + "\tHo ten: " + Hoten + "\tLuong co ban: " + LuongCB + "\tTien thuong: " + GetTienThuong();
        }

        public double GetTienThuong()
        {
            return PhuongthucTinhThuong.Tienthuong(LuongCB);
        }
    }

}
