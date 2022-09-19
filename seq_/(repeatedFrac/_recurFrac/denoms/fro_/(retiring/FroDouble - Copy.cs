using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Fraction = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Positive = nilnul.num.natural.PositiveNatural_inheritNatural;

using Frac = nilnul.num._quotient.Fraction1;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;
using nilnul.num.rational.cf;

namespace nilnul.num.quotient._continuedFrac.simpleProper
{
	
	public class _FroDoubleX
	{
		


		


		[Obsolete("this may be wrong",true)]
		static public List<Positive1> _FroDouble(double tail_proper, double tailUpper_nonNeg)
		{
			var denominants = new List<Positive1>();

			if (tail_proper > tailUpper_nonNeg)
			{

				var tailInverse = 1 / tail_proper;

				var fraction = _FroDouble(tailInverse, tailUpper_nonNeg);

				denominants.AddRange(fraction);


			}

			return denominants;

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="_tail_0to1_"></param>
		/// <param name="numberOfDenominators"></param>
		/// <returns></returns>

		static public List<Positive1> FroDouble_nonNeg(double _tail_0to1_, N numberOfDenominators)
		{
			var denominants = new List<Positive1>();

			if (numberOfDenominators == 0)
			{
				return denominants;

			}
			if (_tail_0to1_ == 0)
			{
				return denominants;

			}

			numberOfDenominators--;

			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new Positive1(tailInverse.Item1));

			var fraction = FroDouble_nonNeg(tailInverse.Item2, numberOfDenominators);
			denominants.AddRange(fraction);

			return denominants;

		}


		


		/// <summary>
		/// convert to SimpleProper with the err lt  (1/ give number).
		/// </summary>
		/// <param name="_tail_0to1_"></param>
		/// <param name="denominatorLowerbound_positive"></param>
		/// <returns></returns>
		static public List<Positive1> FroDouble_atDenominator(double _tail_0to1_, BigInteger denominatorLowerbound_positive)
		{
			var denominants = new List<Positive1>();

			if (_tail_0to1_ <= 0)
			{
				return denominants;
			}


			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new Positive1(tailInverse.Item1));
			if (tailInverse.Item2 <= 0)
			{
				return denominants;
			}

			BigInteger denominator = tailInverse.Item1;
			BigInteger denominatorK_1 = 1;
			BigInteger denominatorK_2 = 0;
			BigInteger denominatorK =_fro._CalcErrorInApproximationX.CalcFromPreviousTwoTerms(tailInverse.Item1, denominatorK_1, denominatorK_2);

			while (denominatorK < denominatorLowerbound_positive)
			{
				if (tailInverse.Item2 <= 0)
				{
					return denominants;
				}
				tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / tailInverse.Item2);
				denominants.Add(new Positive1(tailInverse.Item1));
				denominatorK_2 = denominatorK_1;
				denominatorK_1 = denominatorK;

				denominatorK = _fro._CalcErrorInApproximationX.CalcFromPreviousTwoTerms(tailInverse.Item1, denominatorK_1, denominatorK_2);


			}

			return denominants;

		}

		[Obsolete("precision must be preset")]

		static public List<Positive1> FroDouble_nonNeg(double tail_0to1_)
		{
			var denominants = new List<Positive1>();


			if (tail_0to1_ == 0)
			{
				return denominants;

			}


			var tailInverse = nilnul_obj.num.NumX.IntegerAndTail_forNonNeg(1 / tail_0to1_);
			denominants.Add(new Positive1(tailInverse.Item1));

			var fraction = FroDouble_nonNeg(tailInverse.Item2);
			denominants.AddRange(fraction);

			return denominants;

		}










	}
}
