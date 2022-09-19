using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.stream_.bounded_.cauchy_
{
	public class UnitalOscilated : nilnul.num.quotient.stream_.slider_.unital.Alt
		, CauchyI
	{
		public Bound bound => Bound.CreateClose_orderIfNecessary(-current, current);

		public void makeBoundDiameterLt(Positive1 diameter)
		{
			CauchyA.Squeeze(this, diameter);
		}


	}
}
