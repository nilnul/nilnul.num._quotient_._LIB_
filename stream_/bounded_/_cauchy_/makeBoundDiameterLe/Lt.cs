using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;


namespace nilnul.num.quotient.stream_.bounded_._cauchy_.makeBoundDiameterLe
{
	public abstract class LtA : MakeBoundDiameterLeI
		,
		MakeBoundDiameterLtI
	{
		public abstract void makeBoundDiameterLe(Positive1 boundStrictlyShorterThanThis);
		public void makeBoundDiameterLt(Positive1 boundStrictlyShorterThanThis)
		{
			makeBoundDiameterLe(boundStrictlyShorterThanThis/2u);
		}

	}
}
