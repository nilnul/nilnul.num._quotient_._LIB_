using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.series
{
	public class FroStream
		:nilnul.Box1<quotient.StreamI3>
		,
		nilnul.num.quotient.SliderI

	{


		public FroStream(StreamI3 s):base(s)
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

		public Q1 current
		{
			get
			{
				return _accumulated;
				throw new NotImplementedException();
			}
		}

		public void moveNext()
		{

			_accumulated += (boxed as nilnul._stream_.NextI<Q1>).next();

			//throw new NotImplementedException();
		}
	}
}
