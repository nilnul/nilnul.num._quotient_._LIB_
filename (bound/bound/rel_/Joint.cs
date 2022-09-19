using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.range.rel_
{
	public class Joint
		: nilnul.num.quotient.range.RelI
	{
		public bool contains(Nonempty.En d, Nonempty.En r)
		{
			return q.border.duo.be_.Nonempty.Eval(
				q.borderDuo.duo.op_.Intersect.Singleton.eval(d, r)
			);


			//throw new NotImplementedException();
		}


		static public readonly Joint Singleton = SingletonByDefault<Joint>.Instance;

	}
}
