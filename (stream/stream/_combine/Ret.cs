using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream._combine
{
	public class Ret:
		nilnul.obj.Box< num.quotient.CombineI2>
		,
		StreamI6
	{
		private Co _duo;

		public Co duo
		{
			get { return _duo; }
			set { _duo = value; }
		}
		public Ret( Co duo ,num.quotient.CombineI2 combine):base(combine)
		{
			_duo = duo;
		}
		public Ret(StreamI6 a,StreamI6 b,num.quotient.CombineI2 combine):this(new Co(a, b),combine)
		{

		}

		public Ret(BigInteger x, StreamI6 y,num.quotient.CombineI2 combine):this(
			new nilnul.num.quotient.stream_.Repeater(x),y,combine
		)
		{

		}

		public Q1 next()
		{
			return
				boxed.combine(
				((_duo.Item1) as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next() , ((_duo.Item2) as nilnul.obj._stream_.NextI<nilnul.num.Quotient1>).next()
			);

		}
	}
}
