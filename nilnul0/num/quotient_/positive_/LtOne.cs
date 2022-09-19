using nilnul.num.quotient.be_.positive.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.positive_
{
	public class LtOne : nilnul.num.quotient.be.en_.BeDefaulted<nilnul.num.quotient.be_.positive_.LtOne>
		,
		PositiveI
		,
		nilnul.num.QuotientI1
	{
		public LtOne(Quotient1 val) : base(val)
		{
		}

		public En en => new En(this);

		public BigInteger numerator => this.boxed.numerator;

		public num_.Positive1 denominator1 => this.boxed.denominator1;

		public GtOne toInverse() {
			return new GtOne(
				this.denominator1
				,this.numerator
			);
		}

		
	}
}
