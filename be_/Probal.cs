using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.bound_.bity_;
using nilnul.num.quotient_;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{
	/// <summary>
	/// [0,1]
	/// </summary>
	///
	public class Probal
		:
		nilnul.num.quotient.Be4DenomNonnilImplA
		,
		nilnul.num.quotient.BeI4
		,
		nilnul.num.quotient.Be4DenomNonnilInterfaceI

	{
		public bool be(Q1 obj)
		{
			return obj>=0 && obj <= 1;
		}

		public override bool be(in DenomNonnil val)
		{
			return val >= 0 && val <= 1;
		}

	

		static public Probal Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Probal>.Instance;
			}
		}
	}

}