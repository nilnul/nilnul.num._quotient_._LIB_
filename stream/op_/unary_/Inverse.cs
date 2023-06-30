using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.op_.unary_
{
	static public class _InverseX
	{
		static public StreamI6 Op(StreamI6 s) {
			return new _inverse.Ret(s);
		}
	}

	public class Inverse : UnaryI
	{
		public StreamI6 op(StreamI6 par)
		{
			return _InverseX.Op(par);
		}

		static public Inverse Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inverse>.Instance;
			}
		}

	}
}
