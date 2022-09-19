using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.stream_
{
	/// <summary>
	/// starting from 1/1, 1/2, ...
	/// </summary>
	public class Unitary : StreamI6
		,IEnumerable<Q1>
	{
		private BigInteger _denominator=0;

		public BigInteger denominator
		{
			get { return _denominator; }
			set { denominator = value; }
		}

		public IEnumerator<Q1> GetEnumerator()
		{

			while (true)
			{
				yield return next();
			}
			//throw new NotImplementedException();
		}

		public Q1 next()
		{
			//_denominator++;
			return new Q1(1)/(++_denominator);

			//throw new NotImplementedException();
		}

		public void reset()
		{
			_denominator = 0;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		//	throw new NotImplementedException();
		}


	}
}
