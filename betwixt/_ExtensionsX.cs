using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.betwixt
{
	static public class _ExtensionsX
	{
		static public DenomNonnil Mid(this quotient_.denomNonnil.RangeI bound) {

			return quotient.of_.binary_._MidX.Mid( bound.lower.mark , bound.upper.mark);
		}
		static public DenomNonnil Mid(this (DenomNonnil, DenomNonnil) bound) {

			return quotient.of_.binary_._MidX.Mid( bound.Item1, bound.Item2);
		}


	}
}
