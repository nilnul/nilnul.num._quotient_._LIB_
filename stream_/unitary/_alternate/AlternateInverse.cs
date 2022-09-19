using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using i=nilnul.num.integer;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream._subtypeS
{
	[Obsolete()]
	public class AlternateInverse : StreamI2
		,IEnumerable<Q>
	{

		integer.stream._subtypeS.PostiveAlternate _positiveAlternate = new integer.stream._subtypeS.PostiveAlternate();



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
			return   Q.Inverse(_positiveAlternate.next());

			throw new NotImplementedException();
		}

		public void reset()
		{

			integer.stream._subtypeS.PostiveAlternate _positiveAlternate = new integer.stream._subtypeS.PostiveAlternate();


			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}




	}
}
