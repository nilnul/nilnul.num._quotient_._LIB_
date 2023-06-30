using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.nonfloaty_.farleft.to_
{
	static public class _ToFloatyX
	{
		/// <summary>
		/// eg:
		///		01230 e-7
		///		=>
		///		0001230 e-7
		/// </summary>
		/// <param name="_farleft"></param>
		/// <param name="_prependings"></param>
		/// <returns>
		/// there is no need to return the indic, as it's the negative of the count of the precision;
		/// </returns>

		static public num_.RadixI _Precision_0farleft_1needed(quotient_.nonneg_.RadixI _farleft, int _prependings)
		{
			return radix.of_.unary_._PrependNilsX.__Precision_1nonneg(
				_farleft,_prependings
			);
		



		}
		static public num_.RadixI _Precision_0farleft_1needed(quotient_.nonneg_.RadixI indicPosible, BigInteger prependings)
		{
			return _Precision_0farleft_1needed(indicPosible, (int)prependings);
		}

		static public num_.RadixI _Precision_0farleft(
			quotient_.nonneg_.RadixI indicPosible
		)
		{

			return _Precision_0farleft_1needed(
				indicPosible
				,
				nonneg_.radix.be_._farleft._PrependsNeededX.PrependsNeeded(indicPosible)
			);
		}


	}
}