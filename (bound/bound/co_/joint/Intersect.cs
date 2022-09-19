using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Range = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.bound.co_.joint
{
	static public  class _IntersectX
	{
		
		/// <summary>
		/// may throw exception
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public Bound Intersect(
			this 
			Bound x
			,
			Bound y
			
		) {

			return new Bound(

				co._IntersectX._Intersect(x.en,y.en	)
				

			);

		//	throw new NotImplementedException();
		
		}
		static public Bound Intersect(
			this 
			BoundI x
			,
			BoundI y
			
		) {

			return new Bound(

				co._IntersectX._Intersect(x,y	)
				

			);

		//	throw new NotImplementedException();
		
		}


	}
}

