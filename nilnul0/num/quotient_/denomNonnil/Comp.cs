using nilnul.num.quotient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.quotient_.DenomNonnilI;//.rational.Rational_InheritFraction2;

namespace nilnul.num.quotient_.denomNonnil
{
	public  class Comp
		:
		IComparer<Q1>
		,
		IComparer<DenomNonnil>
	{
		public int Compare(Q1 x, Q1 y)
		{
			return (x.ToImpl() - y).SignAsInt();
		}

		public int Compare(DenomNonnil x, DenomNonnil y)
		{
			return (x - y).SignAsInt();
		}

		static public Comp Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Comp>.Instance;
			}
		}
	}
}