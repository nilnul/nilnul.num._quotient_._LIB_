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
		_range.border.co_.lowerUpper.be_.dwelt.vow.Ee
		,
		BoundI
	{

		public Bound(in _range.border.co_.LowerUpperI val) : base(in val)
		{
		}

		
		public Bound(_range.border.co_.LowerUpperI val) : base(val)
		{
		}

		public Bound(_range. border_.LowerI lower1, _range.border_.UpperI upper1):this(
			new _range.border.co_.LowerUpper(lower1,upper1)
		)
		{
		}

		public _range.border_. Lower lower => eeByRef.lower;

		public _range.border_. Upper upper => eeByRef.upper;
	}



}