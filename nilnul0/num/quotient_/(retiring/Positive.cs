using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.be_;
using nilnul.num_;

namespace nilnul.num.quotient_
{
	[Obsolete()]
	public class Positive : nilnul.num.quotient.be_.Positive1.En
		,
		nilnul.num.QuotientI
	{
		public Positive(Simplify.Ed1 val) : base(val)
		{
		}

		public Positive(nilnul.num.quotient.be_.Positive1.En x) : base(x)
		{
		}

		public Positive(nilnul.num_.Positive num):this(new Simplify.Ed1(num))
		{

		}
		public Positive(int i):this(new nilnul.num_.Positive(i))
		{

		}


		public BigInteger numerator => this.val.numerator;

		public num_.Positive denominator => new num_.Positive( this.val.denominator);
	}
}
