using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Ext = nilnul.num.quotient._ext.ExtI;

namespace nilnul.num.quotient.ext
{
	public partial class Comparer
		:
		integer._ext._generic.Comparer_useInf_ComparerDefault<Q,quotient.Comparer,_ext.ExtI>
		
	{

		static public Comparer Singleton = SingletonByDefault<Comparer>.Instance;


		static public bool Gt(Ext a, Ext b) {
			return Singleton.Compare(a, b) > 0;
		}
		static public bool Eq(Ext a, Ext b) {
			return Singleton.Compare(a, b) == 0;
		}

		static public bool Lt(Ext a, Ext b) {
			return Singleton.Compare(a, b) < 0;
		}
		
	}
}
