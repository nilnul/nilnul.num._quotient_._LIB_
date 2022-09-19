using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;
using B = nilnul.num.quotient.Bound;

namespace nilnul.num.quotient.bound.re_
{
	public class Joint
		: nilnul.num.quotient.bound.ReI
	{
		public bool re(Bound d, B r)
		{
			return q.border.co.be_.Dwelt.Singleton.be(
				q.bound.co._IntersectX.Intersect(d, r)
			);

		}



		static public Joint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint>.Instance;
			}
		}

	}
}
