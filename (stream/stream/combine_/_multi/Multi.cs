using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream.combine_._multi
{
	public class Ret:StreamI6
	{
		private Co _duo;

		public Co duo
		{
			get { return _duo; }
			set { _duo = value; }
		}
		public Ret(Co duo)
		{
			_duo = duo;
		}
		public Ret(StreamI6 a,StreamI6 b):this(new Co(a, b))
		{

		}

		public Ret(BigInteger x, StreamI6 y):this(
			new nilnul.num.quotient.stream_.Repeater(x),y
		)
		{

		}

		public Q1 next()
		{
			return
				nilnul.num.quotient.combine_.Multi.Singleton.combine(
				((_duo.Item1) as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next() , ((_duo.Item2) as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next()
			);

		}
	}
}
