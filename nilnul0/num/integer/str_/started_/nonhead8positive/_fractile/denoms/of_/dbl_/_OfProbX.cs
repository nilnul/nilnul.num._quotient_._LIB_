using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using P= nilnul.num_.Positive1;
using System.Numerics;
using nilnul.num.rational.cf;

namespace  nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.of_.dbl_

{

	static public class _OfProbX
	{



		static public List<num_.Positive1> _ToDenoms_0prob(double _nonnegLeOne)
		{
			var denominants = new List<num_.Positive1>();


			//if (tail_0to1_ == 0)
			//{
			//	return denominants;
			//}

			if (_nonnegLeOne <= double.Epsilon)
			{
				return denominants;
			}


			var tailInverse = nilnul_obj.num.NumX.IntegerAndTail_forNonNeg(1 / _nonnegLeOne);

			denominants.Add(new num_.Positive1(tailInverse.Item1));

			denominants.AddRange(
				 _ToDenoms_0prob(tailInverse.Item2)
			);

			return denominants;

		}


	








	}
}
