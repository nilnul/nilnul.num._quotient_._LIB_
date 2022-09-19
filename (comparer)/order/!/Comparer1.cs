using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.rational.order
{
	public partial class Comparer1
		: IComparer<Q>
	{
		static public Comparer1 Singleton = SingletonByDefault<Comparer1>.Instance;

		static public int Eval(Q x, Q y

			) {
				return (int)(x - y).sign;
		}
		public int Compare(Q x, Q y)
		{
			return (int)(x - y).sign;

			throw new NotImplementedException();
		}
		
	}

}
