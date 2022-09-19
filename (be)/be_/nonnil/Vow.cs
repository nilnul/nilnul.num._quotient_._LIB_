using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be_.nonnil
{
	public class Vow:nilnul.num.quotient.be.Vow<NotNil>
		,
		nilnul.num.quotient.VowI3
	{

		static public Vow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow>.Instance;
			}
		}

		public void vow(QuotientI1 obj)
		{
			vow( new Quotient1(obj) );
		}
	}
}
