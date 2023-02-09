using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.QuotientI;



namespace nilnul.num.quotient_.denomNonnilEs.to_.scalar_
{
	 public class Sum
		:
		to_.ScalarI
	{
	

		public DenomNonnil to(IEnumerable<DenomNonnil> src)
		{
			return src.Aggregate(
				DenomNonnil.Nil
				,
				(a,c) =>a+c
			);

		}


		static public Sum Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Sum>.Instance;
			}
		}

	}
}
