using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._bound_.lowerUpper.be_
{
	public class Spanned : lowerUpper.BeI
	{
		public bool be(LowerUpperI obj)
		{
			return obj.lower.mark<obj.upper.mark;
		}

		static public Spanned Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Spanned>.Instance;
			}
		}

	}
}
