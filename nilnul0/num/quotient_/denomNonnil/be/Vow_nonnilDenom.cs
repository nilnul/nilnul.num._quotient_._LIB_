using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	public class Vow_nonnilDenom
		: nilnul.obj.be.Vow4<nilnul.num.QuotientI_nonnilDenom>

		,
		nilnul.num.quotient.VowI_nonnilDenom
	{
		public Vow_nonnilDenom(BeI1<QuotientI_nonnilDenom> be) : base(be)
		{
		}

		public Vow_nonnilDenom(Predicate<QuotientI_nonnilDenom> predicate) : base(predicate)
		{
		}

		public Vow_nonnilDenom(Func<QuotientI_nonnilDenom, bool> func) : base(func)
		{
		}
	}

}
