using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.Simplified;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.cast_
{
	/// <summary>
	/// towards infinity, get the nearest integer
	/// </summary>
	public static class _ExpandX
	{


		static public BigInteger Expand(this Q1 x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._expand.X._Expand(x.numerator, x.denominator);


		}

		static public BigInteger Expand(this nilnul.num.QuotientI x)
		{

			return nilnul.num.integer.duo_.divisible.op_.divide_._expand.X._Expand(x.numerator, x.denominator);


		}



	}
}
