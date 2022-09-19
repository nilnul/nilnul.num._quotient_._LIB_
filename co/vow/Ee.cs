using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co.vow
{
	public class Ee
		:
		nilnul.obj.co.vow.Ee<Quotient_unsimplified>
	{
		public Ee(ref (Quotient_unsimplified, Quotient_unsimplified) val, Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)> vow) : base(ref val, vow)
		{
		}

		public Ee(ref (Quotient_unsimplified, Quotient_unsimplified) val, ref Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)> vow) : base(ref val, ref vow)
		{
		}

		public Ee((Quotient_unsimplified, Quotient_unsimplified) val, ref Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)> vow) : base(val, ref vow)
		{
		}

		public Ee((Quotient_unsimplified, Quotient_unsimplified) val, Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)> vow) : base(val, vow)
		{
		}

		public Ee(Quotient_unsimplified x, Quotient_unsimplified y, ref Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)> vow) : base(x, y, ref vow)
		{
		}

		public Ee(Quotient_unsimplified x, Quotient_unsimplified y, Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)> vow) : base(x, y, vow)
		{
		}
	}
}
