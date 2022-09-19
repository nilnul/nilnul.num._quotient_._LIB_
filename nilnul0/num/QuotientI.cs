using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{

	//[Obsolete(nameof(nilnul.num.Quotient) + " is enough. unlike nilnul.num.RealI, which we don't have a unified type to represent all real numbers; here we can have one uniform type to represent all quotient numbers.")]

	/// <summary>
	/// interface is necessary as we have some vowee such as nilnul.num.quotient_.Positive, which is a box of quotient while subtyping quotient
	/// </summary>

	public interface QuotientI1:_quotient_.NumeratorI, _quotient_.DenominatorI1
		,
		IQuotient
	{



	}
}
