using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.border.duo.be_.nonempty.noZero
{
	[Obsolete()]
	public class Invertible
		: BeI
	{

		static public readonly Invertible Singleton = SingletonByDefault<Invertible>.Instance;




		public bool be(Duo x)

		{
			return Nonempty.Eval(x) && (!x.contains(0)) &&
				quotient.border.be_.Invertible.Singleton.be(x.lower)
				&&
				quotient.border.be_.Invertible.Singleton.be(x.upper)
				;

		}


		public class En
			: nilnul.be.Asserted<Duo, Invertible>
		{
			public En(Duo val) : base(val)
			{
			}

			static public En Inverse(En x)
			{

				return new En(
					new Duo(
						nilnul.num.quotient.border.be_.Invertible.En._Inverse(x.val.upper)
						,
						nilnul.num.quotient.border.be_.Invertible.En._Inverse(x.val.lower)
					)
				);

			}

			static public En Inverse(duo.be_.Nonempty.En x)
			{
				return Inverse(new En(x.val));
			}

		}


	}

}
