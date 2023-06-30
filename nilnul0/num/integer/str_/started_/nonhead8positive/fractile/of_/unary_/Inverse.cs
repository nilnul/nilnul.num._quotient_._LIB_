//using nilnul.obj.str_.seq.op_.unary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile.of_.unary_
{
	static public class _InverseX
	{
		static public IEnumerable<BigInteger> Adders8seq_ofAdders(
			BigInteger floor
			,
			IEnumerable<BigInteger> adders
		)
		{
			if (floor == 0)
			{
				return adders;
			}
			else
			{
				return adders.Prepend(floor).Prepend(0);
			}
		}


		static public IEnumerator<BigInteger> Adders8enumerator_ofAdders(
			BigInteger floor,
			IEnumerator<BigInteger> denoms
		)
		{
			if (floor != 0)
			{
				yield return 0;
				while (denoms.MoveNext())
				{
					yield return denoms.Current;
				};


			}
			else
			{
				while (denoms.MoveNext())
				{
					yield return denoms.Current;
				};


			}

		}
		public static IEnumerator<BigInteger> _Adders8enumerator_0started(IEnumerator<BigInteger> enumerator)
		{
			enumerator.MoveNext();
			return Adders8enumerator_ofAdders(enumerator.Current, enumerator);
		}

		static public IEnumerator<BigInteger> _Adders8enumerator_0started(
			IEnumerable<BigInteger> adders
		)
		{
			return _Adders8enumerator_0started(adders.GetEnumerator());
		}


	}
}
