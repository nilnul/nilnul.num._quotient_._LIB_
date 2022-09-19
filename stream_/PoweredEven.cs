using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream_
{
	public class PoweredEven
		: nilnul.num.quotient.StreamI3
	{
		

		public PoweredEven(Q1 q)
		{
			_squared = nilnul.num.quotient.op.SquareX.Square(q);
			_accumulated = 1;
		}

		private Q1 _accumulated;

		public Q1 accumulated
		{
			get { return _accumulated; }
			set { _accumulated = value; }
		}

		private Q1 _squared;

		public Q1 squared
		{
			get { return _squared; }
			set { _squared = value; }
		}


		public Simplify.Ed1 next()
		{
			var r = _accumulated;
			_accumulated *= _squared;
			return r;

			throw new NotImplementedException();
		}
	}
}
