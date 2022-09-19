using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;
using nilnul._num.bigint.be;
using nilnul.num_;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// guratee that denominator is positive. simplify process is expensive and unnecessary in some cases like comparison of equality.
	/// </summary>
	public interface ByRefI
		:
		_quotient_.numerator_.ByRefI
		,
		_quotient_.denominator_.ByRefI
		,
		num.IQuotient
		
	{



	



	}
}
