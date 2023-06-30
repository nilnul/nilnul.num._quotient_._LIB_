using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient._ext
{
	public partial class Bare
		:
		nilnul.num._ext._generic.Bare<Q1>
		,
		ExtI1
		

	{

		public Bare(Q1 r)
			:base(r)
		{

		}

		static public implicit operator Bare(int i) {
			return new Bare(i);
		} 

		static public implicit operator Bare(Q1 i) {
			return new Bare(i);
		} 

		static public Bare CreateZero() {
			return new Bare(0);
		}
	}


}
