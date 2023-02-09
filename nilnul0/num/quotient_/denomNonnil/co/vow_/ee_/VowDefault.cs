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
		obj.VowI_ofIn<(DenomNonnil, DenomNonnil)>, new()
	{
		public VowDefault(in (DenomNonnil, DenomNonnil) val) : base(in val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

		)
		{
		}

		

	

		public VowDefault((DenomNonnil, DenomNonnil) val) : this(in val)
		{
		}

	
		public VowDefault(DenomNonnil x, DenomNonnil y) : this(
			(x,y)
		)
		{
		}

	
	}
}
