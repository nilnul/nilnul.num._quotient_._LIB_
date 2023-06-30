using nilnul.num.quotient_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	public class Vow4DenomNonnil
		: nilnul.obj.be.Vow_ofIn<nilnul.num.quotient_.DenomNonnilI>
		
		,
		nilnul.num.quotient.Vow4DenomNonnilI
	{
		public Vow4DenomNonnil(in BeI_ofIn<DenomNonnilI> val) : base(val)
		{
		}

		public Vow4DenomNonnil(BeI_ofIn<DenomNonnilI> x) : base(x)
		{
		}

	}

}
