using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt_.frac_
{
	/// <summary>
	/// floating point decimal or any other <see cref="nilnul.txt_.IInteger"/>;
	/// eg:
	///		1.23
	///		.123
	///		123.
	///		0.123
	///		0123.
	///		.0123
	///	-123e-3	is <see cref="num.quotient_._radix.radic.indiced.ISignificed"/> and can be converted to this easily if the indicand and the significand use the same radicand (<see cref="nilnul.num_._radix.Root1"/>);
	/// </summary>
	/// <remarks>
	/// this is placed under <see cref="nilnul.txt_.frac_"/>, as this is more about a txt form to express a quotient number, or in specific terms, the decimal;
	/// </remarks>
	/// <seealso cref="num.quotient_.IRadix"/>
	/// vs:
	///		<see cref="nilnul.num.quotient_.IRadix"/>, which doesnot include alphabet, but includes the index of each <see cref="nilnul.txt_.num_._radix_.GitsI"/>;
	///		<see cref="nilnul.num.quotient_._radix.ISignific1indic"/>, which is in the form of 01340e-09980, but doesnot include a radicand, and without radic, we cannot use txt to express it and we can only express it in quoteint;
	///			to keep the semantics invariant between txt_.radix and quotient_.radix, we put that as quotient_.IFloaty;
	internal class IRadix
	{
	}
}
