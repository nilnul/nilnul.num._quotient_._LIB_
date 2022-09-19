using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.be.en_
{
	public class BeDefaulted<TBe>
		: nilnul.obj.be.en_.BeDefaulted1<nilnul.num.Quotient1, TBe>
		where TBe : nilnul.num.quotient.BeI4, new()
	{
		public BeDefaulted(Quotient1 val) : base(val)
		{
		}
	}
}
