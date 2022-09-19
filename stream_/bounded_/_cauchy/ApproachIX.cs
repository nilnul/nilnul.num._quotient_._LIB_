using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_._cauchy
{
	public static class ApproachX
	{

		public static void Void_halve(this ApproachI r)
		{
			if (r.range.diameter!= 0)
			{
				r.squeeze(

					new quotient_.Positive1(
						r.range.diameter/2

					)
				);

			}



		}


		static public num.quotient_.radix_.Dec1 Dec_digitsAftDot(this ApproachI x, uint digitsAftDot)
		{
			x.squeeze(
				new quotient_.Positive1(
					 nilnul.num.Quotient1.CreateUnit(
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10, digitsAftDot)

					)
				)
			);

			return nilnul.num.quotient_.radix_.Dec1.FroQuotient(x.range.midPoint, digitsAftDot);


		}



	}

}
