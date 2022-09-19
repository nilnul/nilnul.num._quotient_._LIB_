using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;


namespace nilnul.num.quotient
{
	[Obsolete()]
	 public  class Eq
		 :IEqualityComparer<Q>
	{

		

	
		

		public bool Equals(Q x, Q y)
		{
			return x - y == 0;


			throw new NotImplementedException();
		}

		public int GetHashCode(Q obj)
		{
			return obj.numerator.GetHashCode() ^ obj.denominator.GetHashCode();
			throw new NotImplementedException();
		}
	}

	
}
