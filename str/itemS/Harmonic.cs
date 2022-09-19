using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient.str.itemS
{
	public class Harmonic
		:IEnumerable<Q>
	{


		private __bigint.be.Positive.Asserted _n;

		public __bigint.be.Positive.Asserted n
		{
			get { return _n; }
			set { _n = value; }
		}


		public Harmonic(nilnul.num.__bigint.be.Positive.Asserted n)
		{
			_n = n;
		}

		public IEnumerator<Q> GetEnumerator()
		{
			
			for (BigInteger	i = 1; i <= n.val; i++)
			{
				yield return Q.Inverse(i);


			}

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			throw new NotImplementedException();
		}

		public Q sum() {

			return this.Aggregate(Q.CreateZero(), (a, i) => a + i);
		}
	}
}
