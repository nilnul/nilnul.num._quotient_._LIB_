using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.recurFrac_
{
	

	public class Proper
	{
		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private _recurFrac.denoms_.Proper _proper;

		public _recurFrac.denoms_.Proper proper
		{
			get { return _proper; }
			set { _proper = value; }
		}
		public Proper( BigInteger floor, _recurFrac.denoms_.Proper proper)
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
