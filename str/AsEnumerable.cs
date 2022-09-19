using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.str
{
	public class AsEnumerable
		:
		nilnul.num.type.str.AsEnumerable<Q, StrI>
	{

		

		public AsEnumerable(StrI str):base(str)
		{

		}

	}
}
