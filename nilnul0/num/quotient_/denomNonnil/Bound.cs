using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient._bound;
using nilnul.num.quotient._bound_;
using nilnul.num.quotient.border;
using nilnul.num.quotient_;
using Qi = nilnul.num.QuotientI;

namespace nilnul.num.quotient_.denomNonnil
{
	public class Bound :
		border.co_.lowerUpper.be_.dwelt.vow.Ee
		,
		BoundI
	{

		public Bound(in border.co_.LowerUpper val) : base(in val)
		{
		}

		
		public Bound(border.co_.LowerUpper val) : base(val)
		{
		}

		public Bound(border_.Lower lower1, border_.Upper upper1):this(
			new border.co_.LowerUpper(lower1,upper1)
		)
		{
		}

		public border_. Lower lower => eeByRef.Item1;

		public border_. Upper upper => eeByRef.Item2;
	}



}