using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.nonfloaty_.farright.to_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ToFloatyX
	{
		/// <summary>
		/// append zeros such as to accomodate <see cref="radix_.Floaty.POINT"/>;
		/// eg:
		///		01230e3
		///		=>
		///		012300e0
		/// </summary>
		/// <param name="_farright"></param>
		/// <returns> there is no need to return indic as it's always nil;</returns>
		///
		static public num_.Radix2 _Precision_0farright(
			quotient_.nonneg_.RadixI _farright
		)
		{
			return 	new nilnul.num_.Radix2(
				_farright.precision.radic
				,
				new str_.List(
					_farright.precision.gits.Select(
						x => new Num1(x.eeByRef)
					).Concat(
						Enumerable.Repeat(
							0, (int)_farright.indic
						).Select(
							i => new Num1(i)
						)
					)
				)
			);
		}

	
	}
}