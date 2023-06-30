using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	public  abstract class ExtA :ExtI
	{

		static public bool operator <(ExtA a, ExtA b) {

			return ext.Comparer1.Singleton.Compare(a, b)<0;
		}

		static public bool operator >(ExtA a, ExtA b) {

			return ext.Comparer1.Singleton.Compare(a, b)>0;
		}


	}
}
