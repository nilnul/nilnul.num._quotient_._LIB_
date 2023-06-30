using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.signed_.floored
{
	static public class _OfX
	{


		public static (int, long, double) ToSignedFloored(double x)
		{
			if (x < 0.0)
			{
				var tuple = bin_.floored._OfX. ToFloorAndMantissa(-x);
				return (-1, tuple.Item1, tuple.Item2);
			}

			var t1 = bin_.floored._OfX.ToFloorAndMantissa(x);
			return (1, t1.Item1, t1.Item2);
		}




	}
}
