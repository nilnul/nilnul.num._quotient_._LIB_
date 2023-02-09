using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.denomNonnil.clasp_
{
	static public class _CenteredX
	{
		static public denomNonnil.Clasp  Clasp_ofCenterRadius(
			DenomNonnilI center
			,
			nilnul.num.quotient_.denomNonnil_.Nonneg x ) {

			return new Clasp(
				center.ToImpl()-x
				,
				center.ToImpl() + x
			);
		}

		public static Clasp Clasp_ofCenterRadius(int v, denomNonnil_.Nonneg x)
		{
			return Clasp_ofCenterRadius(
				(DenomNonnil)v,x
			);

		}
	}
}
