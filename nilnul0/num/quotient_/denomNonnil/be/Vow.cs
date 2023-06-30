using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.be
{
	public class Vow
		: nilnul.obj.be.Vow_ofIn<DenomNonnilI>
		,
		nilnul.num.quotient_.denomNonnil.VowI
		,
		num.quotient.Vow4DenomNonnilI
	{
		public Vow(in BeI_ofIn<DenomNonnilI> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<DenomNonnilI> x) : base(x)
		{
		}

		public void vow(in DenomNonnil obj)
		{
			base.vow( obj);
		}
	}
}
