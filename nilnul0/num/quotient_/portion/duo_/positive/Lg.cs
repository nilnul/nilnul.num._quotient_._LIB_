using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.portion.duo_.positive
{
	/// <summary>
	/// lg(a,x), whera a is <see cref="quotient.betwixt_.boolish_.IOpen"/>, x is positive;
	/// the result is <see cref="nilnul.num.integer.betwixt_.IClasp"/>
	/// </summary>
	static public class _LgX
	{
		static public (BigInteger, BigInteger) _Lg_0portion_1positive(DenomNonnil a, DenomNonnil x)
		{
			var t= quotient_.gtOne.duo_.positive._LgX._Lg_0gtOne_1positive(
				~a, x
			);

			return (-t.Item2,-t.Item1);

		}

	}
}
