using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream_
{
	[Obsolete(nameof(nilnul.num.quotient.slider_.geometric_.std.Stream))]
	public class Powered
		: nilnul.num.quotient.StreamI3
	{
		

		public Powered(Q1 q)
		{
			_q = q;
			_accumulated = 1;
		}

		private Q1 _accumulated;

		public Q1 accumulated
		{
			get { return _accumulated; }
			set { _accumulated = value; }
		}

		private Q1 _q;

		public Q1 q
		{
			get { return _q; }
			set { _q = value; }
		}


		public Simplify.Ed1 next()
		{
			var r = _accumulated;
			_accumulated *= _q;
			return r;

			throw new NotImplementedException();
		}
	}
}
