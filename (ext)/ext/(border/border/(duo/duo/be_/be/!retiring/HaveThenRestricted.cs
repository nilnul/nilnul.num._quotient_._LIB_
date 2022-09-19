using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.ext.border.duo.be
{
	[Obsolete("Interval")]
	public partial class HaveThenRestricted
	{
		static public  bool Eval(Duo bounded) {

			return ContainsNoNegInf(bounded) && ContainsNoInf(bounded);
		
		}

		public class Be:
			nilnul.bit.Be<Duo>
		{
			public Be()
				:base(Eval)
			{

			}
			
		}





		static bool ContainNegInf(Duo bounded)
		{

			return bounded.contain(
				_ext.NegInf.Singleton
			);
		}
		static bool ContainInf(Duo bounded)
		{

			return bounded.contain(
				_ext.Inf.Singleton
			);
		}


		static bool ContainsNoNegInf(Duo bounded)
		{

			return !ContainNegInf(bounded);
		}


		static public bool ContainsNoInf(Duo bounded) {
			return !ContainInf(bounded);
		}

	}
}
