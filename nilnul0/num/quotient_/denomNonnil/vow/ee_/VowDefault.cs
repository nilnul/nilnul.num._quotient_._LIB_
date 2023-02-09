using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1 = nilnul.num.quotient_.DenomNonnilI;


namespace nilnul.num.quotient_.denomNonnil.vow.ee_
{
	public class VowDefault<TVow> :
		Ee< TVow>

		where TVow : nilnul.obj.VowI_ofIn< Q1>, new()
	{
		public VowDefault(Q1 val) : base(
			val
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

		public VowDefault(in Q1 val) : base(
			in val
			,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

		)
		{
		}

	
	}
}
