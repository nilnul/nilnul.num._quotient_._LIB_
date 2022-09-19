using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow.ee_
{
	public class VowDefault<TVow> :
		nilnul.obj.vow.ee_.Defaultable<nilnul.num.QuotientI1, TVow>
		where TVow : nilnul.num.quotient.VowI3, new()
	{
		public VowDefault(QuotientI1 val) : base(val)
		{
		}
	}
}
