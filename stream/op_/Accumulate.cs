using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.op_
{
	public class Accumulate : OpI
	{

		static public readonly Accumulate Singleton = SingletonByDefault<Accumulate>.Instance;

		public StreamI3 eval(StreamI3 arg)
		{
			return new _accumulate.Series(arg);

			throw new NotImplementedException();
		}
	}
}
