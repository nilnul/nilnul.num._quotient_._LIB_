using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._bound_.lowerUpper.be_
{
	public class Single : lowerUpper.BeI
	{
		public bool be(LowerUpperI obj)
		{
			return obj.lower.mark==obj.upper.mark && obj.lower.openFalseCloseTrue && obj.upper.openFalseCloseTrue;
		}

		static public Single Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Single>.Instance;
			}
		}

	}
}
