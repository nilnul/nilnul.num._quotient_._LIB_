using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.positive_
{
	public class LeTwo
		: nilnul.num.quotient.BeI3
	{
		public bool be(Quotient1 obj)
		{
			return obj > 0 && obj <= 2;
		}

		public bool be(QuotientI obj)
		{
			return be(new Quotient1(obj));
		}


		static public LeTwo Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LeTwo>.Instance;
			}
		}

	}
}
