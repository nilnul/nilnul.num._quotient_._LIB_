using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.border_
{
	public class Lower : Border2
	{
		public Lower(bool openFalseCloseTrue, Quotient1 bound) : base(openFalseCloseTrue, bound)
		{
		}

		public Lower(bool openFalseCloseTrue, Num mark) : base(openFalseCloseTrue, mark)
		{
		}
	}
}
