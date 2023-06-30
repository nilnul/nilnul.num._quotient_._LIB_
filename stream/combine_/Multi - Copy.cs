using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.duo.op
{
	[Obsolete()]
	public class Multi : OpI
	{

		static public readonly Multi Singleton = SingletonByDefault<Multi>.Instance;

		public StreamI3 eval(StreamI3 a, StreamI3 b)
		{
			return new call.Multi(a, b);
			throw new NotImplementedException();
		}

		static public StreamI3 Eval(_quotient.fraction.op.Simplify.Ed1 a, StreamI3 b) {
			return new call.Multi(new nilnul.num.quotient.stream.eg.Repeater(a), b);
		}

	}

	static public class MultiX
	{
		static public StreamI3 Multi(this StreamI3 stream,StreamI3 stream1) {
			return op.Multi.Singleton.eval(stream, stream1);
		}
	}
}
