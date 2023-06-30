using nilnul.num.quotient_.denomNonnil;
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
	public class Lower : nilnul.num.quotient_.denomNonnil._range.Border
		,
		LowerI
	{
		

		public Lower(bool openFalseCloseTrue, quotient_.DenomNonnil bound) : base(openFalseCloseTrue, bound)
		{
		}

		public Lower(bool openFalseCloseTrue, Num1 mark) : base(openFalseCloseTrue, mark)
		{
		}

		public Lower(BorderI lower):this(lower.openFalseCloseTrue,lower.mark )
		{
		}
		static public Lower Of(BorderI upper)
		{
			return upper switch
			{
				Lower u => u
				,
				_ => new Lower(upper.openFalseCloseTrue, upper.mark)
			}; ;
		}

		static public new Lower CreateOpen(quotient_.DenomNonnil mark)
		{
			return new Lower(false, mark);
		}

		static public new Lower CreateClose(quotient_.DenomNonnil mark)
		{
			return new Lower(true, mark);
		}

	}
}
