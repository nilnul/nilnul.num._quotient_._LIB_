using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.border.duo.be
{
	[Obsolete("Bound")]
	public partial class Range
	{
		static public  bool Eval(Duo duo) {

			return  Have.Eval(duo) &&  (duo.lower.mark is _ext.Base) && (duo.upper.mark is _ext.Base) ;
		
		}




		public class Be:
			nilnul.bit.Be<Duo>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Asserted: nilnul.bit.be.Asserted<Duo,Be>
		{

			public Asserted(Duo val):base(val)
			{



			}
		}





	
	}
}
