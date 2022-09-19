using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_
{
	public class Rigid :
		nilnul.obj.stream_.Fixed<nilnul.num.Quotient1>
		,
		StreamI6
	{
		public Rigid(Q1 q):base(q)
		{
		}
		public Rigid(nilnul.num.QuotientI q):this( new Q1(q))
		{
		}
	}
}
