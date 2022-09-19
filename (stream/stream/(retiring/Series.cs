using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.stream
{
	[Obsolete()]
	public class Series:
		nilnul.Box1<StreamI3>
		,
		nilnul.num.quotient._series_.AccumulatedI
		,nilnul.obj._slider_.MoveNextI
	{

		public Series(StreamI3 stream):base(stream)
		{


		}

		private Q1 _accumulated=0;
		public Simplify.Ed1 accumulated
		{
			get
			{
				return _accumulated;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_accumulated += boxed.next();
			//throw new NotImplementedException();
		}
	}
}
