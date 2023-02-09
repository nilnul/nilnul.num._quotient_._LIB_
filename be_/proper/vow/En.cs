using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient.be_.proper.vow
{
	public class En
		: nilnul.num.quotient.vow.En<Vow>
	{
		public En(Quotient1 val) : base(val)
		{
		}

		public En(BigInteger item2, BigInteger val):this(new Quotient1(item2,val))
		{
		}

		public BigInteger round()
		{
			if (this.en >= Q1.CreateHalf()) return 1;
			return 0;
		}

		public BigInteger ceil()
		{
			return this.en == 0 ? 0 : 1;
		}

	}
}
