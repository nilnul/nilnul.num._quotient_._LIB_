using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{

	//[Obsolete(nameof(nilnul.num.Quotient) + " is enough. unlike nilnul.num.RealI, which we don't have a unified type to represent all real numbers; here we can have one uniform type to represent all quotient numbers.")]
	//[Obsolete(nameof(nilnul.num.Quotient) + " is enough.")]
	[Obsolete(nameof(nilnul.num.QuotientI1))]
	public interface QuotientI:_quotient_.NumeratorI, _quotient_.DenominatorI
	{



	}
}
