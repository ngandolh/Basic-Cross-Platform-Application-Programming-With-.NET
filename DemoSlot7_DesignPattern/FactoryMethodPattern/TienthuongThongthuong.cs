using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
	public class TienthuongThongthuong : ITienthuong
	{
		public double Tienthuong(double luongCoban)
		{
			return 0.02 * luongCoban;
		}
	}
}
