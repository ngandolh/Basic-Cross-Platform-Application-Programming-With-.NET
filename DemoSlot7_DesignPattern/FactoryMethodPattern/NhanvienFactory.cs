using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class NhanvienFactory : INhanvienFactory
    {
        public Nhanvien CreateNhanvien(string loaiNhanvien)
        {
            Nhanvien nv = null;

            string x = loaiNhanvien.ToLower();

            switch (x)
            {
                case "chuyen vien phan tich du lieu":
                    nv = new ChuyenvienPhantich();
                    break;
                case "nhan vien kiem thu":
                    nv = new NhanvienKiemthu();
                    break;
                case "ke toan":
                    nv = new Ketoanvien();
                    break;
                case "lap trinh vien":
                    nv = new Laptrinhvien();
                    break;
            }

            return nv;
        }

        public Nhanvien CreateNhanvien(string maso, string hoten, double luongCB, string loaiNhanvien)
        {
            Nhanvien nv = null;

            string x = loaiNhanvien.ToLower();

            switch (x)
            {
                case "chuyen vien phan tich du lieu":
                    nv = new ChuyenvienPhantich(maso, hoten, luongCB);
                    break;
                case "nhan vien kiem thu":
                    nv = new NhanvienKiemthu(maso, hoten, luongCB);
                    break;
                case "ke toan":
                    nv = new Ketoanvien(maso, hoten, luongCB);
                    break;
                case "lap trinh vien":
                    nv = new Laptrinhvien(maso, hoten, luongCB);
                    break;
            }

            return nv;
        }
    }
}
