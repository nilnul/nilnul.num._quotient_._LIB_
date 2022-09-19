using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream_
{
	public class FactorialInversed
		: StreamI3
	{

		private nilnul.num.stream_.Factorial _factorial=new num.stream_.Factorial();

		public nilnul.num.stream_.Factorial factorial
		{
			get { return _factorial; }
			set { _factorial = value; }
		}

		


		public Simplify.Ed1 next()
		{
			return Q1.Divide(1, _factorial.next());

			throw new NotImplementedException();
		}
	}
}
