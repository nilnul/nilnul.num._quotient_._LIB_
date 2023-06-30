using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream.holdable
{[Obsolete()]
	public class Series
		:
		
		nilnul.num.quotient._stream_.InitedI
	{
		private Holdable _holdable;

		public Holdable holdable
		{
			get { return _holdable; }
			set { _holdable = value; }
		}

		public Q1 nextAugend { get {

				return _holdable.accumulated;
			}

		}

		private Q1 _current = 0;
		public Simplify.Ed1 accumulated
		{
			get
			{
				return _current;

				throw new NotImplementedException();
			}
		}

		public Series(Holdable holdable)
		{
			_holdable = holdable;
		}

		public Series(StreamI3 stream)
			:this(new Holdable(stream))
		{

			
		}

		public void moveNext()
		{
			_current += nextAugend;
			_holdable.moveNext();


			//throw new NotImplementedException();
		}
	}
}
