using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using N = nilnul._num.bigint.be.Positive.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.num.quotient.stream.duo.op;

namespace nilnul.num.quotient.stream_
{
	/// <summary>
	/// expansiong of Ln(Q)
	/// </summary>
	///
	[Obsolete()]
	public class LnX
		:
		quotient.StreamI3
	{
		public LnX(Q1 x)
		{
			var _y = (x - 1) / (x + 1);

			var _2y = 2 * _y;
			var _ySquared = q.op.SquareX.Square(_y);


			_multiExpr =new stream.duo.op.call.Multi( 
				
				new stream.eg.Repeater(_2y)
				,
				
				(
				 stream.op_.Accumulate.Singleton.eval(
					new stream_.Powered(_ySquared)
					.Multi(
						 new stream_.OddUnitary()
					)
					)
				)
			);
		}


		


		private stream.duo.op.call.Multi _multiExpr;

		public stream.duo.op.call.Multi multiExpr
		{
			get { return _multiExpr; }
		}


		public Simplify.Ed1 next()
		{
			return _multiExpr.next();
			throw new NotImplementedException();
		}


	
	}
}
