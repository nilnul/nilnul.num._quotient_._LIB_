using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.op_
{
	public class Inverse
	{
		static public StreamI3 Eval(StreamI3 s) {
			return new _inverse.Ret(s);
		}
	}
}
