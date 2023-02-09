using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range_.invertible.op_.unary_
{
	[Obsolete()]
	static public class _InverseX
	{
		static public Range1 _Range_assumeInvertible(Range1 _invertible)
		{

			return
				new Range1(
					nilnul.num.quotient.border.op_.unary_._InverseX.Inverse(_invertible.upper)
					,
					nilnul.num.quotient.border.op_.unary_._InverseX.Inverse(_invertible.lower)
				)
			;

		}


		static public Range1 Range(Invertible x)
		{

			return
				_Range_assumeInvertible(x.en)
			;

		}

		static public Range1 Range(Range1 x)
		{

			return
				Range( new range_.Invertible(x))
			;

		}


		static public Invertible Invertible(Invertible x)
		{

			return new Invertible(
				Range(x)
			);

		}

		static public Invertible Invertible(Range1 x)
		{

			return new Invertible(
				Range(x)
			);

		}

	}
}
