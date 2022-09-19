using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient._streamS
{
	public partial class Basel : StreamI1
	{

		private BigInteger	_index;

		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}

		

		


		private Q _accumulatedSum=0;

		public Basel()
		{
			_index = 0;
		}

		public Q next()
		{
			


			return _accumulatedSum += Q.Inverse(op.SquareX.Square((Q)(++_index)) );


			throw new NotImplementedException();
		}

		public void reset()
		{
			_index = 0;
			_accumulatedSum = 0;
			

			//throw new NotImplementedException();
		}

		static public Q Item(int i) {
			Basel	 stream = new Basel();

			var i1 = 0;
			while (i1++<i)
			{
				stream.next();
			}
			return stream.next();
		}

		public IEnumerator<Q> GetEnumerator()
		{

			yield return next();

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			//throw new NotImplementedException();
		}
	}
}
