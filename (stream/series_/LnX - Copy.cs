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

namespace nilnul.num.quotient.series_
{
	/// <summary>
	/// the expansion of Ln(Q) to a series (accumulated sum of a stream)
	/// </summary>
	public class LnX:SeriesI
	{
		

		private q.StreamI3 _streamB4Series;

		public q.StreamI3 streamB4Series
		{
			get { return _streamB4Series; }
			//set { _streamB4Series = value; }
		}


		public LnX(nilnul.num.quotient.be_.Positive1.En x)
			:this(x.val)
		{

		}

		private LnX(Q1 x)
			
		{


			var _y = (x - 1) / (x + 1);

			var _2y = 2 * _y;
			_ySquared = q.op.SquareX.Square(_y);


			_streamB4Series = new stream.eg.Repeater(_2y).Multi(
					new stream_.OddUnitary().Multi(
						new stream_.Powered(_ySquared)
					)
			);

			_nextItem = (_streamB4Series as nilnul._stream_.NextI<Q1>).next();
			
		}



		private Q1 _accumulated=0;

		public Q1 accumulated
		{
			get {
				return _accumulated;

			}
			//set { _accumulated = value; }
		}

		private Q1 _nextItem;
		public Q1 nextAugend
		{
			get

			{
				return _nextItem;
				throw new NotImplementedException();
			}
		}

		private Q1 _ySquared;

		public Q1 ySquared
		{
			get { return _ySquared; }
			//set { _ySquared = value; }
		}


		public Simplify.Ed1 next()
		{
			_accumulated += _nextItem;

			_nextItem=(_streamB4Series as nilnul._stream_.NextI<Q1>).next();

			return _accumulated;

			throw new NotImplementedException();
		}


	
	}
}
