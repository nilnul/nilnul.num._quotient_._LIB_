using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.bound_.closed.be_
{

	public class Invertible
		: nilnul.num.quotient.bound_.closed.BeI
	{
		public bool be(Closed x)
		{
			return !x.contains(0) 
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