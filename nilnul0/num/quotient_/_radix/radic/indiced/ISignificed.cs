using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._radix.radic.indiced
{
	///  integer * base ^ indicand;
	/// integer with Indicand;
	/// 
	/// leading nils are insignificant;
	/// <summary>
	/// c* i, where c is an integer as significand, and i is <see cref="IIndiced"/>
	/// ;eg:
	///		-0345e-127
	///			where we use only lowercase "e", not 'E' which is used in complex number, such as 3.5E-1.2 which is equal to 3.5 (cos(-1.2)+i sin(-1.2));
	/// </summary>
	/// <remarks>
	/// when converted to <see cref="num.quotient_.IRadix"/>, the significand and the indicand shall use the same base;
	/// we base on this to define <see cref="num.quotient_.IRadix"/>, which is also <see cref="nilnul.txt_.IQuotient"/>
	/// 
	/// </remarks>
	/// alias:
	///		floaty
	///		indiced
	/// 
	public interface ISignificed
	{
	}
}
