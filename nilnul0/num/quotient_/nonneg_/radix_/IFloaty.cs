using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_
{
	/// <summary>
	/// eg:
	///		123e456 is a radix, but not a floaty; it can be converted to floaty by appending 456 nils;
	///		123e-4 is a radix, but not a floaty; it can be converted to 0123e-4, then phrased as .0123; not before being converted, it's not possible to insert the point;
	///	So indic must be nonpositive; and moreover, the presion's width must be ge the abs of indic;
	/// </summary>
	/// <remarks>
	/// the indic must be in a range: [nonpositive,  -the precision(count of magnitude)]
	/// the indic is nonpositve, 
	/// </remarks>
	/// alias:
	///		pointed
	///		dottd
	///		floaty
	///			the point can float, with respect to "fixed point" numeral;
	///		floay
	///		floatible
	public interface IFloaty:IRadix
	{

	}
}
