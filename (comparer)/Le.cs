using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;//.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;//.rational.Rational_InheritFraction2;

namespace nilnul.num.quotient
{
	public partial class Le
		:
		nilnul.comparer.AsEq_comparerDefault<Q1,Le>
		
		
	
		,
		IComparer<Q1>


	{
		static public Le Singleton = SingletonByDefault<Le>.Instance;

		static public int Eval(Q1 x, Q1 y

			) {
				return (x - y).signInInt;
		}
		public int Compare(Q1 x, Q1 y)
		{
			return (x - y).signInInt;

			throw new NotImplementedException();
		}
		
	}

}
