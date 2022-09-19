
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
	///		2) The last denominator can be one. This is for use to represent irrational numbers. In irrational numbers, allowing one will still bring out a single representation.
	/// 
	/// </remarks>
	///
	[Obsolete(nameof(quotient_._recurFrac.Denoms))]
	public class ForIrrational
		
	{

		/// <summary>
		/// why not IEnumerableOfBigInteger? 'cuz the arbitary long part is of type Positive1. Other parts can be checked sperately and perfixed.
		/// </summary>
		IEnumerable<Positive1> _denominators;
		public IEnumerable< Positive1> denominators
		{
			get
			{
				return _denominators;
			}
		}

		

		
		

		#region ctor



		public ForIrrational(params Positive1[] denominators):this(denominators as IEnumerable<Positive1>)
		{
		}


		public ForIrrational(IEnumerable<Positive1> denominators)
		{
			_denominators = denominators;

		}

		public ForIrrational()
			:this( new Positive1[0])
		{

		}

		#endregion

		public override string ToString()
		{
			return $"{string.Join( ",", _denominators)}";
		}




















	}
}
