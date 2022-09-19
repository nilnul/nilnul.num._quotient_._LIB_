using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow.ee_
{
	public class VowDefaulted1<TVow> :
		quotient.vow.Ee< TVow>
		where TVow : nilnul.obj.VowI2< nilnul.num.QuotientI1>, new()
	{
		public VowDefaulted1(QuotientI1 val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
