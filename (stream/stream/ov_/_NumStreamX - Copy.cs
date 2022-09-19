using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.ov_
{
	[Obsolete()]
	public  class NumStream : Ov<nilnul.num.StreamI4>
	{
		public NumStream(num.StreamI4 val) : base(val)
		{
		}

		public override Quotient1 next()
		{
			return new Quotient1( boxed.next() );
		}
	}


}
