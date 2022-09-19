using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient
{
	[Obsolete()]
	public interface BeI4
		:
		nilnul.obj.BeI1<Q1>
		

	{

	}

	public interface BeI5
		:

		nilnul.obj.BeI1<nilnul.num.QuotientI1>
		

	{

	}

	public abstract class BeA : BeI4,BeI5
	{
		public abstract bool be(Q1 obj);
		public bool be(nilnul.num.QuotientI1 q) {
			return be(new Q1(q));
		}
	}
}
