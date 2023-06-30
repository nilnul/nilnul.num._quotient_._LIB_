using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.frac.of_.binary_
{
	static public class _TweenX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>
		/// a frac between the the two inputs; that is, in [a,b]
		/// </returns>
		static public DenomNonnil _Tween_01frac(DenomNonnil a, DenomNonnil b) {
			return new DenomNonnil(
				a.numerator+b.numerator
				,
				a.denominator+b.denominator
			);
		}
	}
}
