using nilnul.num.quotient_.denomNonnilEs;
using nilnul.objs_.headed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient_.denomNonnilEs_.headed.to_
{
	public  class Avg
		:
		headed.to_.ScalarI

	{
		
		public Quotient_NonnilDenom to(
			IEnumerable<Quotient_NonnilDenom>			src
		)
		{
			return src.Sum() / src.Count();
		}

		public Quotient_NonnilDenom to(
			(Quotient_NonnilDenom, IEnumerable<Quotient_NonnilDenom>)
			src
		)
		{
			return to(
				src.AsSeq()
			);
		}

		static public Avg Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Avg>.Instance;
			}
		}


	}
}
