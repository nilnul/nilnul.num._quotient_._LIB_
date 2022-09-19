using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Q1 = nilnul.num.QuotientI;


namespace nilnul.num.quotient
{
	[Obsolete()]
	 public  class Eq1
		 :IEqualityComparer<Q1>
	{


		public bool Equals(Q1 x, Q1 y)
		{
			return nilnul.num.quotient.be_.Zero.Singleton.be(  
				nilnul.num.quotient.combine_.Minus.Singleton.eval(x,y) 
			);


			throw new NotImplementedException();
		}

		public int GetHashCode(Q1 obj)
		{
			return obj.numerator.GetHashCode() ^ obj.denominator.GetHashCode();
			throw new NotImplementedException();
		}

		static public readonly Eq1 Singleton = nilnul.obj.SingletonByDefault<Eq1>.Instance;

	}

	
}
