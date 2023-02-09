using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.quotient_.DenomNonnilI;

namespace nilnul.num.quotient_.denomNonnil.be_
{

	public  class Positive
			:
		num.quotient_.denomNonnil.BeA

	{

	

		public override bool be(in DenomNonnilI obj)
		{
			return obj.denominator.eeByRef>0? obj.numerator>0: obj.numerator<0;
		}


		static public Positive Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive>.Instance;
			}
		}















	}



}
