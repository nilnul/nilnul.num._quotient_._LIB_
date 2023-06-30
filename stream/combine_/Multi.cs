using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.combine_
{
	public class Multi : quotient.stream.CombineI
	{


		public StreamI6 combine(StreamI6 a, StreamI6 b)
		{
			return new _multi.Ret(a, b);
		}


		static public Multi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi>.Instance;
			}
		}


	}

}
