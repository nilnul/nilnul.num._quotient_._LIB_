using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.of_.unary_
{
	static public class _PrependNilsX
	{
		static public num_.Radix2 __Precision_1nonneg(quotient_.nonneg_.RadixI radix, int prependings)
		{
			return 	new nilnul.num_.Radix2(
						radix.precision.radic
						,
						new str_.List(
							radix.precision.gits.Select(
								x=>new Num1(x.eeByRef)
							).Concat(
								Enumerable.Repeat(
									0, prependings
								).Select(
									i => new Num1(i)
								)
							)	//note:here the gits is little1st;
						)
			);

		}
		static public num_.Radix2 __Precision_1nonneg(quotient_.nonneg_.RadixI radix, BigInteger prependings)
		{
			return __Precision_1nonneg(radix, (int)prependings);
		}

		static public num_.RadixI _Precision_1nil0pos(quotient_.nonneg_.RadixI radix, int prependings)
		{
			if (prependings ==0)
			{
				return radix.precision;
			}
			return 	__Precision_1nonneg(radix,prependings);

		}

	

		static public num_.RadixI _Precision_1nil0pos(quotient_.nonneg_.RadixI radix, BigInteger prependings)
		{
			return _Precision_1nil0pos(radix, (int)prependings);
		}


	}
}