using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._bound
{
	public interface LowerI : nilnul.num.quotient.BorderI { }

	/// <summary>
	/// different with border in that lower or upper has direction
	/// </summary>
	public class Lower : nilnul.num.quotient.Border2
		,
		LowerI
	{
		public Lower(bool openFalseCloseTrue, Quotient1 bound) : base(openFalseCloseTrue, bound)
		{
		}

		public Lower(bool openFalseCloseTrue, Num1 mark) : base(openFalseCloseTrue, mark)
		{
		}

		public Lower(LowerI lower):this(lower.openFalseCloseTrue,lower.mark)
		{
		}

		static public new Lower CreateOpen(Quotient1 mark) {
			return new Lower( false, mark);
  }

		static public new  Lower CreateClose(Quotient1 mark) {
			return new Lower( true, mark);
  }

	}
}
