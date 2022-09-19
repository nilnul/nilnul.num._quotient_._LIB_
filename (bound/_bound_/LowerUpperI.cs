using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._bound_
{
	/// <summary>
	/// different with border in that lower or upper has direction
	/// </summary>
	public interface LowerUpperI:LowerI,UpperI
	{

	}

	public class LowerUpper:LowerUpperI
	{
		private _bound.Lower _lower;

		public _bound.Lower lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private _bound.Upper _upper;

		public _bound.Upper upper
		{
			get { return _upper; }
			set { _upper = value; }
		}

		public LowerUpper(_bound.Lower lower, _bound.Upper upper)
		{
			_lower = lower;
			_upper = upper;
		}

		public LowerUpper(_bound.LowerI lower, _bound.UpperI upper):this(
			new _bound.Lower(lower)
			,
			new _bound.Upper(upper)
		)
		{

		}


	}
}
