using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.quotient_.DenomNonnilI;

namespace nilnul.num.quotient.ext_.inf_
{
	public  class Neg
		:
		ExtA,
		nilnul.ext_.InfI<Q1>
		,
		ExtI
	{


		static public Neg Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neg>.Instance;
			}
		}

	}
}
