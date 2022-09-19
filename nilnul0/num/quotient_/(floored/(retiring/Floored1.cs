using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{

	public class Floored1
	{
		private BigInteger _floor;

		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private be.Tail1.En _tail;

		public be.Tail1.En tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Floored1(BigInteger floor, be.Tail1.En tail)
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
			return _floor + _tail.ceil();
		}

		

		



	}


}
