using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;


namespace nilnul.num.quotient.be
{
	static public  class NonNeg
	{
		static public bool Eval(
			Q x
		)
		{
			return x.isNonneg;
			
		}

		




		public partial class Be
			: nilnul.bit.Be<Q>
		{
			public Be()
				:base(Eval)
			{

			}
		}

		public class Asserted:nilnul.bit.be.Asserted<Q,Be>
		{
			public Asserted(Q val)
				:base(val)
			{

			}

		}

		
		public partial class Assertion
			:nilnul.bit.be.Assertion<Q,Be>
		{

		}

		

	






	}



}
