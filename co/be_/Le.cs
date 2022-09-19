using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co.be_
{
	public class Le
		:
		nilnul.num.quotient.co.BeI
		

	{
		public bool be((Quotient_unsimplified, Quotient_unsimplified) obj)
		{
			return obj.Item1 <= obj.Item2;
		}

		public bool be(ref (Quotient_unsimplified, Quotient_unsimplified) obj)
		{
			return obj.Item1 <= obj.Item2;
		}

		

		static public Le Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Le>.Instance;
			}
		}

	}
}
