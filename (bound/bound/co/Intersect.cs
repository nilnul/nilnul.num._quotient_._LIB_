using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Range = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using q = nilnul.num.quotient;
using nilnul.num.quotient.border;

namespace nilnul.num.quotient.bound.co
{
	static public  class _IntersectX
	{
		/// <summary>
		/// internal; lemma. this itself is not well meaningful.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public border.Co _Intersect(border.Co a, border.Co b)
		{
			return new border.Co(
				nilnul.num.quotient.border_.lower.op_.binary_._MaxX.Max(
					a.lower
					,
					b.lower
				)
				,
				nilnul.num.quotient.border_.upper.op_.binary_._MinX.Min(
					a.upper
					, b.upper

				)
			);


			//throw new NotImplementedException();
		}


		static public border.Co _Intersect(border.Duo1 a, border.Duo1 b)
		{
			return _Intersect(
				new border.Co(a.lower,a.upper)
				,
				new border.Co(b.lower,b.upper)
			);
		}

		public static border.Co _Intersect(BoundI x, BoundI y)
		{
			return _IntersectX._Intersect(new border.Co(x.lower,x.upper), new border.Co(y.lower,y.upper));
		}

		/// <summary>
		/// may throw exception
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public quotient.border.Co Intersect(
			this 
			Bound x
			,
			Bound y
			
		) {

			return (

				_Intersect(x.en,y.en	)
				

			);

		//	throw new NotImplementedException();
		
		}

		public static border.Co Intersect(Co obj)
		{
			return Intersect(obj.Item1,obj.Item2);
		}
	}
}

