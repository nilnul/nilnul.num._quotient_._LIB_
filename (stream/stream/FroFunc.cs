using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream
{
	public class FroFunc:StreamI3
	{
		private Func<N, Q1> _func;
		public FroFunc(Func<N,Q1> f)
		{
			_func = f;
		}

		private nilnul.num.stream_.Num _num = new num.stream_.Num();
		public Q1 next()
		{
			return _func(_num.next());

			//throw new NotImplementedException();
		}
	}
}
