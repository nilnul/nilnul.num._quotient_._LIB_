using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.bound.be_
{

	public class Closed
		: nilnul.num.quotient.bound.BeI2
	{
		public bool be(Bound x)
		{
			return 
				x.lower.openFalseCloseTrue
				&&
				(x.upper).openFalseCloseTrue
				;
		}

		static public Closed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Closed>.Instance;
			}
		}

	}
}