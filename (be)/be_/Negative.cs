using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{

	public  class Negative
			:

		nilnul.num.quotient.BeI4

	{
		static public bool Be(
			Q1 x
		)
		{
			return x < 0;
			
		}

		public bool be(Quotient1 obj)
		{
			return Be(obj);
		}



		static public Negative Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Negative>.Instance;
			}
		}


	}



}
