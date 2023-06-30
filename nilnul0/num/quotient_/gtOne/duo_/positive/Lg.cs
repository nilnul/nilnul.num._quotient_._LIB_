using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.gtOne.duo_.positive
{
	/// <summary>
	/// lg(a,x), whera a is <see cref="quotient.betwixt_.boolish_.IOpen"/>, x is positive;
	/// the result is <see cref="nilnul.num.integer.betwixt_.IClasp"/>
	/// </summary>
	internal class _LgX
	{
		static public (BigInteger, BigInteger) _Lg_0gtOne_1positive(DenomNonnil a, DenomNonnil x)
		{
			if (x==1)
			{
				return (0, 0);
			}
			if (x<1)
			{
				var t=gtOne.co._LgX._Lg_01gtOne(a, ~x);
				return (-t.Item2,-t.Item1);
			}

			return gtOne.co._LgX._Lg_01gtOne(a, x);

		}

	}
}
