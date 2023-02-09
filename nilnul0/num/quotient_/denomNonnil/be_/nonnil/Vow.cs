using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.be_.nonnil
{
	public class Vow:nilnul.num.quotient_.denomNonnil.be.vow_.BeDefault<quotient.be_.NotNil>
		
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
			vow( new quotient_.DenomNonnil(obj) );
		}
	}
}
