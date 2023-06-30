using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.of_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _AppendNilX
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
		static public (num_.Radix2 precision, BigInteger indic) _Duo_1nonneg(
			quotient_.nonneg_.RadixI _farright
			,
			int nils
		)
		{
			return (
				new nilnul.num_.Radix2(
					_farright.precision.radic
					,
					new str_.List(
						Enumerable.Repeat(
							BigInteger.Zero, nils
						)
						.Concat(
							_farright.precision.gits.Select(x=>x.eeByRef)
						)
						.Select(
							i => new Num1(i)
						)
					)
				)
				,
				_farright.indic - nils
			);
		}

		static public (num_.Radix2 precision, BigInteger indic) _Duo_1nonneg(
			quotient_.nonneg_.RadixI _farright
			,
			BigInteger nils
		)
		{
			return _Duo_1nonneg(_farright, (int)nils);
		}
		static public Radix _Radix_1nonneg(
			quotient_.nonneg_.RadixI _farright
			,
			BigInteger nils
		)
		{
			return new Radix(
				_Duo_1nonneg(_farright, nils)
			);
		}


	}
}