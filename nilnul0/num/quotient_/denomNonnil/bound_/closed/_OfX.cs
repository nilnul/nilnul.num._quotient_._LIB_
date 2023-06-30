using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.bound_.closed
{
	static public class _OfX
	{
		static public Closed OfRange(DenomNonnil a, DenomNonnil b) {
			if (a<=b)
			{
				return new Closed(a, b);

			}
			return new Closed(b, a);
		}
	}
}
