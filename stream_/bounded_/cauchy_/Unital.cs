using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.stream_.bounded_.cauchy_
{
	public class Unital : nilnul.num.quotient.stream_.slider_.Unital
		, CauchyI
	{
		public Bound bound => Bound.CreateOpenClose(0, current);

		public void makeBoundDiameterLt(Positive1 diameter)
		{
			while (bound.isNotDiameterLt(diameter) )
			{
				moveNext();
			}
			//throw new NotImplementedException();
		}


	}
}
