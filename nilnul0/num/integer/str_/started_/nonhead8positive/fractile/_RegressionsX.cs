using nilnul.num.natural;
using nilnul.num.rational.cf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile
{
	static public class _RegressionsX
	{
		static public ContinuedFraction2 ToContinuedFraction2(
			this Fractile fractile
		)
		{

			var nonflown = fractile_.nonflown.of_.coerce_._CollapseX.Collapse(
				fractile
			);

			return new ContinuedFraction2(
				nonflown.floor
				,
				nonflown.denoms.Select(x=> new PositiveNatural_inheritNatural(x))
			);


		}

	
	}
}
