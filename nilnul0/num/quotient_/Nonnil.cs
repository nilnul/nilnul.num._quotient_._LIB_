using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient_;
using nilnul.num_;

namespace nilnul.num.quotient_
{
	/// <summary>
	/// of simplified;
	/// </summary>
	public class Nonnil1 :
		
		nilnul.num.quotient.be_.nonnil.vow.En
		,
		QuotientI
		,
		nilnul.num._quotient_.DenominatorI1
	{
		public Nonnil1(Rational val) : base(val)
		{
		}

		public Nonnil1(QuotientI1 val) : base(val)
		{
		}

		public Nonnil1(BigInteger numerator1, num_.Positive denominator1 ):this( new Rational(numerator1,denominator1))
		{
		}

		public Nonnil1(num_.Positive1 num, BigInteger den):this( new Rational(num,den))
		{
		}

		public BigInteger numerator => en.numerator;
		public num_.Positive denominator => en.denominator;

		public num_.Positive1 denominator1 => en.denominator1;
	}
}
