using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{

	/// <summary>
	/// a bounded interval
	/// </summary>
	public interface RangeI
	{
		//	nilnul.num.quotient.border.duo.be_.Nonempty.En borders{get;}
	
	}

	[Obsolete()]
	public class Range :
		nilnul.num.quotient.border.duo.be_.Nonempty.En
		,RangeI
	{

		public Range(border.Duo duo):base(duo)
		{

		}
		public Range(Border1 lower, Border1 upper):this(new border.Duo(lower,upper))
		{

		}

		/// <summary>
		/// compile error
		/// </summary>
		/// <param name="duo"></param>
		//static public implicit operator Range( border.duo.be_.Nonempty.En duo) {
		//	return new Range(duo);
		//}

		static public implicit operator Range(nilnul.num.Range numRange) {
			return new Range(
				(nilnul.num.quotient.Border1)numRange.ed.lower
				,
				(nilnul.num.quotient.Border1)numRange.ed.upper
			);
		}
		

	}
}
