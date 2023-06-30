using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.nonfarright.to_
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

		static public num_.RadixI _Precision4floaty_0nonfarright(
			quotient_.nonneg_.RadixI _nonfarright 
		)
		{
			var rightwardOverreachIfAnchored8left = nonneg_.radix.be_._farleft._PrependsNeededX.IndicCoordIfAnchored8left(
				_nonfarright
			);
			var asInt = (int)rightwardOverreachIfAnchored8left;

			if (asInt < 0)
			{
				return nonfloaty_. farleft.to_._ToFloatyX._Precision_0farleft_1needed(
					_nonfarright,-asInt
				);
			}
			return 	_nonfarright.precision;
		}
		static public (num_.RadixI precision, BigInteger indic) _Duo4floaty_0nonfarright(
			quotient_.nonneg_.RadixI _nonfarright 
		)
		{
			return (_Precision4floaty_0nonfarright( _nonfarright), _nonfarright.indic);
		}
	}
}