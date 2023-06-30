using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee
{
	static public class _FloorX
	{

		public static long Floor(this double x)
		{

			return Convert.ToInt64(Math.Floor(x));
		}



		public static long Floor(this decimal x)
		{
			return Convert.ToInt64(decimal.Truncate(x));
		}
	}
}
