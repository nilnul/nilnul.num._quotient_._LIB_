using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient.stream._instanceS
{
	[Obsolete()]
	public class SeriesFroInverse:op.MakeSeries.CallAsStream
	{

		public SeriesFroInverse()
			:base(new Inverse())
		{

		}
	}
	[Obsolete()]
	public class Harmonic : StreamI1
	{
		private BigInteger _denominator=0;

		public BigInteger denominator
		{
			get { return _denominator; }
			set { denominator = value; }
		}

		private Q _sum=Q.CreateZero();

			public Q sum
		{
			get { return _sum=Q.CreateZero(); }
			set { _sum= value; }
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
			_denominator++;
			_sum+=Q.Inverse(_denominator);
			return _sum;

			throw new NotImplementedException();
		}

		public void reset()
		{
			_denominator = 0;
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
