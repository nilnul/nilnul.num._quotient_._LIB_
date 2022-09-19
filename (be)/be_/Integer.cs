using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{

	public class Integer
			:
		nilnul.num.quotient.BeA,
		nilnul.num.quotient.BeI4

	{
		public override bool be(Q1 obj)
		{
			return obj.denominator1.en==1;
		}

		static public Integer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Integer>.Instance;
			}
		}

	}



}
