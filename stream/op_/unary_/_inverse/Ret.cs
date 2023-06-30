using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream.op_.unary_._inverse
{
	public class Ret : _unary.RetA1
	{
		public Ret(StreamI6 stream) : base(stream)
		{

		}

		public override Quotient1 next()
		{
			return 1/(arg).next();
			//throw new NotImplementedException();
		}
	}
}
