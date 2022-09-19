using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.ov_
{
	public  class NumStream1 : Ov<nilnul.num.StreamI6>
	{
		public NumStream1(num.StreamI6 val) : base(val)
		{
		}

		public override Quotient1 next()
		{
			return new Quotient1( boxed.next() );
		}
	}


}
