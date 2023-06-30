using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient._ext
{
	[Obsolete("Bare")]
	public partial class Base
		:
		
		nilnul.num._ext._generic.UnExt<Q>
		,
		ExtI
		

	{

		public Base(Q r)
			:base(r)
		{

		}

		static public implicit operator Base(int i) {
			return new Base(i);
		} 

		static public implicit operator Base(Q i) {
			return new Base(i);
		} 

		static public Base CreateZero() {
			return new Base(0);
		}
	}


}
