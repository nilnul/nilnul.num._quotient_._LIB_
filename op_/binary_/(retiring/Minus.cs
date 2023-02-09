using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.combine_
{
	 public class Minus 
	:CombineI1
	{


		static public readonly Minus Singleton = nilnul.obj.SingletonByDefault<Minus>.Instance;

		public Minus()
		{
		}

		

		

		public QuotientI eval(QuotientI arg, QuotientI arg1)
		{
			return Add.Instance.eval(arg, nilnul.num.quotient.convert_.Negate.Singleton.eval(arg1));

			throw new NotImplementedException();
		}
		public Quotient eval(Quotient arg, Quotient arg1)
		{
			return Add.Instance.eval(arg, nilnul.num.quotient.convert_.Negate.Singleton.eval(arg1));

			throw new NotImplementedException();
		}

		public Quotient1 op(Quotient1 arg, Quotient1 arg1)
		{
			return Add.Instance.op(arg, nilnul.num.quotient.convert_.Negate.Singleton.op(arg1));

			throw new NotImplementedException();
		}

		public Quotient1 combine(QuotientI1 x, QuotientI1 y)
		{
			return Add.Instance.combine(x, nilnul.num.quotient.convert_.Negate.Singleton.convert(y));

		}
	}

	
}
