using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.op
{
	[Obsolete()]
	public  class MakeSeries
	{
		public class CallAsStream_ofStream3 : StreamI3, IEnumerable<Q1>
		{

			private StreamI3 _stream;

			public StreamI3 stream
			{
				get { return _stream; }
				set { _stream = value; }
			}

			public CallAsStream_ofStream3(StreamI3 stream)
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
				//throw new NotImplementedException();
			}

			public Q1 next()
			{
				_sum += (_stream as nilnul._stream_.NextI<Q1>).next();
				return _sum;
				throw new NotImplementedException();
			}



			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
				throw new NotImplementedException();
			}


		}



		[Obsolete()]

		public class CallAsStream_ofStream2 : StreamI2 ,IEnumerable<Q>
		{

			private StreamI2 _stream;

			public StreamI2 stream
			{
				get { return _stream; }
				set { _stream = value; }
			}

			public CallAsStream_ofStream2(StreamI2 stream)
			{
				_stream = stream;
			}

			private Q _sum = Q.CreateZero();

			public Q sum
			{
				get { return _sum = Q.CreateZero(); }
				set { _sum = value; }
			}


			public IEnumerator<Q> GetEnumerator()
			{
				while (true)
				{
					yield return next();
				}
				//
				//throw new NotImplementedException();
			}

			public Q next()
			{
				_sum += (_stream
					//as nilnul._stream.NextI<Q>
				).next();
				return _sum;
				throw new NotImplementedException();
			}

			public void reset()
			{
				_stream.reset();
				_sum = 0;
				return;

				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
				throw new NotImplementedException();
			}
		}

		[Obsolete()]

		public class CallAsStream:StreamI2,StreamI1
		{

			private StreamI1 _stream;

			public StreamI1 stream
			{
				get { return _stream; }
				set { _stream = value; }
			}

			public CallAsStream(StreamI1 stream)
			{
				_stream = stream;
			}

			private Q _sum=Q.CreateZero();

			public Q sum
			{
				get { return _sum=Q.CreateZero(); }
				set { _sum=value; }
			}


			public IEnumerator<Q> GetEnumerator()
			{
				while (true)
				{
					yield return next();
				}
				//
				throw new NotImplementedException();
			}

			public Q next()
			{
				_sum+=_stream.next();
				return _sum;
				throw new NotImplementedException();
			}

			public void reset()
			{
				_stream.reset();
				_sum = 0;
				return;

				throw new NotImplementedException();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
				throw new NotImplementedException();
			}
		}
	}
}
