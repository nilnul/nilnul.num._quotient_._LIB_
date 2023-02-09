using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	static public class _SignX1
	{
		static public bool? BitNulable(
			nilnul.num.Quotient1 q
		) {
			return nilnul.num.integer._SignX.BitNulable(q.numerator);
		}

		static public nilnul.num.integer._sign.Ret Sign(nilnul.num.Quotient1 q) {
			return nilnul.num.integer._SignX.Sign1(q.numerator);

		}



		static public int Int(
					nilnul.num.Quotient1 q
	
			) {

			return nilnul.num.integer._SignX.Int(q.numerator);

		}
		static public int SignAsInt(
			this nilnul.num.quotient_.DenomNonnilI q
		) {

			var s= q.numerator.Sign;
			if (s==0)
			{
				return 0;
			}

			return q.denominator.eeByRef>0 ? s: -s;

		}


	}
}
