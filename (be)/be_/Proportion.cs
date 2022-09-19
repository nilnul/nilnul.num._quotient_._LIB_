using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._quotient.fraction.op;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{
	/// <summary>
	/// (0,1)
	/// </summary>
	public class Proportion
		:
		nilnul.num.quotient.BeI4
	{
		public bool be(Q1 obj)
		{
			return obj>=0 && obj <= 1;
		}

		static public Proportion Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Proportion>.Instance;
			}
		}
	}
}