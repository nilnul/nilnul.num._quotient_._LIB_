using nilnul.num.quotient.ext.border.duo.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Quotient;

namespace nilnul.num.quotient.ext.border.duo.b
{
	[Obsolete("be.Bound")]
	public partial class Bound
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



		static public Asserted CreateSingleton(
	Q singleton

	)
			{

				return new Asserted(
					Duo.CreateClose(
						singleton,singleton
						
					)
					
				);

				
			}

		}

		







	}
}
