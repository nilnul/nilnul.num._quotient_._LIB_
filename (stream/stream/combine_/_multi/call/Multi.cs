using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.duo.op.call
{
	[Obsolete()]
	public class Multi:StreamI3
	{
		private Duo _duo;

		public Duo duo
		{
			get { return _duo; }
			set { _duo = value; }
		}
		public Multi(StreamI3 a,StreamI3 b):this(new Duo(a, b))
		{

		}

		public Multi(BigInteger x, StreamI3 y):this(
			new nilnul.num.quotient.stream.eg.Repeater(x),y
		)
		{

		}

		public Multi(Duo duo)
		{
			_duo = duo;
		}
		public Simplify.Ed1 next()
		{
			return (_duo.Item1 as nilnul._stream_.NextI<Q1>).next() * (_duo.Item2 as nilnul._stream_.NextI<Q1>).next();
			throw new NotImplementedException();
		}
	}
}
