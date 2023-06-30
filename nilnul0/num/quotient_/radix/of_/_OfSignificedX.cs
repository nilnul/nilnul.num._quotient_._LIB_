using nilnul.num.quotient._radix;
using nilnul.num.quotient_.radix_;
using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.of_
{
	static public class _OfSignificedX
	{

		public static ByNeg ToByNeg(BigInteger radic, SignificandIndex peregrinate)
		{
			return new ByNeg(
				quotient_.nonneg_.radix.of_._OfAmpliticedX._AsRadix_1amplificNonneg(
					radic
				,
					
					peregrinate.unsigned8duo
				
				)
				,
				peregrinate.significand.Sign<0
			);

		}

		public static ByNeg ToRadix((BigInteger radic, SignificandIndex peregrinate) regressed)
		{

			return new ByNeg(
				quotient_.nonneg_.radix.of_._OfAmpliticedX._AsRadix_1amplificNonneg(
					regressed.radic
				,
					
					regressed.peregrinate.unsigned8duo
				
				),
				regressed.peregrinate.significand.Sign<0
			);

		}


		public static ByNeg ToRadix(Based2 periodic)
		{

			var regressed = quotient_._radix.radic.indiced.significed._RegressionsX.AsRadic9sansroot(periodic);

			return ToRadix(regressed);

		}

		public static ByNeg ToByNeg(this Radix1 radix)
		{
			return ToByNeg(
				radix.baseAsBigInt,radix.float_
			);
			//return Radix3.Of((RadixI)radix);
			////radix.toMorePresion
			//var signify = radix.significand;
			//var indic = radix.indicand;
			//if (indic > 0)
			//{
			//	signify *= nilnul.num.op_.binary_._PowX._Op_basePlural_indexPositive(
			//		radix.baseAsBigInt, indic
			//	);
			//	indic = 0;
			//}

			//return new Radix3(
			//	 integer_.Radix.Create(signify,/*new num_.Plural*/(radix.base_.radic))
			//	 ,
			//	  Num_ofIn.Of(-indic)
			//);
		}

		public static ByNeg ToByNeg(this Radix radix)
		{
			return ToByNeg(
				radix.baseAsBigInt,radix.float_
			);


		}


	}
}
