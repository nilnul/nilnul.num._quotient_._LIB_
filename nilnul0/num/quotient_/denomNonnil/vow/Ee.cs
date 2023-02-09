using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnilI;


namespace nilnul.num.quotient_.denomNonnil.vow
{
	public class Ee<TVow> :
		nilnul.obj.vow.Ee_ofIn<Q1, TVow>

		where TVow : nilnul.obj.VowI_ofIn<Q1>
	{
		public Ee(Q1 val, TVow vow) : base(val, vow)
		{
		}

		public Ee(in Q1 val, in TVow vow) : base(in val, in vow)
		{
		}

		public Ee(in Q1 val, TVow vow) : base(in val, vow)
		{
		}

		public Ee(Q1 val, in TVow vow) : base(val,in  vow)
		{
		}
	}

	public class Ee :
		Ee< nilnul.obj.VowI_ofIn<Q1>>
	{
		public Ee(Q1 val,nilnul.obj.VowI_ofIn<Q1> vow) : base(val, vow)
		{
		}

		public Ee(in Q1 val, in VowI_ofIn<Q1> vow) : base(in val,in vow)
		{
		}

		public Ee(in Q1 val, VowI_ofIn<Q1> vow) : base(in val, vow)
		{
		}

		public Ee(Q1 val, in VowI_ofIn<Q1> vow) : base(val,in vow)
		{
		}
	}


}
