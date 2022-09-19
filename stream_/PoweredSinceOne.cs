using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using Qc = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_
{
	[Obsolete(nameof(nilnul.num.quotient.slider_.geometric_.std.Stream))]
	public class PoweredSinceOne1
		: 
		nilnul.num.quotient.StreamI6
	{
		

		public PoweredSinceOne1(Q1 q)
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


		public Q1 next()
		{
			return _accumulated *= _q;
		}
	}
}
