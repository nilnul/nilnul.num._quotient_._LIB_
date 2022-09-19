using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient_NonnilDenom;

namespace nilnul.num.quotient_.denomNonnil
{

	public interface BeI
		:

		nilnul.obj.BeI_ofIn<Q1>
		

	{

	}

	public abstract class BeA :
		nilnul.obj.BeA_ofIn<Q1>
		,

		BeI
	{
		//public abstract bool be(in Q1 obj);
		//public bool be( Q1 q) {
		//	return be(in q);
		//}
	}
}
