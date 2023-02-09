using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;


namespace nilnul.num.quotient.bound_.closed.stream_.slider_.nested_._cauchy_.makeDiameterLe
{
	public abstract class LtA : MakeDiameterLeI
		,
		MakeDiameterLtI
	{
		public abstract void makeDiameterLe(Positive1 boundStrictlyShorterThanThis);
		public void makeDiameterLt(Positive1 boundStrictlyShorterThanThis)
		{
			makeDiameterLe(boundStrictlyShorterThanThis/2u);
		}

	}
}
