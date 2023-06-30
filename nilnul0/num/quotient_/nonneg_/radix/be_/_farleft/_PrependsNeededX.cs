using nilnul.num.integer.be_.nonpos.vow;
using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.be_._farleft
{
	/// <summary>
	/// eg:
	///		01230 * 10^-7, where the point has to be floated leftward 7 chars, but the precision has only 5 chars; so we need to prepend 2chars, where -2 = -(-7 +5)
	/// </summary>
	/// alias:
	///		farleft
	///		IsPointTooLeft
	///	<see cref="radix_.nonfloaty_.IFarleft"/>
	static public class _PrependsNeededX
	{
		/// <summary>
		/// take the left border of precision as the new origin, and view the coord of the indic; and the coord resulted shall be positive; if it's negative, that means the indic is too far, and we need prepend 0s to increase count, resulting a leftward moving of the coord to make it nonneg;
		/// </summary>
		/// <param name="precision"></param>
		/// <returns>
		/// how much to the right of the origin coordinate; we need to increase count to make it nonneg;
		/// 
		/// </returns>
		/// alias:
		///		PrependsNeededNegated
		///		
		public static BigInteger IndicCoordIfAnchored8leftOf0precision1indic(num_.RadixI precision, Ee indic)
		{
			return  precision.gits.Count()+ indic.eeByRef ;

		}
		static public BigInteger IndicCoordIfAnchored8left(this quotient_.nonneg_.RadixI radix)
		{
			return  radix.precision.gits.Count()+ radix.indic ;
		}

		/// <summary>
		/// converted to the overreach leftward anchored at the original origin, that is, the right border of the precision;
		/// </summary>
		/// <param name="radix"></param>
		/// <returns></returns>
		static public BigInteger PrependsNeeded(this quotient_.nonneg_.RadixI radix)
		{
			return -IndicCoordIfAnchored8left(radix);
		}

	}
}
