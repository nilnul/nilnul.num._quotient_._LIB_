using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream.op
{
	static public class _Diff
	{
		static public Q Eval(StreamI2 stream, int count) {
			var r = Q.CreateZero();

			while (count-->0)
			{
				r += stream.next();

			}
			return r;

		}

		static public Q Eval(StreamI2 stream, BigInteger count) {
			var r = Q.CreateZero();

			while (count-->0)
			{
				r += stream.next();

			}
			return r;

		}

	}

	public class Diff
	{
		public class Call : StreamI2
		{



			private StreamI2 _arg;

			public StreamI2 arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			private Q _current=0;

			public Q current
			{
				get { return _current; }
				set { _current = value; }
			}


			public Q next()
			{
				var oldCurrent = _current;

				_current = _arg.next();
				return  _current-oldCurrent;

				throw new NotImplementedException();
			}

			public void reset()
			{
				_arg.reset();
				_current = 0;
				return;
				throw new NotImplementedException();
			}

		}
	}
}
