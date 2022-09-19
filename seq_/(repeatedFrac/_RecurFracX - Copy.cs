using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// a finite sequence 
	/// </summary>
	///
	[Obsolete()]
	static public class _RecurFracX
	{
		static public nilnul.num.Quotient Construct(nilnul.num.quotient.continuedFrac_.ForIrrational src) {
			var frac = nilnul.num.quotient.continuedFrac.to_.Quotient.Singleton.to(src);
			return new nilnul.num.Quotient( 
				frac.numerator
				,frac.denominator
			);

		}
	}
}
