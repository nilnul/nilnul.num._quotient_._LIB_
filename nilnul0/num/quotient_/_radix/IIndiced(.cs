using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._radix
{

	/// <summary>
	/// b^i, where b is <see cref="num_.Plural1"/> as the base, i is an integer as the indicand
	/// eg:
	///		2^10
	///		10^-1
	///		16^0
	/// </summary>
	/// <remarks>
	/// this is used in <see cref="num.quotient_.IRadix"/>
	/// </remarks>
	/// nomenclature:
	///		no need to place under namespace <see cref="radic"/>, as radic is already contained in <see cref="quotient_.nonneg_.Radix.precision"/>
	/// alias:
	///		indicator
	///		
	///		indicance
	///		amplitude
	///		window
	///			like a window between two number of consecutive ponents;
	///		positional
	///		weight
	internal interface IIndiced
	{
	}


}
