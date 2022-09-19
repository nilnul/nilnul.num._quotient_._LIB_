using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.op_._accumulate
{
	[Obsolete(nameof( num.quotient.stream.Series1))]
	
		public class Series : StreamI3, IEnumerable<Q1>
		{

			private StreamI3 _stream;

			public StreamI3 stream
			{
				get { return _stream; }
				set { _stream = value; }
			}

			public Series(StreamI3 stream)
			{
				_stream = stream;
			}

			private Q1 _sum = Q1.CreateZero();

			public Q1 sum
			{
				get { return _sum = Q1.CreateZero(); }
				set { _sum = value; }
			}


			public IEnumerator<Q1> GetEnumerator()
			{
				while (true)
				{
					yield return next();
				}
				//
				throw new NotImplementedException();
			}

			public Q1 next()
			{
				_sum += _stream.next();
				return _sum;
				throw new NotImplementedException();
			}



			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
				throw new NotImplementedException();
			}


		}



	
}
