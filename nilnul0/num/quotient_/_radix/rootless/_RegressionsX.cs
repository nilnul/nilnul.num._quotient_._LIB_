using nilnul.num.integer_._radix;
using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_._radix.rootless
{

	/// <summary>
	/// to, or of, obsolete objects;
	/// </summary>
	static public class _RegressionsX
	{
		static public SignificandIndex ToSignific9indic(
			this nilnul.num.rational.Float rootless
		) {
			return new SignificandIndex(
				rootless.significand
				,
				rootless.index
			);
		}
	}
}
