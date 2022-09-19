using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.positive
{
	public class Co
		:
		nilnul.obj.Co<nilnul.num.quotient_.Positive1>
	{
		public Co(Tuple<Positive1, Positive1> tuple) : base(tuple)
		{
		}

		public Co((Positive1, Positive1) valTuple) : base(valTuple)
		{
		}

		public Co(Positive1 item1, Positive1 item2) : base(item1, item2)
		{
		}
	}
}
