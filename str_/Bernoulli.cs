using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.str_
{
	/// <summary>
	/// in theory, this should be a stream. But we first implement a str, cuz array is used in our implementation and the length of an array is limited to a given upper bound, .
	/// </summary>
	static public class _BernoulliStatic
	{
		static public Q1 _Eval(int n_natural)
		{
			var A = new Q1[checked(n_natural+1)];
			for (int m = 0; m <=n_natural; m++)
			{
				A[m] = Q1._CreateUnit( m + 1);
				for (int j = m; j > 0; j--)
				{
					A[j - 1] = j * (A[j-1] -A[j]);
				}
			}

			return A[0];

			

		}


	}

	public class Bernoulli:nilnul.num.quotient.StrI2
		
	{
		static public IEnumerable<Q1> Enumerate() {
			for (int i = 0; i <= int.MaxValue-1; i++)
			{
				yield return _BernoulliStatic._Eval(i);
			}
		}


	}


}
