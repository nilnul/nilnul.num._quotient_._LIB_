using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.be_
{

	 public  class Nonpositive:BeI4
	{
		

		public bool be(Q1 obj)
		{

			return obj.numerator <= 0;

		}

		

		static public Nonpositive Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonpositive>.Instance;
			}
		}






	}



}
