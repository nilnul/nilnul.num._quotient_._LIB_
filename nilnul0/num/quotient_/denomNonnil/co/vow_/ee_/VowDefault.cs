using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.co.vow.ee_
{
	public class VowDefault<TVow>
		: vow.Ee
		where TVow :
		obj.VowI_ofIn<(Quotient_NonnilDenom, Quotient_NonnilDenom)>, new()
	{
		public VowDefault(in (Quotient_NonnilDenom, Quotient_NonnilDenom) val) : base(in val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

		)
		{
		}

		

	

		public VowDefault((Quotient_NonnilDenom, Quotient_NonnilDenom) val) : this(in val)
		{
		}

	
		public VowDefault(Quotient_NonnilDenom x, Quotient_NonnilDenom y) : this(
			(x,y)
		)
		{
		}

	
	}
}
