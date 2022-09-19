using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range.be_
{
	public class Nonnil
		: nilnul.num.quotient.range.BeI1
	{

		public bool be(Range1 x)

		{
			return !x.containsZero();

		}

		static public Nonnil Singleton
		{
			get
			{
				return nilnul.Singleton1<Nonnil>.Instance;
			}
		}

	}

	
}
