using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.holdable.series
{
	public class Lag
		: nilnul.num.quotient._stream_.InitedI
	{

		private holdable.Series _series;

		public holdable.Series series
		{
			get { return _series; }
			//set { _series = value; }
		}


		//private Q1 _accumulated;

		//public Q1 accumulated
		//{
		//	get { return _accumulated; }
		//	set { _accumulated = value; }
		//}

		private Q1 _nextAugend;

		public Q1 nextAugend
		{
			get
			{
				return _nextAugend;
				//return _nextAugend;

			}
			//set { _nextAugend = value; }
		}



		public Lag( Series series  )
		{
			_series = series;

			_current = _series.accumulated;
			_nextAugend = _series.nextAugend;

			_series.moveNext();

			//_nextAccumulated = _series.current;

		}

		public Lag(Holdable holdable)
			:this(new Series(holdable))
		{

		}

		public Lag(StreamI3 stream)
			:this(new Holdable(stream))
		{

		}

		//private Q1 _nextAccumulated;

		public Q1 nextAccumulated
		{
			get
			{
				return _series.accumulated;

			}
		}


		private Q1 _current;

		public Simplify.Ed1 accumulated
		{
			get
			{
				return _current;

				//throw new NotImplementedException();
			}
		}



		public void moveNext()
		{
			_current = _series.accumulated;
			_nextAugend = _series.nextAugend;

			_series.moveNext();

		//	_nextAccumulated = _series.current;


			//	throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"current:{_current};nextAugend:{_nextAugend};nextAccumulated:{nextAccumulated}";
		}
	}
}
