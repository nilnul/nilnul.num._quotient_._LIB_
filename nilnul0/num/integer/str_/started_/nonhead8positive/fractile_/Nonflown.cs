using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.str_.started_.nonhead8positive.fractile_
{
	

	public class Nonflown
	{
		private BigInteger _floor;

		public BigInteger ground
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private _fractile.denoms_.Nonunderflown _proper;

		public _fractile.denoms_.Nonunderflown proper
		{
			get { return _proper; }
			set { _proper = value; }
		}
		public Nonflown( BigInteger floor, _fractile.denoms_.Nonunderflown proper)
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
