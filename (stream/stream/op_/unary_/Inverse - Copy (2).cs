using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.op_.unary_
{
	

	public class Alternate : UnaryI
	{
		public StreamI6 op(StreamI6 par)
		{
			return _InverseX.Op(par);
		}

		static public Alternate Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Alternate>.Instance;
			}
		}

	}
}
