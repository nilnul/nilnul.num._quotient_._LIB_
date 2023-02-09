using nilnul.num.quotient.be_.approx_;
using nilnul.num.quotient_.denomNonnil_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.re_.approx_
{
	public class PerKilo
		: Approx
	{
		public PerKilo() : base(new quotient_.DenomNonnil(1,1024) )
		{
		}


		static public PerKilo Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<PerKilo>.Instance;
			}
		}



	}
}
