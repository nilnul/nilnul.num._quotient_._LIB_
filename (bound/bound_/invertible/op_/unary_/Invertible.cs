using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.bound_.invertible.op_.unary_
{
	static public class _InverseX
	{
		static public Bound _Bound_assumeInvertible(Bound _invertible)
		{
			return
				new Bound(
					nilnul.num.quotient.border.op_.unary_._InverseX.Inverse(_invertible.upper)
					,
					nilnul.num.quotient.border.op_.unary_._InverseX.Inverse(_invertible.lower)
				)
			;
		}


		static public Bound Bound(bound_.Invertible x)
		{

			return
				_Bound_assumeInvertible(x.en)
			;

		}

		static public Bound Bound(Bound x) 
		{

			return
				Bound( (Bound)new bound_.Invertible(x))
			;

		}


		static public Invertible Invertible(Invertible x)
		{

			return new Invertible(
				Bound((Bound)x)
			);

		}

		static public Invertible Invertible(Bound x)
		{

			return new Invertible(
				Bound(x)
			);

		}

	}
}
