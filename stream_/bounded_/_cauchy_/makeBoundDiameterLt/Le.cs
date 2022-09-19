using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.stream_.bounded_._cauchy_.makeBoundDiameterLt
{
	public abstract class LeA : MakeBoundDiameterLtI
		,
		MakeBoundDiameterLeI
	{
		public abstract void makeBoundDiameterLt(Positive1 boundStrictlyShorterThanThis);
		public void makeBoundDiameterLe(Positive1 boundStrictlyShorterThanThis)
		{
			makeBoundDiameterLt(boundStrictlyShorterThanThis);
		}

	}
}
