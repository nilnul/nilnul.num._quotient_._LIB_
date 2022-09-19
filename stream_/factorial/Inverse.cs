using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.factorial
{
	[Obsolete("",true)]
	public class Inverse : nilnul.num.quotient.stream.op_.unary_._inverse.Ret
	{
		public Inverse() : base(
			new Factorial()
		)
		{
		}
	}
}
