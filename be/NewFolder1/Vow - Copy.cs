using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	[Obsolete()]
	public class Vow1<TBe>
		: nilnul.obj.be.Vow2<nilnul.num.Quotient1, TBe>
		,
		nilnul.num.quotient.VowI1
		where TBe : nilnul.num.quotient.BeI3, new()
	{
		public void vow(QuotientI obj)
		{
			base.vow(new Quotient1(obj));
		}
	}
}
