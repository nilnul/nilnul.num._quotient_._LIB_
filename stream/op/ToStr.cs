using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;
using nilnul.num._num.bigint.be;
using System.Numerics;

namespace nilnul.num.quotient.stream.op
{
	public class ToStr
	{


		public class Call : 
			nilnul.obj.op.Call_ArgA<StreamI2>
			,
			StrI1
		{

			public Call(StreamI2 str, Natural.Asserted length )
				:base(str)
			{
				_length = length;

			}

			public Q this[BigInteger index]
			{
				get
				{
					return ElementAt.Eval(arg, index);

					throw new NotImplementedException();
				}
			}
			private Natural.Asserted _length;
			public Natural.Asserted count
			{
				get
				{
					throw new NotImplementedException();
				}
			}
		}

	}
}
