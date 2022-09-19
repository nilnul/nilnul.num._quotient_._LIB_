using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.quotient.stream_.bound_
{
	public static class CauchyIX
	{

		public static void Void_halve(this CauchyI r)
		{
			if (r.bound.diameter!= 0)
			{
				foreach (var item in r.clamp(

					new quotient_.Positive1(
						r.bound.diameter / 2

					)
				))
				{

				}
				

			}



		}
		//static public void _Clamp2UnitFrac(this CauchyI x, BigInteger denominator_positive)
		//{
		//	x.clamp(

		//		nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(
		//				new nilnul._num.bigint.be.Positive.Asserted(
		//					denominator_positive
		//				)

		//		)
		//	);

		//}


		static public num.quotient_.radix_.Dec1 Dec_digitsAftDot(this CauchyI x, uint digitsAftDot)
		{
			x.clamp(
				new quotient_.Positive1(
					 nilnul.num.Quotient1.CreateUnit(
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10, digitsAftDot)

					)
				)
			).Each();

			return nilnul.num.quotient_.radix_.Dec1.FroQuotient(x.bound.midPoint, digitsAftDot);


		}



	}

}
