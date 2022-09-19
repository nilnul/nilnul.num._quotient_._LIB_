using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream
{


	public class AsEnumerable
		:nilnul.collection.recur.type.stream.AsEnumerable<Q,StreamI2>
	{

		public AsEnumerable(StreamI2 stream)
			:base(stream)
		{

		}

	}

	static public class AsEnumerableX {
		static public AsEnumerable AsEnumerable(this StreamI2 stream) {
			return new AsEnumerable(stream);
		}
	}
}
