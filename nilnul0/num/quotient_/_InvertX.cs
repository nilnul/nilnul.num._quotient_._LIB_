using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// </summary>
	static public class _InvertX
	{
		static public nilnul.num.quotient_.DenomNonnil Invert(BigInteger x) {
			return new DenomNonnil(1, x);
		}
	}
}
