using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.QuotientI;

namespace nilnul.num.quotient
{
	static public class _FloorX
	{
		static public BigInteger Floor(this Q1 x)
		{
			return nilnul.num.integer.co_.divisible.div_._FloorX.Integer(x.numerator, x.denominator);


		}
	}
}
