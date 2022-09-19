using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow
{
	public class Ee<TVow> :
		nilnul.obj.vow.Ee1<QuotientI1, TVow>
		where TVow : nilnul.obj.VowI2<QuotientI1>
	{
		public Ee(nilnul.num.QuotientI1 val, TVow vow) : base(val, vow)
		{
		}
		

	}

	public class Ee :
		Ee< nilnul.obj.VowI2<QuotientI1>>
	{
		public Ee(nilnul.num.QuotientI1 val,nilnul.obj.VowI2<QuotientI1> vow) : base(val, vow)
		{
		}
		

	}


}
