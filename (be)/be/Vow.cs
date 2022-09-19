using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be
{
	public class Vow3<TBe>
		: nilnul.obj.be.Vow2<nilnul.num.Quotient1, TBe>
		,
		nilnul.num.quotient.VowI2
		,
		nilnul.num.quotient.VowI3
		where TBe : nilnul.num.quotient.BeI4, new()
	{
		public void vow(QuotientI1 obj)
		{
			 base.vow(new Quotient1(obj));
		}
	}
}
