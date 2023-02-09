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
	/// [0,1)
	/// </summary>
	public partial class Proper:

		nilnul.num.quotient.BeI2
	{
		

		public bool be(Q1 obj)
		{
			return obj>=0 && obj < 1;

			throw new NotImplementedException();
		}

		static public Proper Singleton
		{
			get
			{
				return nilnul.Singleton1<Proper>.Instance;
			}
		}


	}
}
