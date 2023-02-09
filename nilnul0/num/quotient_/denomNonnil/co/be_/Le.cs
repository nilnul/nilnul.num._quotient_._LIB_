using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.co.be_
{
	public class Le
		:
		
		co.BeI

	{
		

		//public bool be(ref (Quotient_NonnilDenom, Quotient_NonnilDenom) obj)
		//{
		//	return obj.Item1 <= obj.Item2;
		//}

		public bool be(in (DenomNonnil, DenomNonnil) obj)
		{
			return obj.Item1 <= obj.Item2;
		}

		public bool be((DenomNonnil, DenomNonnil) obj)
		{
			return be(in obj);
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
