using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;

namespace nilnul.num.quotient_
{
	[Obsolete()]
	public class Nonnil :
		
		nilnul.num.quotient.be_.nonnil.En
		,
		QuotientI
	{
		public Nonnil(Quotient1 val) : base(val)
		{
		}

		public Nonnil( BigInteger numerator1,num_.Positive denominator1):this( new Quotient1(numerator1,denominator1))
		{
		}

		public Nonnil(num_.Positive numerator, BigInteger denominator):this( new Quotient1(numerator,denominator))
		{
		}

		public BigInteger numerator => en.numerator;
		public num_.Positive denominator => en.denominator;
	}
}
