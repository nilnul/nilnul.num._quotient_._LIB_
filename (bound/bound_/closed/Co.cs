using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound_.closed
{
	public class Co : nilnul.obj.Co<Closed>
	{
		public Co(Tuple<Closed, Closed> tuple) : base(tuple)
		{
		}

		public Co(Closed item1, Closed item2) : base(item1, item2)
		{
		}
	}
}
