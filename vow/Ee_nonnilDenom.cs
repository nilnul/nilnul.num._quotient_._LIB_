using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnilI;


namespace nilnul.num.quotient.vow
{
	public class Ee_nonnilDenom<TVow> :
		nilnul.obj.vow.Ee_ofIn<Q1, TVow>
		where TVow : nilnul.obj.VowI_ofIn<Q1>
	{
		public Ee_nonnilDenom(Q1 val, TVow vow) : base(val, vow)
		{
		}
		

	}

	public class Ee_nonnilDenom :
		Ee_nonnilDenom<nilnul.obj.VowI_ofIn<Q1>>
	{
		public Ee_nonnilDenom(Q1 val, nilnul.obj.VowI_ofIn<Q1> vow) : base(val, vow)
		{
		}
		

	}


}
