using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border.duo.be_.nonempty
{
	public class NoZero
		: BeI
	{

		static public readonly NoZero Singleton = SingletonByDefault<NoZero>.Instance;




		public bool be(Duo x)

		{
			return Nonempty.Eval(x) && (!x.contains(0));

		}
	}

	[Obsolete()]
	public class En
		: nilnul.be.Asserted<Duo, NoZero>
	{
		public En(Duo val) : base(val)
		{
		}






	}
}
