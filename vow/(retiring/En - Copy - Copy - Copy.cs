using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.vow
{
	public class En3<TVow> :
		nilnul.obj.vow.En<Quotient1, TVow>
		where TVow : nilnul.num.quotient.VowI2, new()
	{
		public En3(nilnul.num.Quotient1 val) : base(val)
		{
		}
		

	}
}
