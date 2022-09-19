using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.rational.cut.op
{
	[Obsolete()]
	public partial class Max
	{
		static public Cut Eval(Cut a, Cut b) {

			return UpperBoundComparer.Comparer.Compare(a, b) <= 0 ? b : a;
		
		}
	}
}
