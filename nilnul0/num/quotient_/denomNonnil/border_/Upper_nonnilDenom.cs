using nilnul.obj._border_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.border_
{

	/// <summary>
	/// different with border in that lower or upper has direction
	/// </summary>
	public class Upper
		:
		nilnul.num.quotient_.denomNonnil.Border
		,
		obj.border_.UpperI<quotient_.DenomNonnilI>
		,
		UpperI
	{
		

		public Upper(bool openFalseCloseTrue, quotient_.DenomNonnilI bound) : base(openFalseCloseTrue, bound)
		{
		}

		public Upper(bool openFalseCloseTrue, Num1 mark) : base(openFalseCloseTrue, mark)
		{
		}

		//public Upper_nonnilDenom(UpperI lower) : this(lower.openFalseCloseTrue, lower.mark)
		//{
		//}

		

		static public Upper Of(BorderI upper) {
			return upper switch {
				Upper u => u
				,
				_=>new Upper(upper.openFalseCloseTrue, upper.mark)
			}; ;
		}

		static public new Upper CreateOpen(quotient_.DenomNonnilI mark)
		{
			return new Upper(false, mark);
		}

		static public new Upper CreateClose(quotient_.DenomNonnilI mark)
		{
			return new Upper(true, mark);
		}

	}
}
