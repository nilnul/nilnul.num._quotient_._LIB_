using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream._combine.ret_
{
	public class Add : num.quotient.stream._combine.Ret
	{
		public Add(Co duo) : base(duo, num.quotient.combine_.Add.Instance)
		{
		}

		public Add(StreamI6 a, StreamI6 b) : base(a, b,  num.quotient.combine_.Add.Instance)
		{
		}

		public Add(BigInteger x, StreamI6 y) : base(x, y,  num.quotient.combine_.Add.Instance)
		{
		}
	}
}
