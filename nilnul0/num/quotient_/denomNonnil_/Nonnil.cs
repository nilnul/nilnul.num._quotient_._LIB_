using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient_;
using nilnul.num.integer_;
using nilnul.num_;

namespace nilnul.num.quotient_.denomNonnil_
{
	/// <summary>
	/// of simplified;
	/// </summary>
	public class Nonnil :
		
		nilnul.num.quotient_.denomNonnil.be_.nonnil.vow.Ee
		,
		DenomNonnilI
	{
		public Nonnil(Rational val) : base(val)
		{
		}

		public Nonnil(QuotientI1 val) : base(val)
		{
		}

		public Nonnil(DenomNonnilI val) : base(val)
		{
		}

		

		public Nonnil(BigInteger numerator1, num_.Positive denominator1 ):this( new Rational(numerator1,denominator1))
		{
		}

		public Nonnil(num_.Positive1 num, BigInteger den):this( new Rational(num,den))
		{
		}

		public Nonnil(Nonnil_vowlessRef denominator1, BigInteger numerator1):this(
			new DenomNonnil(
				denominator1,numerator1
			)
			)
		{
		}

		public ref Nonnil_vowlessRef denominator =>ref eeByRef.denominator;

		public ref BigInteger numerator =>ref eeByRef.numerator;
	}
}
