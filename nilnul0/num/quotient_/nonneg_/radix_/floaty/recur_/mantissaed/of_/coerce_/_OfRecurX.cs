using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_.coerce_
{
	static public class _OfRecurX
	{


		public static Mantissaed Of(quotient_.nonneg_.radix_.floaty.RecurI recur)
		{
			if (recur is Mantissaed f)
			{
				return f;
			}

			var toDecrease = recur.period.eeByRef - recur.floaty.mantissa;

			if (toDecrease<=0)
			{
				return new Mantissaed(
					recur.floaty
					,
					recur.period
				);
			}
			return new Mantissaed(
				floaty.recur.of_.unary_._DecreaseIndicX._Duo_0nonneg(recur,toDecrease)
				,recur.period
			);

		}

		public static Mantissaed Of(quotient_.nonneg_.radix.RecurI recur)
		{
			if (recur is Mantissaed f)
			{
				return f;
			}

			return Of( radix_.floaty.recur.of_._CoerceX.ToFloatyRecur(
				recur
			));

		}


	}
}
