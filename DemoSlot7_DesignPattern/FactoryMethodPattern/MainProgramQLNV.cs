using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class MainProgramQLNV
    {
        static void Main(string[] args)
        {
            INhanvienFactory nvfactory = new NhanvienFactory();

            ChuyenvienPhantich nvpt = (ChuyenvienPhantich)nvfactory.CreateNhanvien("chuyen vien phan tich du lieu");
            nvpt.Maso = "123";
            nvpt.Hoten = "Nguyen Van A";
            nvpt.LuongCB = 1000000;
            ITienthuong x = new TienthuongNgoaigio(); /// 
            nvpt.PhuongthucTinhThuong = x;
            Console.WriteLine(nvpt);

            Laptrinhvien ltv = (Laptrinhvien)nvfactory.CreateNhanvien("222", "Nguyen Thi B", 2500000, "lap trinh vien");
            ITienthuong y = new TienthuongNgoaitinh();
            ltv.PhuongthucTinhThuong = y;
            Console.WriteLine(ltv);

            Console.ReadKey();
        }

    }
}
