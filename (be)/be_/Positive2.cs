using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_
{

	public  class Positive2
			:
		
		nilnul.num.quotient.BeI2

	{
		static public bool Be(
			Q1 x
		)
		{
			return x > 0;
			
		}
		static public bool Eval(
			Q1 x
		)
		{
			return Be(x);
			
		}

		public bool be(Quotient1 obj)
		{
			return Be(obj);
		//	throw new NotImplementedException();
		}

		


		static public Positive2 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive2>.Instance;
			}
		}















	}



}
