using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary_
{

	public class Min
		:
		quotient_.denomNonnil.op_.BinaryI
	{
		public Quotient_NonnilDenom op(Quotient_NonnilDenom par, Quotient_NonnilDenom par1)
		{
			return par <= par1 ? par : par1;
			//throw new NotImplementedException();
		}


		static public Min Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Min>.Instance;
			}
		}

	}
}
