using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

using Q1 = nilnul.num.QuotientI;

namespace nilnul.num.quotient.be_
{
	public class Zero
		: nilnul.num.quotient.BeI1
	{
		public bool be(Q1 obj)
		{
			return obj.numerator == 0;
			throw new NotImplementedException();
		}


		static public readonly Zero Singleton = nilnul.obj.SingletonByDefault<Zero>.Instance;


	}
}
