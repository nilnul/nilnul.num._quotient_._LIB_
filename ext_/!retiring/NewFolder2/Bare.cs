using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.ext_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		finite
	public partial class Bare
		:
		ExtA,
		nilnul.ext_.BareI<Q1>
		,
		ExtI
		

	{
		private Q1 _q;

		public Q1 q
		{
			get { return _q; }
			set { _q = value; }
		}


		public Bare(Q1 r)
			
		{
			_q = q;

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
