using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	static public class _CeilX
	{
		static public BigInteger Ceil(nilnul.num.Quotient1 quotient) {
			return nilnul.num.quotient_.FlooredX.Ceil(quotient);
		}
		static public BigInteger Ceil(nilnul.num.QuotientI1 quotient) {
			return nilnul.num.quotient_.FlooredX.Ceil(quotient);
		}


	}
}
