using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.quotient._stream
{
	public class ContinuedFraction
		:StreamI
	{
		private BigInteger _floor;
		public BigInteger floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private nilnul.num.quotient._stream._continuedFraction.Tail _tail;

		public nilnul.num.quotient._stream._continuedFraction.Tail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Q next()
		{
			return _tail.next() + _floor;
			throw new NotImplementedException();
		}

		public void reset()
		{
			_tail.reset();
			throw new NotImplementedException();
		}
	}
}
