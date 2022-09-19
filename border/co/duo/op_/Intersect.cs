using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border;

namespace nilnul.num.quotient.borderDuo.duo.op_
{
	public class Intersect
		: borderDuo.duo.OpI
	{
		public border.Duo eval(border.Duo a, border.Duo b)
		{
			return new border.Duo(
				nilnul.num.quotient.border.comparer_.Lower.Max(
					a.lower
					,
					b.lower
				)
				, 
				nilnul.num.quotient.border.comparer_.Upper.Min(
					a.upper
					, b.upper

				)
			);


			//throw new NotImplementedException();
		}


		static public readonly Intersect Singleton = SingletonByDefault<Intersect>.Instance;

	}
}
