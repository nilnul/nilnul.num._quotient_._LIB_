using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.bound_.closed.stream_.slider_.nested_._cauchy_.makeDiameterLt
{
	public abstract class LeA : MakeDiameterLtI
		,
		MakeDiameterLeI
	{
		public abstract void makeDiameterLt(Positive1 boundStrictlyShorterThanThis);
		public void makeDiameterLe(Positive1 boundStrictlyShorterThanThis)
		{
			makeDiameterLt(boundStrictlyShorterThanThis);
		}

	}
}
