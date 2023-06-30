using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_
{
	/// <summary>
	/// defined by IEEE:  <see cref="double"/>
	/// </summary>
	/// <remarks>
	/// the canonical place to process <see cref="double"/>
	/// </remarks>
	/// alias:
	///		dbl
	///			reserved to a shorter namespace; but dbl is more intuitive;
	///		bin
	///			bin is more explicit for its base, to be distinct from <see cref="IDec"/>
	/// 
	/// <seealso cref="quotient_.radix.ext.errable_.ieee_.IBin"/>, which can be regarded as <see cref="nilnul.txt_.IQuotient"/> but this is preferred as <see cref="ext"/> is more canonical  and when we have constrain this to an ext then to a finite, we can put the related processing there;
	/// 
	/// <see cref="quotient_.radix.floaty_.ISupunial"/>
	public interface IDbl
	{
	}
}
