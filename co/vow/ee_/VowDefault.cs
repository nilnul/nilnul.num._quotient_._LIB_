using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.co.vow.ee_
{
	public class VowDefault<TVow>
		: vow.Ee
		where TVow :
		obj.Vow_ofRefI<(Quotient_unsimplified, Quotient_unsimplified)>, new()
	{
		public VowDefault(ref (Quotient_unsimplified, Quotient_unsimplified) val) : base(ref val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

		)
		{
		}

		

	

		public VowDefault((Quotient_unsimplified, Quotient_unsimplified) val) : this(ref val)
		{
		}

	
		public VowDefault(Quotient_unsimplified x, Quotient_unsimplified y) : this(
			(x,y)
		)
		{
		}

	
	}
}
