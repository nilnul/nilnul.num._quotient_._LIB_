using nilnul.obj._border_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil._range.border_
{

	/// <summary>
	/// different with border in that lower or upper has direction
	/// </summary>
	public class Upper
		:
		nilnul.num.quotient_.denomNonnil._range.Border
		,
		obj.border_.UpperI<quotient_.DenomNonnil>
		,
		UpperI
	{
		

		public Upper(bool openFalseCloseTrue, quotient_.DenomNonnil bound) : base(openFalseCloseTrue, bound)
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

		static public new Upper CreateOpen(quotient_.DenomNonnil mark)
		{
			return new Upper(false, mark);
		}

		static public new Upper CreateClose(quotient_.DenomNonnil mark)
		{
			return new Upper(true, mark);
		}

	}
}
