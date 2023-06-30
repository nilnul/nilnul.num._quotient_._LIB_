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

namespace nilnul.num.quotient_.recurFrac.fro_
{
	[Obsolete()]
	static public class _DblX
	{
		

		static public RecurFrac RecurFrac(double src) {
			var floorTail = nilnul_obj.num.NumX.FloorAndTail(src);

			var tail = floorTail.Item2;


			return new RecurFrac(
				floorTail.Item1,
				_recurFrac.denoms.fro_._FroDblNonnegLeOneX._ofNonnegLeOne(tail)
			);

		}


		static public nilnul.num.Quotient1 Quotient(double src) {

			return RecurFrac(src);
		}


		



	}
}
