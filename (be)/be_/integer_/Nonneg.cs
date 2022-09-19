using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.integer_
{
	public class Nonneg
		:
		nilnul.num.quotient.BeA,

		nilnul.num.quotient.BeI5
	{
		public override bool be(Quotient1 obj)
		{
			return Integer.Singleton.be(obj) && obj.numerator>=0;
		}

		


		static public Nonneg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg>.Instance;
			}
		}

	}
}
