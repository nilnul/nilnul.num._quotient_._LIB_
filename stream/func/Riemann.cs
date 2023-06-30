using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient.stream.func
{
	public partial class Riemann : StreamI1
	{


		private BigInteger _n;

		public BigInteger n
		{
			get { return _n; }
			set { _n = value; }
		}


		public Riemann(BigInteger n)
		{
			_n = n;
		}

		private BigInteger	_index;

		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}

		private Q _accumulatedSum=0;

		public Riemann()
		{
			_index = 0;
		}

		public Q next()
		{
			


			return _accumulatedSum += Q.Inverse(quotient.op.PowX.Do( ++_index, _n));


			throw new NotImplementedException();
		}

		public void reset()
		{
			_index = 0;
			_accumulatedSum = 0;
			

			//throw new NotImplementedException();
		}

		static public Q Item(int i) {
			Riemann	 stream = new Riemann();

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
