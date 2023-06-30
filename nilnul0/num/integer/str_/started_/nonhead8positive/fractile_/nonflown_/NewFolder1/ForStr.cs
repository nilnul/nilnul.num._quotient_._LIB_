using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.continuedFrac_
{
	

	[Obsolete(nameof(quotient_.recurFrac_.Proper))]
	public class ForQ
	{
		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private _continuedFrac.simpleProper_.ForQ _proper;

		public _continuedFrac.simpleProper_.ForQ proper
		{
			get { return _proper; }
			set { _proper = value; }
		}
		public ForQ( BigInteger floor, _continuedFrac.simpleProper_.ForQ proper)
		{
			_floor = floor;
			_proper = proper;
		}

		public override string ToString()
		{
			return $"[{_floor};{_proper.ToString()}]";
		}

	}
}
