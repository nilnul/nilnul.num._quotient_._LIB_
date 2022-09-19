using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.border.duo.be_;
using R1 = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.range.op_
{
	public partial class Negate
		: OpI
	{

		static public readonly Negate Singleton = SingletonByDefault<Negate>.Instance;


		public R1 eval(R1 arg)
		{
			return _negate.Extensions.Negate(arg);

			throw new NotImplementedException();
		}
	}
}
