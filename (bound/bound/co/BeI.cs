using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound.co
{
	public interface BeI : nilnul.obj.BeI1<nilnul.num.quotient.bound.Co>
	{
	}

	public abstract class BeA : BeI
	{
		public abstract bool be(Co obj);
		public bool be(
			nilnul.num.quotient.Bound bound
			,
			nilnul.num.quotient.Bound bound1
		)
		{
			return be(new Co(bound, bound1));
		}

	}
}
