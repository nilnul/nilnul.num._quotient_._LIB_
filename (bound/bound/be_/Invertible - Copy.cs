using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range.be_
{
	[Obsolete()]
	public class Invertible
		: nilnul.num.quotient.range.BeI1
	{
		public bool be(Range1 x)
		{
			return (!x.contains(0)) &&
				quotient.border.be_.Invertible1.Singleton.be(x.lower)
				&&
				quotient.border.be_.Invertible1.Singleton.be(x.upper)
				;
		}

		static public Invertible Singleton
		{
			get
			{
				return nilnul.Singleton1<Invertible>.Instance;
			}
		}
	}
}