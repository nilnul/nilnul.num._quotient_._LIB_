using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound
{
	public class Co : nilnul.obj.Co<nilnul.num.quotient.Bound>
	{
		public Co(Tuple<Bound, Bound> tuple) : base(tuple)
		{
		}

		public Co(Bound item1, Bound item2) : base(item1, item2)
		{
		}
	}
}
