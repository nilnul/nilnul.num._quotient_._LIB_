using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.continuedFrac_;
using System.Numerics;
using nilnul.num.natural;
using nilnul.num.rational.cf;
using nilnul._num.bigint.be;

namespace nilnul.num.quotient_.recurFrac.fro_.dbl_
{
	[Obsolete(nameof(integer.str_.started_.nonhead8positive.fractile.of_.dbl_) )]
	static public class _PrecisionedX
	{
		
	


		static public quotient_.RecurFrac RecurFrac(double src, nilnul.num.quotient_.NonnegI precision) {
			var floorTail = nilnul_obj.num.NumX.FloorAndTail(src);

			var tail = floorTail.Item2;

			return new quotient_.RecurFrac(
				floorTail.Item1
				,
				_recurFrac.denoms.fro_.dblNonnegLeOne_._PrecisionedX._assumeDblIsNonnegLeOne(floorTail.Item2, precision)
			);

		

		}
		public static quotient_.RecurFrac RecurFrac(double src, Positive1 precision)
		{
			return RecurFrac(src, new nilnul.num.quotient_.Nonneg(precision) );
		}

		public static num.Quotient1 Quotient(double src, Positive1 precision)
		{
			return RecurFrac(src, (precision) );
		}

	}
}
