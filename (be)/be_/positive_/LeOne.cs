using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.positive_
{
	public class LeOne
		: nilnul.num.quotient.BeI3
	{
		public bool be(Quotient1 obj)
		{
			return obj > 0 && obj <=1;
		}

		public bool be(QuotientI obj)
		{
			return be(new Quotient1(obj));
		}


		static public LeOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LeOne>.Instance;
			}
		}

	}
}
