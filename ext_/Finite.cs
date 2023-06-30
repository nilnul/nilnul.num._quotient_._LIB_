using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.quotient_.DenomNonnilI;

namespace nilnul.num.quotient.ext_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		finite
	public  class Finite
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


		public Finite(Q1 r)
			
		{
			_q = q;

		}

		public Finite(nilnul.num.quotient_.DenomNonnil r):this((Q1)r)
		{

		}

		static public implicit operator Finite(int i) {
			return new Finite(i);
		} 

		static public implicit operator Finite(nilnul.num.quotient_.DenomNonnil i) {
			return new Finite(i);
		} 

		static public Finite CreateZero() {
			return new Finite(0);
		}
	}


}
