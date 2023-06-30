using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.of_.coerce_
{


	static public class _OfQuotientX
	{
		
		/// <summary>
		/// this will get 
		/// </summary>
		/// <param name="src"></param>
		/// <returns></returns>
		static public   RecurFrac ToRecurFrac(this nilnul.num.Quotient1 src)
		{
			var tailed = nilnul.num.quotient_.FlooredX.ToFloored(src);
			return new RecurFrac(
				tailed.floor
				,
                quotient_._recurFrac.denoms.fro_._FroNonnegLeOneX._Positives_ofNonnegLeOne(tailed.proper)
			);
		}
	}
}
