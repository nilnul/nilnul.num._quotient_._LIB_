using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_
{
	[Obsolete()]
	public class Repeater : StreamI6
	{
		private Q1 _q;

		public Q1 q
		{
			get { return _q; }
			set { _q = value; }
		}

		public Repeater(Q1 q)
		{
			_q = q;
		}

		public Repeater(nilnul.num.QuotientI q):this( new Q1(q))
		{
		}

		public  Q1 next()
		{
			return _q;
		}
	}
}
