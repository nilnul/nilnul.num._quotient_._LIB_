using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q0 = nilnul.num.QuotientI;//.quotient.Q;
using Q1 = nilnul.num.QuotientI;//._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient.be_
{

	 public  class Nonneg1:BeI3
	{
		

		public bool be(Q1 obj)
		{

			return obj.numerator >= 0;

			//throw new NotImplementedException();
		}

		public bool be(Quotient1 obj)
		{
			return be((Q1)obj);

		}

		static public Nonneg1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg1>.Instance;
			}
		}






	}



}
