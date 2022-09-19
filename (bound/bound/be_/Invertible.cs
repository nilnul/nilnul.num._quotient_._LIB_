using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.bound.be_
{

	public class Invertible
		: nilnul.num.quotient.bound.BeI2
	{
		public bool be(Bound x)
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
				return nilnul.obj_.Singleton<Invertible>.Instance;
			}
		}

	}
}