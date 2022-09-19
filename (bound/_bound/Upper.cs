using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._bound
{
	public interface UpperI:nilnul.num.quotient.BorderI { }
	/// <summary>
	/// different with border in that lower or upper has direction
	/// </summary>
	public class Upper : nilnul.num.quotient.Border2
		,
		UpperI
	{
		public Upper(bool openFalseCloseTrue, Quotient1 bound) : base(openFalseCloseTrue, bound)
		{
		}

		public Upper(bool openFalseCloseTrue, Num1 mark) : base(openFalseCloseTrue, mark)
		{
		}

		public Upper(UpperI upper):this(upper.openFalseCloseTrue,upper.mark)
		{
		}

		static public Upper CreateOpen(Quotient1 mark)
		{
			return new Upper(false, mark);
		}

		static public Upper CreateClose(Quotient1 mark)
		{
			return new Upper(true, mark);
		}
	}
}
