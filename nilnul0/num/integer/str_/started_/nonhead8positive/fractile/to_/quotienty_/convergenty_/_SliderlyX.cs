using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.to_.quotienty_.convergenty_
{
	/// <summary>
	/// we need to make the binary operation left associative;
	/// </summary>
	static public class _SliderlyX
	{

		static public DenomNonnil _ToQuotient_0fractile(IEnumerable<BigInteger> adders) {

			var addersCount = adders.Count();

			if (addersCount ==1)
			{
				return new DenomNonnil( adders.First() );
			}


			var slider = new fractile.convergents_.plural_._Slider(adders);

			while (--addersCount >1) ///adders.count -2
			{
				slider.moveNext();
			}

			return slider.ahead;

			
		}

		public static DenomNonnil _ToQuotient_0fractile(IEnumerable<int> x)
		{
			return _ToQuotient_0fractile(
				x.Select(t=>(BigInteger)t)
			);
		}
	}
}
