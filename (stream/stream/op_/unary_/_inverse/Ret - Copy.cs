using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num.quotient.stream.op_._inverse
{
	public class Ret : _op.Ret
	{
		public Ret(StreamI3 stream) : base(stream)
		{

		}

		public override Simplify.Ed1 next()
		{
			return 1/boxed.next();
			//throw new NotImplementedException();
		}
	}
}
