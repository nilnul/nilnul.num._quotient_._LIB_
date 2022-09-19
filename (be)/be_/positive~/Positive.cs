using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;


namespace nilnul.num.quotient.be
{
	[Obsolete()]
	public  class Positive
	{
		static public bool Eval(
			Q x
		)
		{
			return x > 0;
			
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

			public Asserted(Asserted x)
				:base(x.val)
			{


			}

			public void half() {
				val /= 2;
			}


			public Asserted toHalf() {

				var r= new Asserted(
					this
				);
				r.half();

				return r;
			
			}
			static public Asserted Half(Asserted x) {

				return new Asserted(
					x.val /2	
				);
			
			}

			public override string ToString()
			{
				return val.ToString();
			}

		}

		
		public partial class Assertion
			:nilnul.bit.be.Assertion<Q,Be>
		{

		}

		

	






	}



}
