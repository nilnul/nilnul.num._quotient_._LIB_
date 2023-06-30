using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_
{

	/// why exclude 0 for denominator?
	/// <see cref="nilnul.num.quotient_.nonneg_.radix.recur.of_._OfNonnegQuotientX._Of_0plural_1nonneg(System.Numerics.BigInteger, DenomNonnilI)"/>
	/// <summary>
	/// denom is nonnil. It could be positive or negative.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		denomNonnil
	///			we often list the member first before categorizing according to that member;
	///		lax
	///			just ensure that there is no divideByNil exception,which need to be thrown eagerly, while all other cases can be tackled lazily;
	///		lazy
	///		slack
	///		
	public interface IDenomNonnil
		:nilnul.num.IQuotient
	{
	}
}
