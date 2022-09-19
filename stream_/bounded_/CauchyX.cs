using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.quotient.stream_.bounded_
{
	public static class CauchyIX
	{

		public static void Void_halve(this CauchyI r)
		{
			while (r.bound.diameter != 0)
			{
				r.makeBoundDiameterLt(

					new quotient_.Positive1(
						r.bound.diameter / 2

					)
				);

			}




		}


		static public void Squeeze(this stream_.bounded_.CauchyI cauchy, quotient_.Positive1 diameter)
		{
			while (
				cauchy.bound.isNotDiameterLt(diameter)
			)
			{
				(cauchy ).next();
			}
		}

		static public void _Clamp2UnitFrac(this CauchyI x, BigInteger denominator_positive)
		{
			x.makeBoundDiameterLt(
				new quotient_.Positive1(1,denominator_positive)
				
			);

		}


		static public num.quotient_.radix_.Dec1 Dec_digitsAftDot(this CauchyI x, uint digitsAftDot)
		{
			x.makeBoundDiameterLt(
				new quotient_.Positive1(
					 nilnul.num.Quotient1.CreateUnit(
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10, digitsAftDot)

					)
				)
			);

			return nilnul.num.quotient_.radix_.Dec1.FroQuotient(x.bound.midPoint, digitsAftDot);


		}



	}

}
