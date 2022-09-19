using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.be
{
	public class Vow
		: nilnul.obj.be.Vow_ofIn<Quotient_NonnilDenom>
		,
		nilnul.num.quotient_.denomNonnil.VowI
	{
		public Vow(in BeI_ofIn<Quotient_NonnilDenom> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<Quotient_NonnilDenom> x) : base(x)
		{
		}
	}
}
