using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.continuedFrac_;
using System.Numerics;
using nilnul.num.natural;
using nilnul.num.rational.cf;
using nilnul._num.bigint.be;

namespace nilnul.num.quotient.continuedFrac.fro_
{
	public class Ieee
		: nilnul.obj.FroI<double, continuedFrac_.ForIrrational>
	{
		private nilnul.num_.Positive _forPrecision;

		public nilnul.num_.Positive forPrecision
		{
			get { return _forPrecision; }
			set { _forPrecision = value; }
		}

		public Ieee(nilnul.num_.Positive forPrecision)
		{
			_forPrecision = forPrecision;
		}
		static public List<PositiveNatural_inheritNatural> FroDouble_atDenominator(double _tail_0to1_, BigInteger denominatorLowerbound_positive)
		{
			var denominants = new List<PositiveNatural_inheritNatural>();

			if (_tail_0to1_ <= 0)
			{
				return denominants;
			}


			var tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / _tail_0to1_);
			denominants.Add(new PositiveNatural_inheritNatural(tailInverse.Item1));
			if (tailInverse.Item2 <= 0)
			{
				return denominants;

			}

			BigInteger denominator = tailInverse.Item1;
			BigInteger denominatorK_1 = 1;
			BigInteger denominatorK_2 = 0;
			BigInteger denominatorK = CfX.CalcFromPreviousTwoTerms(tailInverse.Item1, denominatorK_1, denominatorK_2);



			while (denominatorK < denominatorLowerbound_positive)
			{
				if (tailInverse.Item2 <= 0)
				{
					return denominants;
				}
				tailInverse = nilnul_obj.num.NumX.FloorAndTail(1 / tailInverse.Item2);
				denominants.Add(new PositiveNatural_inheritNatural(tailInverse.Item1));
				denominatorK_2 = denominatorK_1;
				denominatorK_1 = denominatorK;

				denominatorK = CfX.CalcFromPreviousTwoTerms(tailInverse.Item1, denominatorK_1, denominatorK_2);


			}

			return denominants;

		}



		public ForIrrational fro(double src)
		{
			var floorTail = nilnul_obj.num.NumX.FloorAndTail(src);

			var tail = floorTail.Item2;

			var tailCf = FroDouble_atDenominator(tail, _forPrecision);

			return new ForIrrational(floorTail.Item1, tailCf.Select(x=> new nilnul.num_.Positive (x.val)));

			//throw new NotImplementedException();
		}

		static public ForIrrational Fro(double src, nilnul.num_.Positive forPrecision_denominator) {
			var floorTail = nilnul_obj.num.NumX.FloorAndTail(src);

			var tail = floorTail.Item2;

			var tailCf = FroDouble_atDenominator(tail, forPrecision_denominator);

			return new ForIrrational(floorTail.Item1, tailCf.Select(x=> new nilnul.num_.Positive (x.val)));


		}
	}
}
