using nilnul.num.integer.be_.nonpos.vow;
using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.be_
{
	/// <summary>
	/// eg:
	///		01230 * 10^-7, where the point has to be floated leftward 7 chars, but the precision has only 5 chars; so we need to prepend 2chars, where -2 = -(-7 +5)
	/// </summary>
	/// alias:
	///		farleft
	///		IsPointTooLeft
	///	<see cref="radix_.nonfloaty_.IFarleft"/>
	static public class _FarleftX
	{
		

		static public  bool IsPointOverMostSignificant(this quotient_.nonneg_.RadixI radix)
		{
			return _farleft._PrependsNeededX.IndicCoordIfAnchored8left(radix)  <0;
		}

		public static bool IsFarleftOf0precision1indic(num_.RadixI radix, Ee mantissa)
		{
			return _farleft._PrependsNeededX.IndicCoordIfAnchored8leftOf0precision1indic(radix,mantissa)  <0;

		}
	}
}
