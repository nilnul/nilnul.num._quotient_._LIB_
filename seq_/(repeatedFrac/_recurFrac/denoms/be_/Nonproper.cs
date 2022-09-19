using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._recurFrac.denoms.be_
{
	static public class _NonproperX
	{
		static public bool Be(IEnumerable<nilnul.num_.Positive1> denoms) {
			return denoms.Any() && denoms.Last().en == 1;
		}

		static public bool Be(_recurFrac.Denoms denoms) {
			return Be(denoms.denominators);
		}
	}

	public class Nonproper : denoms.Be
	{
		public Nonproper() : base(_NonproperX.Be)
		{
		}


		static public Nonproper Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonproper>.Instance;
			}
		}

	}
}
