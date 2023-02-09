using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.quotient_.DenomNonnilI;

namespace nilnul.num.quotient_.denomNonnil.be_
{

	public  class Nonneg
			:
		num.quotient_.denomNonnil.BeA

	{

		public override bool be(in DenomNonnilI obj)
		{
			return obj.numerator==0 || Positive.Singleton.be(obj);
		}


		static public Nonneg Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nonneg>.Instance;
			}
		}
	}
}
