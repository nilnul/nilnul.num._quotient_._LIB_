using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.bound_.closed_.invertible.op_.unary_
{
	static public class _InverseX
	{
		static public Closed _Closed_assumeInvertible(Closed _invertible)
		{
			return
				new Closed(
					1/(_invertible.upper.mark)
					,
					1/(_invertible.lower.mark)
				)
			;
		}


		static public Closed Closed(bound_.closed_.Invertible x)
		{

			return
				_Closed_assumeInvertible(x.ee)
			;

		}

		static public Closed Closed(Closed x) 
		{

			return
				Closed( new bound_.closed_.Invertible(x))
			;

		}


		static public Invertible Invertible(bound_.closed_.Invertible x)
		{

			return new Invertible(
				Closed((Closed)x)
			);

		}

		static public Invertible Invertible(Closed x)
		{

			return new Invertible(
				Closed(x)
			);

		}

	}
}
