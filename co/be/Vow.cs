using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co.be
{
	public class Vow
		:
		nilnul.obj.co.be.Vow<
			Quotient_unsimplified
		>
	{
		public Vow(ref BeOfRefI<(Quotient_unsimplified, Quotient_unsimplified)> val) : base(ref val)
		{
		}

		public Vow(BeOfRefI<(Quotient_unsimplified, Quotient_unsimplified)> x) : base(x)
		{
		}
	}
}
