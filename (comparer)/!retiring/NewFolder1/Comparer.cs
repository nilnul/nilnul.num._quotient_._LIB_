using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;//.rational.Rational_InheritFraction2;


namespace nilnul.num.quotient
{
	[Obsolete()]
	public partial class Comparer
		: IComparer<Q>
	{
		static public Comparer Singleton = SingletonByDefault<Comparer>.Instance;

		static public int Eval(Q x, Q y

			) {
				return (x - y).signInInt;
		}
		public int Compare(Q x, Q y)
		{
			return (x - y).signInInt;

			throw new NotImplementedException();
		}
		
	}

}
