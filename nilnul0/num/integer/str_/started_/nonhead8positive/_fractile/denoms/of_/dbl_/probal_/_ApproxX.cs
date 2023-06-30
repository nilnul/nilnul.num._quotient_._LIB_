using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using P = nilnul.num_.Positive1;
using System.Numerics;
using nilnul.num.rational.cf;
using nilnul.num.quotient_;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.of_.dbl_.probal_
{

	static public class _ApproxX
	{
		/// <summary>
		/// convert to SimpleProper with the err lt  (1/ give number).
		/// </summary>
		/// <param name="_nonnegLeOne"></param>
		/// <param name="_denominatorLowerbound_positive">
		///	after this, the spinned off tail is less than the given unital
		/// </param>
		/// <returns></returns>
		static public List<P> _ToDenoms_0prob(
			double _nonnegLeOne, nilnul.num.quotient_.NonnegI precision)
		{
			var denominants = new List<P>();

			if (_nonnegLeOne <= double.Epsilon)
			{
				return denominants;
			}


			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _nonnegLeOne);  // now we get d[0] in "  1/(d0+ residue) "
			var denominator0 = tailInverse.Item1;
			denominants.Add(new P(denominator0));

			var denomiantor0_tail = tailInverse.Item2;  /// 1/ (d0+ this)

			//if (denomiantor0_tail <= 0)
			//{
			//	return denominants;
			//}

			BigInteger denominator = denominator0;
			BigInteger denominatorK_minus1 = 1;
			BigInteger denominatorK_minus2 = 0;
			BigInteger denominatorK = (denominator * denominatorK_minus1 + denominatorK_minus2);  //when the recurFrac is truncated at step[k] and converted to quotient, this is the denominator of that quotient

			while (nilnul.num.Quotient1.CreatePositiveUnital(denominatorK) > precision.vowed)
			{
				if (tailInverse.Item2 <= double.Epsilon)
				{
					return denominants;
				}

				tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / tailInverse.Item2);


				denominants.Add(new P(tailInverse.Item1));
				denominatorK_minus2 = denominatorK_minus1;
				denominatorK_minus1 = denominatorK;

				denominatorK = (tailInverse.Item1* denominatorK_minus1+ denominatorK_minus2);

			}

			return denominants;

		}



		public static List<P> _ToDenoms_0prob(double nonnegLeOne, nilnul.num.quotient_.Nonneg quotient1)
		{
			return _ToDenoms_0prob(nonnegLeOne, (NonnegI)(quotient1));
		}

		public static List<P> _ToDenoms_0prob(double nonnegLeOne, Quotient1 quotient1)
		{
			return _ToDenoms_0prob(nonnegLeOne, new nilnul.num.quotient_.Nonneg(quotient1));
		}
		static public List<P> _ToDenoms_0prob(double _nonnegLeOne, BigInteger _denominatorLowerbound_positive)
		{
			return _ToDenoms_0prob(_nonnegLeOne, nilnul.num.Quotient1.CreateUnit(_denominatorLowerbound_positive));
		}













	}
}
