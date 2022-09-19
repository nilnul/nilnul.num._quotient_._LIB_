using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.border.duo.be_;
using R1 = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.range.op_
{
	/// <summary>
	/// by merging border
	/// </summary>
	public partial class Close
		: OpI
	{


		static public readonly Close Singleton = SingletonByDefault<Close>.Instance;



		public R1 eval(R1 arg)
		{
			return R1.CreateClose(arg.lower.mark, arg.upper.mark );

			
		}
	}
}
