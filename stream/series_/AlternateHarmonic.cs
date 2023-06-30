using nilnul.num.quotient.stream._instanceS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream._subtypeS
{


	public class AlternateHarmonic : StreamI2,
		IEnumerable<Q>
	{

		static public readonly Harmonic Singleton = SingletonByDefault<Harmonic>.Instance;
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
			//set { _sum= value; }
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

		public Q this[BigInteger x] {
			get {
				while (x-->0)
				{
					next();
				}
				return next();
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();

		
	}


	}
}
