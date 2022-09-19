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

namespace nilnul.num.quotient._continuedFrac.simpleProper_
{
	/// <summary>
	/// Simple: the numerators are all 1.
	/// Proper: there is no integer part. 
	/// So 1/2 is. but 1+1/2 is not.
	/// </summary>

	/// <remarks>
	/// [0,1), if we:
	///		1) It can be 0 if the string of denominators is sans. This allows 0.
	///		2) The last denominator cannot be one. This excludes 1.
	///		This ensures that the representation of rational number is unique.
	/// 
	/// </remarks>
	///
	[Obsolete(nameof(quotient_._recurFrac.denoms_.Proper))]
	public class ForQ
	{

		/// <summary>
		/// why not IEnumerableOfBigInteger? 'cuz the arbitary long part is of type Positive1. Other parts can be checked sperately and perfixed.
		/// </summary>
		IEnumerable<Positive1> _denominators;
		public IEnumerable<Positive1> denominators
		{
			get
			{
				return _denominators;
			}
		}
		#region ctor



		public ForQ(params Positive1[] denominators) : this(denominators as IEnumerable<Positive1>)
		{
		}


		public ForQ(IEnumerable<Positive1> denominators)
		{
			Assert(denominators);
			_denominators = denominators;

		}

		public ForQ()
			: this(new Positive1[0])
		{

		}

		#endregion

		static public Positive1[] _TransformPlural(Positive1[] denominators_pluralCount)
		{
			var length = denominators_pluralCount.Length;

			if (denominators_pluralCount[length - 1] == 1)
			{
				denominators_pluralCount[length - 2] += denominators_pluralCount[length - 1];
				var newArray = new Positive1[length - 1];
				Array.Copy(denominators_pluralCount, newArray, length - 1);


				return newArray;


			}

			return denominators_pluralCount;


		}

		static public ForQ Create(IEnumerable<Positive1> denominators)
		{
			var count = denominators.Count();

			if (count == 1)
			{
				return new ForQ(denominators.First());
			}
			if (count == 2)
			{
				return new ForQ(_TransformPlural(denominators.ToArray()));

			}

			return new ForQ();
		}

		static public void Assert(IEnumerable<Positive1> denominators)
		{
			var length = denominators.Count();

			if (denominators.Any())
			{
				nilnul.AssertX.True(denominators.Last() > 1u);
			}

		}


		public override string ToString()
		{
			return $"{string.Join(",", _denominators)}";
		}




















	}
}
