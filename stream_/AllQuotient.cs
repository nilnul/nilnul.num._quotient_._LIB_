using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;


using RationalI = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.stream.eg
{
	public class AllQuotient
	{

		static public IEnumerable<RationalI> Enumerate2()
		{
			yield return  0;
			for (BigInteger sum = 2; ; sum++)
			{
				BigInteger num;
				for (num = 0; num < sum; num++)
				{
					BigInteger den = sum - num;
					//is j, i-j coprime

					if (BigInteger.GreatestCommonDivisor(num, den) == 1)
					{
						yield return Q.Divide(-num, den);
						yield return Q.Divide(num, den);

					}

				}


			}
		}

	}
}
