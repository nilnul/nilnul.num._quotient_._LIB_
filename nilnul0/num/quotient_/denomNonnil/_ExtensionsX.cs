using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil
{
	public static class _ExtensionsX
	{
		static public nilnul.num.quotient_.DenomNonnil ToImpl(
			this
			nilnul.num.quotient_.DenomNonnilI q
		) {
			return q switch
			{
				quotient_.DenomNonnil x => x
				,
				_ => new quotient_.DenomNonnil(q.numerator,q.denominator)
			};
		}
	}
}
