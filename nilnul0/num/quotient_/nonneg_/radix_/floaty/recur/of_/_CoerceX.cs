using System;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_
{
	static public class _CoerceX
	{
		public static radix_.floaty.Recur ToFloatyRecur(this quotient_.nonneg_.radix.RecurI recur)
		{
			if (recur is radix_.floaty.Recur f)
			{
				return f;
			}

			if (recur.radix.indic > 0)
			{
				return new Recur(
					nonneg_.radix.recur.of_.unary_._DecreaseIndicX._AsRecur_1pos(
						recur,
						recur.radix.indic
					)
				);
			}
			return new Recur(
				new Floaty(
				nonneg_.radix_.nonfarright.to_._ToFloatyX._Duo4floaty_0nonfarright(recur.radix)
				)
				,
				recur.period
			);


		}
	
		public static Recur ToFloatyRecur(RadixI unsigned, int cycle)
		{
			return ToFloatyRecur(
				new radix.Recur(unsigned, cycle)
			);

		}
	}
}
