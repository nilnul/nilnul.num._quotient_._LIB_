using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient.stream._instanceS
{
	public class Inverse : StreamI1
	{
		private BigInteger _denominator=0;

		public BigInteger denominator
		{
			get { return _denominator; }
			set { denominator = value; }
		}

		public IEnumerator<Q> GetEnumerator()
		{

			while (true)
			{
				yield return next();
			}
			//throw new NotImplementedException();
		}

		public Q next()
		{
			//_denominator++;
			return Q.Inverse(++_denominator);

			throw new NotImplementedException();
		}

		public void reset()
		{
			_denominator = 0;
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}


	}
}
