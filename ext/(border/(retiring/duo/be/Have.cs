using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.bound.duo.be
{
	public partial class Have
	{
		static public bool Eval(Duo x) {


			var t = ext.Comparer.Singleton.Compare(x.lower.pinpoint, x.upper.pinpoint);


			if (
				
				t<0
				
			)
			{
				return true;

			}
			if (t==0)
			{
				if (x.lower.openFalseCloseTrue )
				{
					if (x.upper.openFalseCloseTrue)
					{
						return true;
					}
					return false;
					
				}
				return false;
				
			}
			return false;
		
		}
		public class Be :
			bit.Be<Duo>
		{
			public Be()
				:base(Eval)
			{

			}

			public class Asserted :
				nilnul.bit.be.Asserted<Duo,Be>
			{
				public Asserted(Duo x)
					:base(x)
				{

				}
			}

		}
	}
}
