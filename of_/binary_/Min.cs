using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary_
{

	public class Min
		:
		quotient_.denomNonnil.of_.Binary4interfaceI
	{
		public quotient_.DenomNonnil op(quotient_.DenomNonnil par, quotient_.DenomNonnil par1)
		{
			return par <= par1 ? par : par1;
			//throw new NotImplementedException();
		}
		public quotient_.DenomNonnilI op(quotient_.DenomNonnil par, quotient_.DenomNonnilI par1)
		{
			return par <= par1 ? par : par1;
			//throw new NotImplementedException();
		}

		public DenomNonnilI op(DenomNonnilI par, DenomNonnilI par1)
		{
			return op(par.ToImpl(),par1);
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
