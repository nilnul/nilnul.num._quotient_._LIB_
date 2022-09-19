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
	public class Joint0Adjacent
		: nilnul.num.quotient.bound.ReI
	{
		public bool re(Bound x, B y)
		{
			return re_.Joint.Singleton.re(x,y)
				||
				bound.co_.disjoint.be_._AdajcentX.Be_assumeDisjoint(x,y);

		}



		static public Joint0Adjacent Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint0Adjacent>.Instance;
			}
		}

	}
}
