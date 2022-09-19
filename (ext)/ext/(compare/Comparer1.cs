using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using Ext = nilnul.num.quotient._ext.ExtI;

namespace nilnul.num.quotient.ext
{
	public partial class Comparer1
		:
		nilnul.ext.comparer_.FroBareStatic<Q1, quotient.Comparer1>
		
	{

		static public Comparer1 Singleton = SingletonByDefault<Comparer1>.Instance;


		static public bool Gt(ExtI a, ExtI b) {
			return Singleton.Compare(a, b) > 0;
		}
		static public bool Eq(ExtI a, ExtI b) {
			return Singleton.Compare(a, b) == 0;
		}

		static public bool Lt(ExtI a, ExtI b) {
			return Singleton.Compare(a, b) < 0;
		}
		
	}
}
