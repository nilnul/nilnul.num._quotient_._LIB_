using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound
{
	static public class _ExtensionsX
	{
		static public DenomNonnil Diameter(this quotient_.denomNonnil.BoundI bound) {
			return bound.upper.mark - bound.lower.mark;
		}

	}
}
