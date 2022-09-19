using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient
{

	public class Floored
	{
		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private be.Tail.Asserted _tail;

		public be.Tail.Asserted tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Floored(BigInteger floor, be.Tail.Asserted tail)
		{
			_floor = floor;
			_tail = tail;

		}



		public override string ToString()
		{
			return string.Format("{0}+{1}",_floor, _tail);
			//return base.ToString();
		}

		public BigInteger round() {
			return _floor + _tail.round();
		}

		public BigInteger ceil() {
			return _floor + _tail.floor();
		}

		

		



	}


}
