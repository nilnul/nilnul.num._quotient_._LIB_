using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op
{
	static public class RoundDecimalX
	{

		static public decimal? Round(this decimal? x, int digits)
		{
			if (x  is null)
			{
				return null;
			}
			return Round(x.Value,digits);

		}
		static public decimal? RoundToTwo(this decimal? x)
		{
			
			return Round(x,2);

		}

		static public decimal Round(this decimal x,int digits)
		{

			return decimal.Round(x, digits);
		}
		static public decimal RoundToTwo(this decimal x)
		{

			return Round(x, 2);
		}

	}
}
