using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class ChuyenvienPhantich : Nhanvien
    {
        public ChuyenvienPhantich() : base() { }
        public ChuyenvienPhantich(string maso, string hoten, double luongcb) : base(maso, hoten, luongcb) { }

    }//

}
